using System.Data.SqlClient;

namespace Swimming.ADO.DAL.Repositories.Connection
{
    public class Connection : IConnection
    {
        //private readonly string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog=swimming;Integrated Security=True";
        private readonly string connection = @"Server = tcp:irynaonyshkevych1.database.windows.net,1433;Initial Catalog = swimming; Persist Security Info=False;User ID = login1; Password=Ilikedg38; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";

        //test comment
        public SqlConnection CreateSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            return sqlConnection;
        }
    }
}
