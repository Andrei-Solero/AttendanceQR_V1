using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceQRScan.Helper;
using AttendanceQRScan.Models;

namespace Attendance.QRScan.UIScan.netframework.UserControls
{
    public partial class ScannedOutput : UserControl
    {
        private readonly AttendanceModel attendance;
        ImageTools imageTool;

        public ScannedOutput(AttendanceModel attendance)
        {
            InitializeComponent();
            this.attendance = attendance;
            imageTool = new ImageTools();
        }

        private void ScannedOutput_Load(object sender, EventArgs e)
        {
            lblEmpName.Text = $"{this.attendance.Employee.FirstName} {this.attendance.Employee.MiddleName.Substring(0, 1)}, {this.attendance.Employee.LastName}";
            lblDepartment.Text = this.attendance.Employee.Department.Name;

            lblTimeSchedule.Text = $"Employee Time Schedule: {this.attendance.Employee.Department.WorkedHours_In.ToLongTimeString()} - {this.attendance.Employee.Department.WorkedHours_Out.ToLongTimeString()}";
            lblEmpTimeIn.Text = $"Employee Time In: {this.attendance.EmpTimeIn.ToLongTimeString()}";
            lblEmpTimeOut.Text = attendance.EmpTimeOut == attendance.EmpTimeIn ? $"Employee Time Out: - - -" : $"Employee Time Out: {this.attendance.EmpTimeOut.ToLongTimeString()}";
            lblAttendanceStatus.Text = $"In Status: {attendance.InStatus}";
            lblWholeDayStatus.Text = attendance.WholeDayAttendanceStatus != string.Empty ? $"Attendance Status: {attendance.WholeDayAttendanceStatus}({attendance.WorkedHours.Hours} Hours)" : "Attendance Status: - - -";

            string empImagePath = imageTool.LoadEmpployeeImage(this.attendance.Employee.EmployeeID);
            empImage.Image = Image.FromFile(empImagePath);
        }
    }
}
