using AttendanceQRScan.Models;
using AttendanceQRScan.Repository;
using AttendanceQRScan.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace AttendanceQRScan.Services
{
    public class _Employee
    {
        IRepository_ADONETSQL repo;

        public void Generate(Employee emp)
        {
            string spName = "SPEmployeeAddNew";
            repo = new Repository_ADONET(spName);
            repo.Parameter_Value.Add(("EmployeeID", emp.EmployeeID.ToString(), SqlDbType.VarChar));
            repo.Parameter_Value.Add(("DepartmentID", emp.Department.DepartmentID.ToString(), SqlDbType.Int));
            repo.Parameter_Value.Add(("FirstName", emp.FirstName.ToString(), SqlDbType.VarChar));
            repo.Parameter_Value.Add(("MiddleName", emp.MiddleName.ToString(), SqlDbType.VarChar));
            repo.Parameter_Value.Add(("LastName", emp.LastName.ToString(), SqlDbType.VarChar));
            repo.Parameter_Value.Add(("ContactNumber", emp.ContactNumber.ToString(), SqlDbType.VarChar));
            repo.Parameter_Value.Add(("EmailAddress", emp.EmailAddress.ToString(), SqlDbType.VarChar));
            repo.Parameter_Value.Add(("HomeAddress", emp.HomeAddress.ToString(), SqlDbType.VarChar));

            repo.ModifyData();
        }

        public Employee GetEmployeeByID(string empID)
        {
            Employee emp = null;
            string spName = "SPEmployeeGetByQRID";
            repo = new Repository_ADONET(spName);
            repo.Parameter_Value.Add(("QRID", empID, SqlDbType.VarChar));

            var data = repo.FetchData();

            if (data.Read())
            {
                emp = new Employee
                {
                    EmployeeID = data["EmployeeID"].ToString(),
                    FirstName = data["FirstName"].ToString(),
                    MiddleName = data["MiddleName"].ToString(),
                    LastName = data["LastName"].ToString(),
                    ContactNumber = data["ContactNumber"].ToString(),
                    EmailAddress = data["EmailAddress"].ToString(),
                    HomeAddress = data["HomeAddress"].ToString(),
                    EmploymentStatus = data["EmploymentStatus"].ToString(),
                    Department = new Department
                    {
                        DepartmentID = int.Parse(data["DepartmentId"].ToString()),
                        Name = data["DepartmentName"].ToString(),
                        WorkedHours_In = DateTime.Parse(data["Dept_WorkedHours_In"].ToString()),
                        WorkedHours_Out = DateTime.Parse(data["Dept_WorkedHours_Out"].ToString())
                    }
                };
            }

            return emp;
        }

        public IEnumerable<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            string spName = "SPEmployeeGetAll";
            repo = new Repository_ADONET(spName);

            var data = repo.FetchData();

            while (data.Read())
            {
                employees.Add(new Employee
                {
                    EmployeeID = data["EmployeeID"].ToString(),
                    FirstName = data["FirstName"].ToString(),
                    MiddleName = data["MiddleName"].ToString(),
                    LastName = data["LastName"].ToString(),
                    ContactNumber = data["ContactNumber"].ToString(),
                    EmailAddress = data["EmailAddress"].ToString(),
                    HomeAddress = data["HomeAddress"].ToString(),
                    EmploymentStatus = data["EmploymentStatus"].ToString(),
                    Department = new Department
                    {
                        DepartmentID = int.Parse(data["DepartmentID"].ToString()),
                        Name = data["DepartmentName"].ToString(),
                        WorkedHours_In = DateTime.Parse(data["Dept_WorkedHours_In"].ToString()),
                        WorkedHours_Out = DateTime.Parse(data["Dept_WorkedHours_Out"].ToString())
                    }
                });
            }

            return employees;
        }

        public IEnumerable<Employee> GetEmployeeByDepartment(Department department)
        {
            var employees = GetAll();

            var query = employees
                .Where(employee => employee.Department.Name.Equals(department.Name))
                .Select(employee => new Employee
                {
                    EmployeeID = employee.EmployeeID,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    ContactNumber = employee.ContactNumber,
                    EmailAddress = employee.EmailAddress,
                    HomeAddress = employee.HomeAddress,
                    EmploymentStatus = employee.EmploymentStatus,
                    Department = new Department
                    {
                        DepartmentID = employee.Department.DepartmentID,
                        Name = employee.Department.Name,
                        WorkedHours_In = employee.Department.WorkedHours_In,
                        WorkedHours_Out = employee.Department.WorkedHours_Out
                    }
                });

            var filteredList = query.ToList();

            return filteredList;
        }

        public IEnumerable<Employee> GetEmployeeByEmployeeName(string empNameSearchQuery)
        {
            var employees = GetAll();

            var query = employees
                .Where(employee => (employee.FirstName.ToLower() + " " + employee.LastName.ToLower()).Contains(empNameSearchQuery.ToLower()))
                .Select(employee => new Employee
                {
                    EmployeeID = employee.EmployeeID,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    ContactNumber = employee.ContactNumber,
                    EmailAddress = employee.EmailAddress,
                    HomeAddress = employee.HomeAddress,
                    EmploymentStatus = employee.EmploymentStatus,
                    Department = new Department
                    {
                        DepartmentID = employee.Department.DepartmentID,
                        Name = employee.Department.Name,
                        WorkedHours_In = employee.Department.WorkedHours_In,
                        WorkedHours_Out = employee.Department.WorkedHours_Out
                    }
                });

            var filteredList = query.ToList();

            return filteredList;
        }

    }
}
