namespace AttendanceQRScan.Models
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public Department Department { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string EmploymentStatus { get; set; }

    }
}