using MasterPlanner.DAL;
using System.Data;
using System.Data.SqlClient;

namespace MasterPlanner.Controllers
{
    public class UserController
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public bool RegisterUser(string email, string password, string role)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO [User] (email, password, role) VALUES (@email, @password, @role)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public string Login(string email, string password)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT role FROM [User] WHERE email = @email AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT email, role FROM [User]";
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }
    }
}