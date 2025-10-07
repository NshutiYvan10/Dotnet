using MasterPlanner.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MasterPlanner.Controllers
{
    public class PlanningController
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public bool AddOrUpdatePlan(int taskId, string userEmail, DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query;
                int existingPlanCount = 0;

                string checkQuery = "SELECT COUNT(1) FROM Planning WHERE taskId = @taskId";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@taskId", taskId);
                    existingPlanCount = (int)checkCmd.ExecuteScalar();
                }

                if (existingPlanCount > 0)
                {
                    query = "UPDATE Planning SET startDate = @startDate, endDate = @endDate WHERE taskId = @taskId";
                }
                else
                {
                    query = "INSERT INTO Planning (taskId, email, startDate, endDate) VALUES (@taskId, @email, @startDate, @endDate)";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    if (existingPlanCount == 0)
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);
                    }
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable GetTasksWithPlanning()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        t.taskId, t.taskName, t.status, t.category, t.priority, 
                        p.startDate, p.endDate 
                    FROM Task t
                    LEFT JOIN Planning p ON t.taskId = p.taskId";
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }
    }
}