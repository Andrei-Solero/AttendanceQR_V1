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

namespace AttendanceQRScan.UInetframework.UserControls
{
    public partial class EmployeeDetails : UserControl
    {
        EmployeeFuncs empFuncs;
        private readonly Employee employee;
        private readonly Main mainForm;
        ImageTools imageTool;

        public EmployeeDetails(Employee employee, Main mainForm)
        {
            InitializeComponent();
            this.employee = employee;
            this.mainForm = mainForm;
            imageTool = new ImageTools();
            empFuncs = new EmployeeFuncs();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show(
                "Are you sure you want to delete this employee?\n\n" +
                "Note: Deleting this employee will also remove all the employee's existing attendance\n" +
                "(We recommend to deactivate the employment status by pressing edit button)", "Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (delete == DialogResult.Yes)
            {
                empFuncs.DeleteEmployee(this.employee);
                mainForm.LoadEmployees();
            }
        }
    }
}
