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
using System.Windows.Forms.DataVisualization.Charting;

namespace AttendanceQRScan.UInetframework
{
    public partial class GenerateEmployee : Form
    {
        DepartmentFuncs departmentFuncs;
        EmployeeFuncs employeeFuncs;
        bool IsEdit = false;
        private readonly Employee employee;
        ImageTools imageTool;

        public GenerateEmployee()
        {
            InitializeComponent();
            departmentFuncs = new DepartmentFuncs();
            employeeFuncs = new EmployeeFuncs();
            imageTool = new ImageTools();
        }

        /// <summary>
        /// Use this constructor for modifying employee's detail
        /// </summary>
        /// <param name="employee"></param>
        public GenerateEmployee(Employee employee)
        {
            InitializeComponent();
            IsEdit = true;
            departmentFuncs = new DepartmentFuncs();
            employeeFuncs = new EmployeeFuncs();
            imageTool = new ImageTools();

            this.employee = employee;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Department = (Department)cmbDepartment.SelectedItem,
                FirstName = txtFirstname.Text,
                MiddleName = txtMiddlename.Text,
                LastName = txtLastname.Text,
                ContactNumber = txtContactNumber.Text,
                EmailAddress = txtEmail.Text,
                HomeAddress = txtHomeAddress.Text,
            };

            Bitmap qrCode = employeeFuncs.GenerateEmployee_QR(emp, (Bitmap)empImage.Image);
            empQRCode.Image = qrCode;
        }

        private void GenerateEmployee_Load(object sender, EventArgs e)
        {
            IEnumerable<Department> departments = departmentFuncs.Departments();

            cmbDepartment.Items.Clear();
            foreach (Department department in departments)
            {
                cmbDepartment.Items.Add(department);
            }

            switch (IsEdit)
            {
                case true:
                    txtFirstname.Text = employee.FirstName;
                    txtMiddlename.Text = employee.MiddleName;
                    txtLastname.Text = employee.LastName;
                    cmbDepartment.Text = employee.Department.ToString();
                    txtEmail.Text = employee.EmailAddress;
                    txtContactNumber.Text = employee.ContactNumber;
                    txtHomeAddress.Text = employee.HomeAddress;
                    empImage.Image = Image.FromFile(imageTool.LoadEmpployeeImage(employee.EmployeeID));
                    break;
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

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you to discard the changes?", "Discard Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        //private void btnAddDepartment_Click(object sender, EventArgs e)
        //{
        //    GenerateDepartment department = new GenerateDepartment();
        //    department.ShowDialog();
        //}

        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    GenerateEmployee_Load(sender, e);
        //}
    }
}
