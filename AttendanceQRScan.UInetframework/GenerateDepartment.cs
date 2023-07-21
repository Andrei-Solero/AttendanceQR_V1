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
    public partial class GenerateDepartment : Form
    {
        DepartmentFuncs departmentFuncs;

        public GenerateDepartment()
        {
            InitializeComponent();

            departmentFuncs = new DepartmentFuncs();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Department department = new Department
            {
                Name = txtDepartmentName.Text,
                WorkedHours_In = timeStart.Value,
                WorkedHours_Out = timeEnd.Value
            };

            departmentFuncs.GenerateDepartment(department);
        }
    }
}
