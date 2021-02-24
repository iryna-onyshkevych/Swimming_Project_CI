﻿using System.Data.SqlClient;

namespace Swimming.ADO.DAL.Repositories.Connection
{
    public class Connection : IConnection
    {
        private readonly string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=swimming;Integrated Security=True";

        public SqlConnection CreateSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            return sqlConnection;
        }
    }
}
