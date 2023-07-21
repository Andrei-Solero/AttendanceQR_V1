using AttendanceQRScan.Helper;
using AttendanceQRScan.Models;
using AttendanceQRScan.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AttendanceQRScan.BusinessLogic
{
    public class EmployeeFuncs
    {
        _Employee employeeService;
        _QRCode qrCodeService;
        InformationExtraction infoExtract;
        ImageTools saveTools;

        public EmployeeFuncs()
        {
            employeeService = new _Employee();
            qrCodeService = new _QRCode();
            infoExtract = new InformationExtraction();
            saveTools = new ImageTools();
        }

        public Bitmap GenerateEmployee_QR(Employee emp, Bitmap empImage)
        {
            string empInitial = infoExtract.GenerateInitialsByFullName(emp.FirstName, emp.MiddleName, emp.LastName);
            string guid = Guid.NewGuid().ToString();
            emp.EmployeeID = $"{guid}-{empInitial}";

            employeeService.Generate(emp);

            Bitmap qrCodeImage = qrCodeService.Generate(emp.EmployeeID);
            saveTools.SaveQR_Image(qrCodeImage, empImage, emp.EmployeeID);

            return qrCodeImage;
        }

        public Employee GetEmployeeByID(string empID)
        {
            return employeeService.GetEmployeeByID(empID);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeService.GetAll();
        }

        public IEnumerable<Employee> FilterEmployeeByName(string searchQuery)
        {
            IEnumerable<Employee> employees = GetAllEmployees();

            return from emp in employees
                   where ($"{emp.FirstName.ToLower()} {emp.LastName.ToLower()}").Contains(searchQuery)
                   select new Employee
                   {
                       EmployeeID = emp.EmployeeID,
                       FirstName = emp.FirstName,
                       MiddleName = emp.MiddleName,
                       LastName = emp.LastName,
                       ContactNumber = emp.ContactNumber,
                       EmailAddress = emp.EmailAddress,
                       HomeAddress = emp.HomeAddress,
                       Department = new Department
                       {
                           DepartmentID = emp.Department.DepartmentID,
                           Name = emp.Department.Name,
                           WorkedHours_In = emp.Department.WorkedHours_In,
                           WorkedHours_Out = emp.Department.WorkedHours_Out
                       }
                   };
        }

        public IEnumerable<Employee> FilterEmployeeByDepartment(Department department)
        {
            IEnumerable<Employee> employees = GetAllEmployees();

            var query = from emp in employees
                        where emp.Department.DepartmentID == department.DepartmentID
                        select new Employee
                        {
                            EmployeeID = emp.EmployeeID,
                            FirstName = emp.FirstName,
                            MiddleName = emp.MiddleName,
                            LastName = emp.LastName,
                            ContactNumber = emp.ContactNumber,
                            EmailAddress = emp.EmailAddress,
                            HomeAddress = emp.HomeAddress,
                            Department = new Department
                            {
                                DepartmentID = emp.Department.DepartmentID,
                                Name = emp.Department.Name,
                                WorkedHours_In = emp.Department.WorkedHours_In,
                                WorkedHours_Out = emp.Department.WorkedHours_Out
                            }
                        };

            var filteredList = query.ToList<Employee>();

            return filteredList;
        }
    }
}
