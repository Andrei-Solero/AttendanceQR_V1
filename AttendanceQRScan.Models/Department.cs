using System;

namespace AttendanceQRScan.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public DateTime WorkedHours_In { get; set; }
        public DateTime WorkedHours_Out { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
