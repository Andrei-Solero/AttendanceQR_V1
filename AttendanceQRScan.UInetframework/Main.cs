using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AttendanceQRScan.BusinessLogic;
using AttendanceQRScan.Helper;
using AttendanceQRScan.Models;
using AttendanceQRScan.UInetframework.UserControls;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AttendanceQRScan.UInetframework
{
    public partial class Main : MaterialForm
    {
        EmployeeFuncs empFuncs;
        DepartmentFuncs depFuncs;
        AttendanceFuncs attendanceFuncs;
        ImageTools imageTool;

        public Main()
        {
            InitializeComponent();

            empFuncs = new EmployeeFuncs();
            depFuncs = new DepartmentFuncs();
            attendanceFuncs = new AttendanceFuncs();
            imageTool = new ImageTools();
        }

        private void Main_New_Load(object sender, EventArgs e)
        {
            realTimeAttendanceTimer.Enabled = true;
            lblEmpCountAttendance.Text = TotalNumberOfEmployees().ToString();

            LoadDepartmentForAttendanceFiltering();

            FillDepartmentChart();
            DepartmentsList();

            LoadEmployees();
            LoadDepartmentForEmployeeFiltering();
            lblEmployeeTotalCount.Text = $"Total Employees: {TotalNumberOfEmployees().ToString()}";
        }

        private int TotalNumberOfEmployees()
        {
            return empFuncs.GetAllEmployees().Count();
        }

        private IEnumerable<Department> Departments()
        {
            return depFuncs.Departments();
        }


        #region Real Time Attendance

        private void LoadDepartmentForAttendanceFiltering()
        {
            var departments = Departments();
            cmbAttendanceDepartment.Items.Clear();
            foreach (var department in departments)
            {
                cmbAttendanceDepartment.Items.Add(department);
            }
        }

        private void LoadRealTimeAttendance()
        {
            var attendances = attendanceFuncs.GetAttendanceByDate(DateTime.Now);
            var lateEmps = attendanceFuncs.GetLateEmployees(attendances);
            var onTimeEmps = attendanceFuncs.GetOnTimeEmployees(attendances);

            int totalAttendedEmps = (int)lateEmps.Count() + (int)onTimeEmps.Count();

            lblOnTimeEmps.Text = onTimeEmps.Count().ToString();
            lblLateEmps.Text = lateEmps.Count().ToString();
            lblAttendedEmps.Text = totalAttendedEmps.ToString();

            LoadAttendanceDataToListControl(attendances);
        }

        private void FilterAttendanceByDepartment(Department department)
        {
            var attendances = attendanceFuncs.GetCurrentDayAttendanceByDepartmentAndDate(department);
            LoadAttendanceDataToListControl(attendances);
        }

        private void FilterAttendanceByEmpNameSearch(string searchQuery)
        {
            var attendances = attendanceFuncs.GetCurrentDayAttendanceByEmployeeName(searchQuery);
            LoadAttendanceDataToListControl(attendances);
        }

        private void LoadAttendanceDataToListControl(IEnumerable<AttendanceModel> attendances)
        {
            AttendanceDetail attendanceDetail;
            listAttendances.Controls.Clear();
            foreach (var attendance in attendances)
            {
                attendanceDetail = new AttendanceDetail(attendance);
                listAttendances.Controls.Add(attendanceDetail);
            }
        }

        private void realTimeAttendanceTimer_Tick(object sender, EventArgs e)
        {
            LoadRealTimeAttendance();
        }

        private void cmbAttendanceDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAttendanceDepartment.SelectedItem != null)
            {
                txtEmpNameSearchQuery.Text = "";
                realTimeAttendanceTimer.Enabled = false;
                FilterAttendanceByDepartment((Department)cmbAttendanceDepartment.SelectedItem);
            } 
        }

        private void txtEmpNameSearchQuery_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmpNameSearchQuery.Text))
            {
                cmbAttendanceDepartment.SelectedItem = null;
                realTimeAttendanceTimer.Enabled = false;
                FilterAttendanceByEmpNameSearch(txtEmpNameSearchQuery.Text);
            }

        }

        private void btnAttendanceClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmpNameSearchQuery.Text = "";
            cmbAttendanceDepartment.SelectedItem = null;
            realTimeAttendanceTimer.Enabled = true;
            LoadRealTimeAttendance();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTimedate.Text = $"Date Today: {DateTime.Now.ToLongDateString()} Time: {DateTime.Now.ToLongTimeString()}";
        }

        #endregion

        #region Department Configuration

        private void FillDepartmentChart()
        {
            var deptEmpCount = depFuncs.DepartmentsWithEmployeeCount();

            foreach (var department in deptEmpCount)
            {
                if (department.Count > 0)
                    departmentChart.Series[0].Points.AddXY($"{department.Department.Name}", department.Count);
            }
        }

        private void DepartmentsList()
        {
            var departments = depFuncs.DepartmentsWithEmployeeCount();
            LoadDepartmentsToList(departments);
        }

        private void LoadDepartmentsToList(IEnumerable<DepartmentCountEmployee> departments)
        {
            DepartmentDetails depDetails;
            listDepartments.Controls.Clear();
            foreach (var department in departments)
            {
                depDetails = new DepartmentDetails(department);
                listDepartments.Controls.Add(depDetails);
            }
        }

        private void txtSearchDepartment_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchDepartment.Text))
            {
                var filteredDepartment = depFuncs.SearchDepartmentByName(txtSearchDepartment.Text);
                LoadDepartmentsToList(filteredDepartment);
            }
            else
                DepartmentsList();
        }

        #endregion

        #region Employee Configuration

        private void LoadEmployeeToList(IEnumerable<Employee> employees)
        {
            EmployeeDetails empDetails;
            listEmployees.Controls.Clear();
            foreach (var employee in employees)
            {
                empDetails = new EmployeeDetails(employee, this);
                listEmployees.Controls.Add(empDetails);
            }
        }

        public void LoadEmployees()
        {
            var employees = empFuncs.GetAllEmployees();
            LoadEmployeeToList(employees);
        }

        private void FilterdEmployeesByDepartment(Department department)
        {
            var filteredEmployee = empFuncs.FilterEmployeeByDepartment(department);
            LoadEmployeeToList(filteredEmployee);
        }

        private void cmbFilterEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFilterEmployeeByDepartment.SelectedItem != null)
            {
                txtEmpNameSearch.Text = "";
                FilterdEmployeesByDepartment((Department)cmbFilterEmployeeByDepartment.SelectedItem);
            }
        }

        private void LoadDepartmentForEmployeeFiltering()
        {
            var departments = Departments();
            cmbFilterEmployeeByDepartment.Items.Clear();
            foreach (var department in departments)
            {
                cmbFilterEmployeeByDepartment.Items.Add(department);
            }
        }

        private void txtEmpNameSearch_TextChanged(object sender, EventArgs e)
        {
            var filteredList = empFuncs.FilterEmployeeByEmpName(txtEmpNameSearch.Text);
            LoadEmployeeToList(filteredList);
            cmbFilterEmployeeByDepartment.SelectedValue = null;
        }

        private void empClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmpNameSearch.Text = "";
            cmbFilterEmployeeByDepartment.SelectedValue = null;
            LoadEmployees();
        }

        private void addNewEmp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenerateEmployee newEmployee = new GenerateEmployee(this);
            newEmployee.ShowDialog();
        }

        #endregion

    }
}
