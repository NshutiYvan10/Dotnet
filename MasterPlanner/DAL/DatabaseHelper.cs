using System.Data.SqlClient;

namespace MasterPlanner.DAL
{
    public class DatabaseHelper
    {
        private readonly string _connectionString = @"Data Source=localhost;Initial Catalog=MasterPlannerDB;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}