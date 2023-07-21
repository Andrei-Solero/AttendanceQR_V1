using System.Data.SqlClient;
using System.Data;
using AttendanceQRScan.Repository.Interface;
using System;
using System.Collections.Generic;

namespace AttendanceQRScan.Repository
{
    public class Repository_ADONET : IRepository_ADONETSQL
    {
        private SqlConnection connection { get; set; }
        public List<(string, string, SqlDbType)> Parameter_Value { get; set; } = new List<(string, string, SqlDbType)>();

        private readonly string spName;

        /// <summary>
        /// This repository is for ADO.NET code that uses sql server and stored procedure
        /// </summary>
        /// <param name="spName">The name of Stored Procedure</param>
        public Repository_ADONET(string spName)
        {
            this.spName = spName;
        }

        public void ModifyData()
        {
            //using (connection = new SqlConnection(ConnectionString.Connection))
            using (connection = new SqlConnection("Server=.;Database=AttendanceQRDB;Trusted_Connection=True;"))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = spName;

                if (Parameter_Value != null)
                {
                    foreach ((string, string, SqlDbType) parameter in Parameter_Value)
                    {
                        command.Parameters.AddWithValue(parameter.Item1, parameter.Item2).SqlDbType = parameter.Item3;
                    }
                }
                
                command.ExecuteNonQuery();
            }

            ResetConnections();
        }

        public SqlDataReader FetchData()
        {
            connection = new SqlConnection("Server=.;Database=AttendanceQRDB;Trusted_Connection=True;");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spName;

            if (Parameter_Value != null)
            {
                foreach ((string, string, SqlDbType) parameter in Parameter_Value)
                {
                    command.Parameters.AddWithValue(parameter.Item1, parameter.Item2).SqlDbType = parameter.Item3;
                }
            }

            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        private void ResetConnections()
        {
            Parameter_Value.Clear();
            connection.Close();
            connection.Dispose();
        }
    }
}
