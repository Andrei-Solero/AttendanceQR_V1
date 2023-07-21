using System;

namespace AttendanceQRScan.Models
{
    public class AttendanceModel
    {
        public int AttendanceID { get; set; }
        public Employee Employee { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime EmpTimeIn { get; set; }
        public DateTime EmpTimeOut { get; set; }
        public TimeSpan WorkedHours { get; set; }
        public string InStatus{ get; set; }
        public string WholeDayAttendanceStatus { get; set; }
    }
}
