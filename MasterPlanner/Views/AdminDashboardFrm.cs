using MasterPlanner.Controllers;
using System;
using System.Windows.Forms;

namespace MasterPlanner.Views
{
    public partial class AdminDashboardFrm : Form
    {
        private readonly UserController _userController = new UserController();
        private readonly TaskController _taskController = new TaskController();

        public AdminDashboardFrm()
        {
            InitializeComponent();
        }

        private void AdminDashboardFrm_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
            LoadAllTasks();
        }

        private void LoadAllUsers()
        {
            userView.DataSource = _userController.GetAllUsers();
        }

        private void LoadAllTasks()
        {
            allTasksView.DataSource = _taskController.GetAllTasks();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            using (ReportsFrm reportsForm = new ReportsFrm())
            {
                reportsForm.ShowDialog();
            }
        }
    }
}