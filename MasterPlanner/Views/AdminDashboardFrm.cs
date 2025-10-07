//using MasterPlanner.Controllers;
//using System;
//using System.Windows.Forms;

//namespace MasterPlanner.Views
//{
//    public partial class AdminDashboardFrm : Form
//    {
//        private readonly UserController _userController = new UserController();
//        private readonly TaskController _taskController = new TaskController();

//        public AdminDashboardFrm()
//        {
//            InitializeComponent();
//        }

//        private void AdminDashboardFrm_Load(object sender, EventArgs e)
//        {
//            LoadAllUsers();
//            LoadAllTasks();
//        }

//        private void LoadAllUsers()
//        {
//            userView.DataSource = _userController.GetAllUsers();
//        }

//        private void LoadAllTasks()
//        {
//            allTasksView.DataSource = _taskController.GetAllTasks();
//        }

//        private void reportsBtn_Click(object sender, EventArgs e)
//        {
//            using (ReportsFrm reportsForm = new ReportsFrm())
//            {
//                reportsForm.ShowDialog();
//            }
//        }
//    }
//}








using MasterPlanner.Controllers;
using System;
using System.Windows.Forms;

namespace MasterPlanner.Views
{
    public partial class AdminDashboardFrm : Form
    {
        private readonly UserController _userController = new UserController();
        private readonly TaskController _taskController = new TaskController();
        private bool isLoggingOut = false; // Flag to handle logout properly

        public AdminDashboardFrm()
        {
            InitializeComponent();
            this.FormClosing += AdminDashboardFrm_FormClosing; // Manually add the event handler
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            isLoggingOut = true; // Set the flag
            this.Close(); // Close this form
        }

        // This event handler is the key to fixing the crash
        private void AdminDashboardFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggingOut)
            {
                // If we are logging out, just open the login form
                LoginFrm loginForm = new LoginFrm();
                loginForm.Show();
            }
            else
            {
                // If the user clicks the 'X' button, exit the entire application
                Application.Exit();
            }
        }
    }
}