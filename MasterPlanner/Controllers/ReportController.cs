using MasterPlanner.DAL;
using System.Data;
using System.Data.SqlClient;

namespace MasterPlanner.Controllers
{
    public class ReportController
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public DataTable GetTaskStatusDistribution()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT status, COUNT(*) as TaskCount FROM Task GROUP BY status";
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetTaskPriorityDistribution()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT priority, COUNT(*) as TaskCount FROM Task GROUP BY priority";
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }
    }
}