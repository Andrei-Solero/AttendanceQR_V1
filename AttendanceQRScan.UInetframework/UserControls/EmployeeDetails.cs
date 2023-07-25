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
    public partial class EmployeeDetails : UserControl
    {
        private readonly Employee employee;
        ImageTools imageTool;

        public EmployeeDetails(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            imageTool = new ImageTools();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            lblEmpName.Text = $"{employee.FirstName} {employee.MiddleName}. {employee.LastName}";
            lblDepartment.Text = $"{employee.Department.Name}\n" +
                $"{employee.Department.WorkedHours_In.ToLongTimeString()} - {employee.Department.WorkedHours_Out.ToLongTimeString()}";
            lblContact.Text = employee.ContactNumber;
            lblEmail.Text = employee.EmailAddress;
            lblHomeAddress.Text = employee.HomeAddress;

            empImage.Image = Image.FromFile(imageTool.LoadEmployeeImage(employee.EmployeeID));

            employmentStatus.Image =
                employee.EmploymentStatus == "Active" ? Properties.Resources.round
                : Properties.Resources.circle;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            GenerateEmployee modifyEmployee = new GenerateEmployee(this.employee);
            modifyEmployee.ShowDialog();
        }

        private void btnViewQR_Click(object sender, EventArgs e)
        {
            QRCodeView qrView = new QRCodeView(employee.EmployeeID);
            qrView.ShowDialog();
        }
    }
}
