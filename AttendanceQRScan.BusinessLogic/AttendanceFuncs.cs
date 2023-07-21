using AttendanceQRScan.Models;
using AttendanceQRScan.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceQRScan.BusinessLogic
{
    public class AttendanceFuncs
    {
        _Attendance attendanceService;
        _Employee employeeService;

        public AttendanceFuncs()
        {
            attendanceService = new _Attendance();
            employeeService = new _Employee();
        }

        public AttendanceModel UploadAttendance(AttendanceModel attendance)
        {
            AttendanceModel existingAttendance = attendanceService.GetAttendanceByEmployeeAndDate(attendance.Employee, attendance.TransactionDate);
            Employee emp = employeeService.GetEmployeeByID(attendance.Employee.EmployeeID);

            if (existingAttendance.Employee is null)
            {
                if (attendance.EmpTimeIn < emp.Department.WorkedHours_In)
                {
                    attendance.InStatus = "On Time";
                }
                else if (attendance.EmpTimeIn > emp.Department.WorkedHours_In)
                {
                    attendance.InStatus = "Late";
                }

                attendanceService.InsertAttendance(attendance, "Time_In");
            }
            else
            {
                if (string.IsNullOrEmpty(existingAttendance.WholeDayAttendanceStatus))
                {
                    if (existingAttendance.EmpTimeIn <= emp.Department.WorkedHours_In)
                        attendance.WorkedHours = attendance.EmpTimeOut - existingAttendance.Employee.Department.WorkedHours_In - TimeSpan.FromHours(1);
                    else
                        attendance.WorkedHours = attendance.EmpTimeOut - existingAttendance.EmpTimeIn - TimeSpan.FromHours(1);

                    if (attendance.WorkedHours.TotalHours >= 8 && attendance.WorkedHours.TotalHours < 9)
                        attendance.WholeDayAttendanceStatus = "Regular";
                    else if (attendance.WorkedHours.TotalHours >= 9)
                        attendance.WholeDayAttendanceStatus = "Overtime";
                    else if (attendance.WorkedHours.TotalHours < 8)
                        attendance.WholeDayAttendanceStatus = "Undertime";
                    attendance.AttendanceID = existingAttendance.AttendanceID;

                    attendanceService.InsertAttendance(attendance, "Time_Out");
                }
            }

            return EmployeeAttendanceByDate(attendance.Employee, attendance.TransactionDate);
        }

        public IEnumerable<AttendanceModel> Attendances()
        {
            return attendanceService.GetAttendances();
        }

        public IEnumerable<AttendanceModel> GetAttendanceByDate(DateTime date)
        {
            return attendanceService.GetAttendanceBySelectedDate(date);
        }

        public IEnumerable<AttendanceModel> GetCurrentDayAttendanceByEmployeeName(string empNameQuery)
        {
            return attendanceService.GetAttendanceByEmployeeAndDate(empNameQuery, DateTime.Now);
        }

        public IEnumerable<AttendanceModel> GetCurrentDayAttendanceByDepartmentAndDate(Department department)
        {
            return attendanceService.GetAttendanceByDepartmentAndDate(department, DateTime.Now);
        }

        public IEnumerable<AttendanceModel> GetOnTimeEmployees(IEnumerable<AttendanceModel> attendances)
        {
            return attendanceService.GetAttendanceByInStatus(attendances, "On Time");
        }

        public IEnumerable<AttendanceModel> GetLateEmployees(IEnumerable<AttendanceModel> attendances)
        {
            return attendanceService.GetAttendanceByInStatus(attendances, "Late");
        }

        private AttendanceModel EmployeeAttendanceByDate(Employee employee, DateTime date)
        {
            return attendanceService.GetAttendanceByEmployeeAndDate(employee, date);
        }

    }
}
