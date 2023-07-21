using AttendanceQRScan.Models;
using AttendanceQRScan.Services;
using System;
using System.Collections.Generic;

namespace AttendanceQRScan.BusinessLogic
{
    public class DepartmentFuncs
    {
        _Department departmentService;

        public DepartmentFuncs()
        {
            departmentService = new _Department();
        }

        public void GenerateDepartment(Department departmentData)
        {
            departmentService.Generate(departmentData);
        }

        public IEnumerable<Department> Departments()
        {
            return departmentService.GetAll();
        }

        public IEnumerable<DepartmentCountEmployee> NumOfEmployeesByDepartment()
        {
            return departmentService.GetNumOfEmployeesByDepartment();
        }

    }
}
