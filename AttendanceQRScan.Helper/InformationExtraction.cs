using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceQRScan.Helper
{
    public class InformationExtraction
    {
        public string GenerateInitialsByFullName(string firstName, string middleName, string lastName)
        {
            string f_initial = firstName.Substring(0, 1);
            string m_initial = middleName.Substring(0, 1);
            string l_initial = lastName.Substring(0, 1);

            return $"{f_initial.ToUpper()}{m_initial.ToUpper()}{l_initial.ToUpper()}";
        }
    }
}
