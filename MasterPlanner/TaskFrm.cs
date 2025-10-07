using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPlanner
{
    public partial class TaskFrm : Form
    {
        public TaskFrm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=MasterPlannerDB;Integrated Security=True;TrustServerCertificate=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
                
            }


            string query = "INSERT INTO Task VALUES(@taskName, @sts)";
      
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@taskName", "Study Dotnet");
            cmd.Parameters.AddWithValue("@sts", "In progress");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void TaskFrm_Load(object sender, EventArgs e)
        {
            DisplayData();

        }

        private void DisplayData()
        {
            conn.Open();
            string query = "SELECT * FROM Task";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Task");
            taskView.DataSource = ds.Tables["Task"];
            conn.Close();
        }
    }
}
