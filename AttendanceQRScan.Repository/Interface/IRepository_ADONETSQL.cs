using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AttendanceQRScan.Repository.Interface
{
    public interface IRepository_ADONETSQL : IRepository
    {
        List<(string, string, SqlDbType)> Parameter_Value { get; set; }
        SqlDataReader FetchData();
    }
}
