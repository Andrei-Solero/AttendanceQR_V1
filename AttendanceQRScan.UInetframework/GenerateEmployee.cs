using AttendanceQRScan.BusinessLogic;
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

namespace AttendanceQRScan.UInetframework
{
    public partial class GenerateEmployee : Form
    {
        DepartmentFuncs departmentFuncs;
        EmployeeFuncs employeeFuncs;

        public GenerateEmployee()
        {
            InitializeComponent();
            departmentFuncs = new DepartmentFuncs();
            employeeFuncs = new EmployeeFuncs();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Department = (Department)cmbDepartment.SelectedItem,
                FirstName = txtFirstname.Text,
                MiddleName = txtMiddleame.Text,
                LastName = txtLastname.Text,
                ContactNumber = txtContact.Text,
                EmailAddress = txtEmail.Text,
                HomeAddress = txtHomeAddress.Text,
            };

            Bitmap qrCode = employeeFuncs.GenerateEmployee_QR(emp, (Bitmap)empImage.Image);
            empQrCode.Image = qrCode;
        }

        private void GenerateEmployee_Load(object sender, EventArgs e)
        {
            IEnumerable<Department> departments = departmentFuncs.Departments();

            cmbDepartment.Items.Clear();
            foreach (Department department in departments)
            {
                cmbDepartment.Items.Add(department);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                empImage.Image = new Bitmap(open.FileName);
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            GenerateDepartment department = new GenerateDepartment();
            department.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateEmployee_Load(sender, e);
        }
    }
}
