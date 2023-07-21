using AForge.Video.DirectShow;
using Attendance.QRScan.UIScan.netframework.UserControls;
using AttendanceQRScan.BusinessLogic;
using AttendanceQRScan.Helper;
using AttendanceQRScan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Attendance.QRScan.UIScan.netframework
{
    public partial class QRScanning : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        QRFuncs qrFuncs;
        AttendanceFuncs attendanceFuncs;
        EmployeeFuncs employeeFuncs;
        ImageTools imageTool;
        ScannedOutput output;

        private readonly string monikerDevice;

        public QRScanning(string monikerDevice)
        {
            InitializeComponent();

            qrFuncs = new QRFuncs();
            attendanceFuncs = new AttendanceFuncs();
            employeeFuncs = new EmployeeFuncs();
            imageTool = new ImageTools();

            this.monikerDevice = monikerDevice;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        private void UploadAttendance(string empID)
        {
            AttendanceModel attendance = new AttendanceModel
            {
                Employee = new Employee
                {
                    EmployeeID = empID,
                },
                TransactionDate = DateTime.Now,
                EmpTimeIn = DateTime.Now,
                EmpTimeOut = DateTime.Now,
            };

            AttendanceModel attendanceDetails = attendanceFuncs.UploadAttendance(attendance);

            output = new ScannedOutput(attendanceDetails);
            outputPanel.Controls.Add(output);
            output.BringToFront();
        }

        private void QRScanning_Load(object sender, EventArgs e)
        {
            imageCamera.Image = null;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                imageCamera.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageCamera.Image != null)
            {
                string qrResult = qrFuncs.QRReadResult((Bitmap)imageCamera.Image);
                if (qrResult != null || qrResult == "")
                {
                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                    }

                    Employee empDetails = employeeFuncs.GetEmployeeByID(qrResult);
                    UploadAttendance(qrResult);
                    showingDetailsTimer.Start();
                }
            }
        }

        private void QRScanning_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void showingDetailsTimer_Tick(object sender, EventArgs e)
        {
            outputPanel.Controls.Remove(output);
            imageCamera.Image = null;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();

            showingDetailsTimer.Stop();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = $"{DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}";
        }
    }
}
