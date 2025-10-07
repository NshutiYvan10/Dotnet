using MasterPlanner.DAL;
using System.Data;
using System.Data.SqlClient;

namespace MasterPlanner.Controllers
{
    public class TaskController
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public DataTable GetAllTasks()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Task";
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        public bool AddTask(string taskName, string status, string category, string priority)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Task (taskName, status, category, priority) VALUES (@name, @status, @category, @priority)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", taskName);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@priority", priority);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateTask(int taskId, string taskName, string status, string category, string priority)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Task SET taskName = @name, status = @status, category = @category, priority = @priority WHERE taskId = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.Parameters.AddWithValue("@name", taskName);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@priority", priority);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteTask(int taskId)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Task WHERE taskId = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", taskId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}