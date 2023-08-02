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

        public void UpdateEmployee(Employee emp)
        {
            employeeService.Modify(emp);
        }

        public void DeactivateEmployee(Employee emp)
        {
            employeeService.DeactivateEmploymentStatus(emp);
        }

        public void DeleteEmployee(Employee emp)
        {
            employeeService.DeleteEmployee(emp);
        }

        public Employee GetEmployeeByID(string empID)
        {
            return employeeService.GetEmployeeByID(empID);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeService.GetAll();
        }

        public IEnumerable<Employee> FilterEmployeeByDepartment(Department department)
        {
            return employeeService.GetEmployeeByDepartment(department);
        }


        public IEnumerable<Employee> FilterEmployeeByEmpName(string empNameSearchQuery)
        {
            return employeeService.GetEmployeeByEmployeeName(empNameSearchQuery);
        }

    }
}
