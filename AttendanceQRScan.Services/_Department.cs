using AttendanceQRScan.Models;
using AttendanceQRScan.Repository;
using AttendanceQRScan.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;

namespace AttendanceQRScan.Services
{
    public class _Department
    {
        IRepository_ADONETSQL repo;

        public void Generate(Department department)
        {
            string spName = "SPDepartmentAddNew";
            repo = new Repository_ADONET(spName);
            repo.Parameter_Value.Add(("DepartmentName", department.Name, SqlDbType.VarChar));
            repo.Parameter_Value.Add(("WorkedHours_In", department.WorkedHours_In.ToShortTimeString(), SqlDbType.Time));
            repo.Parameter_Value.Add(("WorkedHours_Out", department.WorkedHours_Out.ToShortTimeString(), SqlDbType.Time));

            repo.ModifyData();
        }

        public IEnumerable<Department> GetAll()
        {
            List<Department> department = new List<Department>();
            string spName = "SPDepartmentGetAll";
            repo = new Repository_ADONET(spName);

            var data = repo.FetchData();

            while (data.Read())
            {
                department.Add(new Department
                {
                    DepartmentID = int.Parse(data["DepartmentID"].ToString()),
                    Name = data["DepartmentName"].ToString(),
                    WorkedHours_In = DateTime.Parse(data["Dept_WorkedHours_In"].ToString()),
                    WorkedHours_Out = DateTime.Parse(data["Dept_WorkedHours_Out"].ToString()),
                });
            }

            return department;
        }

        public IEnumerable<DepartmentCountEmployee> GetNumOfEmployeesByDepartment()
        {
            List<DepartmentCountEmployee> department = new List<DepartmentCountEmployee>();
            string spName = "SPDepartmentGetNumberOfEmployeeByDepartment";
            repo = new Repository_ADONET(spName);

            var data = repo.FetchData();

            while (data.Read())
            {
                department.Add(new DepartmentCountEmployee
                {
                    Department = new Department
                    {
                        Name = data["DepartmentName"].ToString(),
                        WorkedHours_In = DateTime.Parse(data["Dept_WorkedHours_In"].ToString()),
                        WorkedHours_Out = DateTime.Parse(data["Dept_WorkedHours_Out"].ToString()),
                    },
                    Count = int.Parse(data["NumberOfEmp"].ToString())            
                });
            }

            return department;
        }

    }
}
