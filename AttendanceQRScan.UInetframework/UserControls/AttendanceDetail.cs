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

namespace AttendanceQRScan.UInetframework.UserControls
{
    public partial class AttendanceDetail : UserControl
    {
        private readonly AttendanceModel attendance;
        private readonly ImageTools imageTool;

        public AttendanceDetail(AttendanceModel attendance)
        {
            InitializeComponent();
            this.attendance = attendance;
            imageTool = new ImageTools();
        }

        private void AttendanceDetail_Load(object sender, EventArgs e)
        {
            try
            {
                lblEmployeeName.Text = $"{attendance.Employee.LastName}, {attendance.Employee.FirstName} {attendance.Employee.MiddleName.Substring(0, 1)}";
                lblDepartment.Text = $"{attendance.Employee.Department.Name}: {attendance.Employee.Department.WorkedHours_In.ToLongTimeString()}-{attendance.Employee.Department.WorkedHours_Out.ToLongTimeString()}";
                lblEmpTime.Text = 
                    string.IsNullOrEmpty(attendance.WholeDayAttendanceStatus) ? $"In: {attendance.EmpTimeIn.ToLongTimeString()}" 
                    : $"In: {attendance.EmpTimeIn.ToLongTimeString()} \nOut: {attendance.EmpTimeOut.ToLongTimeString()}";
                lblAttendanceStats.Text = attendance.InStatus;
                lblAttendanceStats.ForeColor = attendance.InStatus == "On Time" ? Color.Green : Color.Red;
                empImage.Image = Image.FromFile(imageTool.LoadEmpployeeImage(attendance.Employee.EmployeeID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); ;
            }
            
        }
    }
}
