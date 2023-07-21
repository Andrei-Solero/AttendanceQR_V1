using AttendanceQRScan.Models;
using AttendanceQRScan.Repository;
using AttendanceQRScan.Repository.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AttendanceQRScan.Services
{
    public class _Attendance
    {
        IRepository_ADONETSQL repo;

        public void InsertAttendance(AttendanceModel attendance, string attendanceTransaction)
        {
            switch (attendanceTransaction)
            {
                case "Time_In":
                    string spNameInsert = "SPAttendanceInsertAttendance";
                    repo = new Repository_ADONET(spNameInsert);
                    repo.Parameter_Value.Add(("@EmployeeID", attendance.Employee.EmployeeID, SqlDbType.VarChar));
                    repo.Parameter_Value.Add(("@TransactionDate", attendance.TransactionDate.ToShortDateString(), SqlDbType.Date));
                    repo.Parameter_Value.Add(("@EmpTimeIn", attendance.EmpTimeIn.ToShortTimeString(), SqlDbType.Time));
                    repo.Parameter_Value.Add(("@EmpTimeOut", attendance.EmpTimeOut.ToShortTimeString(), SqlDbType.Time));
                    repo.Parameter_Value.Add(("@InStatus", attendance.InStatus, SqlDbType.VarChar));

                    repo.ModifyData();
                    break;
                case "Time_Out":
                    string spNameUpdate = "SPAttendanceUpdateAttendance";
                    repo = new Repository_ADONET(spNameUpdate);
                    repo.Parameter_Value.Add(("@EmpTimeOut", attendance.EmpTimeOut.ToShortTimeString(), SqlDbType.Time));
                    repo.Parameter_Value.Add(("@WholeDayStatus", attendance.WholeDayAttendanceStatus, SqlDbType.VarChar));
                    repo.Parameter_Value.Add(("@WorkedHours", attendance.WorkedHours.ToString(), SqlDbType.VarChar));
                    repo.Parameter_Value.Add(("@AttendanceID", attendance.AttendanceID.ToString(), SqlDbType.Int));

                    repo.ModifyData();
                    break;
            }
        }

        public IEnumerable<AttendanceModel> GetAttendances()
        {
            List<AttendanceModel> attendances = new List<AttendanceModel>();
            string spName = "SPAttendanceGetAll";
            repo = new Repository_ADONET(spName);

            var data = repo.FetchData();

            while (data.Read())
            {
                attendances.Add(new AttendanceModel
                {
                    Employee = new Employee
                    {
                        EmployeeID = data["EmployeeID"].ToString(), FirstName = data["FirstName"].ToString(), 
                        MiddleName = data["MiddleName"].ToString(), LastName = data["LastName"].ToString(),
                        ContactNumber = data["ContactNumber"].ToString(), EmailAddress = data["EmailAddress"].ToString(), 
                        HomeAddress = data["HomeAddress"].ToString(), EmploymentStatus = data["EmploymentStatus"].ToString(),
                        Department = new Department 
                        {
                            DepartmentID = int.Parse(data["DepartmentID"].ToString()),
                            Name = data["DepartmentName"].ToString(),
                            WorkedHours_In = DateTime.Parse(data["Dept_WorkedHours_In"].ToString()),
                            WorkedHours_Out = DateTime.Parse(data["Dept_WorkedHours_Out"].ToString()),
                        }
                    },
                    AttendanceID = int.Parse(data["AttendanceID"].ToString()),
                    TransactionDate = DateTime.Parse(data["TransactionDate"].ToString()),
                    EmpTimeIn = DateTime.Parse(data["EmpTimeIn"].ToString()),
                    EmpTimeOut = DateTime.Parse(data["EmpTimeOut"].ToString()),
                    InStatus = data["InStatus"].ToString(),
                    WholeDayAttendanceStatus = data["WholeDayAttendanceStatus"].ToString(),
                    WorkedHours = TimeSpan.Parse(data["WorkedHours"].ToString())
                });
            }

            return attendances;
        }

        public IEnumerable<AttendanceModel> GetAttendanceBySelectedDate(DateTime selectedDate)
        {
            var attendances = GetAttendances();
            var query = attendances
                .Where(attendanceDate => attendanceDate.TransactionDate.ToShortDateString() == selectedDate.ToShortDateString())
                .Select(attendanceDate => new AttendanceModel
                {
                    Employee = new Employee
                    {
                        EmployeeID = attendanceDate.Employee.EmployeeID,
                        FirstName = attendanceDate.Employee.FirstName,
                        MiddleName = attendanceDate.Employee.MiddleName,
                        LastName = attendanceDate.Employee.LastName,
                        ContactNumber = attendanceDate.Employee.ContactNumber,
                        EmailAddress = attendanceDate.Employee.EmailAddress,
                        HomeAddress = attendanceDate.Employee.HomeAddress,
                        EmploymentStatus = attendanceDate.Employee.EmploymentStatus,
                        Department = new Department
                        {
                            DepartmentID = attendanceDate.Employee.Department.DepartmentID,
                            Name = attendanceDate.Employee.Department.Name,
                            WorkedHours_In = attendanceDate.Employee.Department.WorkedHours_In,
                            WorkedHours_Out = attendanceDate.Employee.Department.WorkedHours_Out,
                        }
                    },
                    AttendanceID = attendanceDate.AttendanceID,
                    TransactionDate = attendanceDate.TransactionDate,
                    EmpTimeIn = attendanceDate.EmpTimeIn,
                    EmpTimeOut = attendanceDate.EmpTimeOut,
                    InStatus = attendanceDate.InStatus,
                    WholeDayAttendanceStatus = attendanceDate.WholeDayAttendanceStatus,
                    WorkedHours = attendanceDate.WorkedHours
                });

            var filteredAttendanceByDate = query.ToList();

            return filteredAttendanceByDate;
        }

        public IEnumerable<AttendanceModel> GetAttendanceByDepartmentAndDate(Department department, DateTime selectedDate)
        {
            var attendances = GetAttendanceBySelectedDate(selectedDate);
            var query = attendances
                .Where(attendanceDepartment => attendanceDepartment.Employee.Department.Name == department.Name)
                .Select(attendanceDate => new AttendanceModel
                {
                    Employee = new Employee
                    {
                        EmployeeID = attendanceDate.Employee.EmployeeID,
                        FirstName = attendanceDate.Employee.FirstName,
                        MiddleName = attendanceDate.Employee.MiddleName,
                        LastName = attendanceDate.Employee.LastName,
                        ContactNumber = attendanceDate.Employee.ContactNumber,
                        EmailAddress = attendanceDate.Employee.EmailAddress,
                        HomeAddress = attendanceDate.Employee.HomeAddress,
                        EmploymentStatus = attendanceDate.Employee.EmploymentStatus,
                        Department = new Department
                        {
                            DepartmentID = attendanceDate.Employee.Department.DepartmentID,
                            Name = attendanceDate.Employee.Department.Name,
                            WorkedHours_In = attendanceDate.Employee.Department.WorkedHours_In,
                            WorkedHours_Out = attendanceDate.Employee.Department.WorkedHours_Out,
                        }
                    },
                    AttendanceID = attendanceDate.AttendanceID,
                    TransactionDate = attendanceDate.TransactionDate,
                    EmpTimeIn = attendanceDate.EmpTimeIn,
                    EmpTimeOut = attendanceDate.EmpTimeOut,
                    InStatus = attendanceDate.InStatus,
                    WholeDayAttendanceStatus = attendanceDate.WholeDayAttendanceStatus,
                    WorkedHours = attendanceDate.WorkedHours
                });

            var filteredList = query.ToList();

            return filteredList;
        }

        public IEnumerable<AttendanceModel> GetAttendanceByEmployeeAndDate(string empNameSearchQuery, DateTime selectedDate)
        {
            var attendances = GetAttendanceBySelectedDate(selectedDate);
            var query = attendances
                .Where(attendanceEmp => (attendanceEmp.Employee.FirstName + " " + attendanceEmp.Employee.LastName).Contains(empNameSearchQuery))
                .Select(attendanceEmp => new AttendanceModel
                {
                    Employee = new Employee
                    {
                        EmployeeID = attendanceEmp.Employee.EmployeeID,
                        FirstName = attendanceEmp.Employee.FirstName,
                        MiddleName = attendanceEmp.Employee.MiddleName,
                        LastName = attendanceEmp.Employee.LastName,
                        ContactNumber = attendanceEmp.Employee.ContactNumber,
                        EmailAddress = attendanceEmp.Employee.EmailAddress,
                        HomeAddress = attendanceEmp.Employee.HomeAddress,
                        EmploymentStatus = attendanceEmp.Employee.EmploymentStatus,
                        Department = new Department
                        {
                            DepartmentID = attendanceEmp.Employee.Department.DepartmentID,
                            Name = attendanceEmp.Employee.Department.Name,
                            WorkedHours_In = attendanceEmp.Employee.Department.WorkedHours_In,
                            WorkedHours_Out = attendanceEmp.Employee.Department.WorkedHours_Out,
                        }
                    },
                    AttendanceID = attendanceEmp.AttendanceID,
                    TransactionDate = attendanceEmp.TransactionDate,
                    EmpTimeIn = attendanceEmp.EmpTimeIn,
                    EmpTimeOut = attendanceEmp.EmpTimeOut,
                    InStatus = attendanceEmp.InStatus,
                    WholeDayAttendanceStatus = attendanceEmp.WholeDayAttendanceStatus,
                    WorkedHours = attendanceEmp.WorkedHours
                });

            var filteredList = query.ToList();

            return filteredList;
        }

        public IEnumerable<AttendanceModel> GetAttendanceByInStatus(IEnumerable<AttendanceModel> attendances, string inStatus)
        {
            var query = attendances
                .Where(inStat => inStat.InStatus.ToLower() == inStatus.ToLower())
                .Select(inStat => new AttendanceModel
                {
                    Employee = new Employee
                    {
                        EmployeeID = inStat.Employee.EmployeeID,
                        FirstName = inStat.Employee.FirstName,
                        MiddleName = inStat.Employee.MiddleName,
                        LastName = inStat.Employee.LastName,
                        ContactNumber = inStat.Employee.ContactNumber,
                        EmailAddress = inStat.Employee.EmailAddress,
                        HomeAddress = inStat.Employee.HomeAddress,
                        EmploymentStatus = inStat.Employee.EmploymentStatus,
                        Department = new Department
                        {
                            DepartmentID = inStat.Employee.Department.DepartmentID,
                            Name = inStat.Employee.Department.Name,
                            WorkedHours_In = inStat.Employee.Department.WorkedHours_In,
                            WorkedHours_Out = inStat.Employee.Department.WorkedHours_Out,
                        }
                    },
                    AttendanceID = inStat.AttendanceID,
                    TransactionDate = inStat.TransactionDate,
                    EmpTimeIn = inStat.EmpTimeIn,
                    EmpTimeOut = inStat.EmpTimeOut,
                    InStatus = inStat.InStatus,
                    WholeDayAttendanceStatus = inStat.WholeDayAttendanceStatus,
                    WorkedHours = inStat.WorkedHours
                });

            var filteredList = query.ToList();

            return query;
        }

        public AttendanceModel GetAttendanceByEmployeeAndDate(Employee empID, DateTime date)
        {
            AttendanceModel attendanceModel = new AttendanceModel();
            string spName = "SPAttendanceGetByEmployeeAndDate";
            repo = new Repository_ADONET(spName);
            repo.Parameter_Value.Add(("@EmployeeID", empID.EmployeeID, SqlDbType.VarChar));
            repo.Parameter_Value.Add(("@TransactionDate", date.ToShortDateString(), SqlDbType.Date));

            var data = repo.FetchData();

            if (data.Read())
            {
                attendanceModel = new AttendanceModel
                {
                    AttendanceID = int.Parse(data["AttendanceID"].ToString()),
                    Employee = new Employee
                    {
                        EmployeeID = data["EmployeeID"].ToString(),
                        FirstName = data["FirstName"].ToString(),
                        MiddleName = data["MiddleName"].ToString(),
                        LastName = data["LastName"].ToString(),
                        ContactNumber = data["ContactNumber"].ToString(),
                        EmailAddress = data["EmailAddress"].ToString(),
                        HomeAddress = data["HomeAddress"].ToString(),
                        Department = new Department
                        {
                            Name = data["DepartmentName"].ToString(),
                            WorkedHours_In = DateTime.Parse(data["Dept_WorkedHours_In"].ToString()),
                            WorkedHours_Out = DateTime.Parse(data["Dept_WorkedHours_Out"].ToString()),
                        }
                    },
                    EmpTimeIn = DateTime.Parse(data["EmpTimeIn"].ToString()),
                    EmpTimeOut = DateTime.Parse(data["EmpTimeOut"].ToString()),
                    InStatus = data["InStatus"].ToString(),
                    TransactionDate = DateTime.Parse(data["TransactionDate"].ToString()),
                    WholeDayAttendanceStatus = data["WholeDayAttendanceStatus"].ToString(),
                    WorkedHours = TimeSpan.Parse(data["WorkedHours"].ToString())
                };
            }

            return attendanceModel;
        }

    }
}
