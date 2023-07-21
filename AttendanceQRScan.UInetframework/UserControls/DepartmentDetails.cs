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
    public partial class DepartmentDetails : UserControl
    {
        private readonly DepartmentCountEmployee departmentWithEmpCount;

        public DepartmentDetails(DepartmentCountEmployee departmentWithEmpCount)
        {
            InitializeComponent();
            this.departmentWithEmpCount = departmentWithEmpCount;
        }

        private void DepartmentDetails_Load(object sender, EventArgs e)
        {
            lblDepartmentName.Text = departmentWithEmpCount.Department.Name;
            lblSchedEmpCount.Text = $"Schedule: {departmentWithEmpCount.Department.WorkedHours_In.ToString("hh:mm")}am - " +
                $"{departmentWithEmpCount.Department.WorkedHours_Out.ToString("hh:mm")}am\n" +
                $"No. of Employees: {departmentWithEmpCount.Count}";
        }
    }
}
