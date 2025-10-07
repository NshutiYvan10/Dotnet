
//using MasterPlanner.Controllers;
//using System;
//using System.Data;
//using System.Windows.Forms;

//namespace MasterPlanner.Views
//{
//    public partial class UserDashboardFrm : Form
//    {
//        private readonly TaskController _taskController = new TaskController();
//        private readonly PlanningController _planningController = new PlanningController();
//        private readonly string _currentUserEmail;
//        private bool isLoggingOut = false; // Flag to handle logout properly

//        public UserDashboardFrm(string userEmail)
//        {
//            InitializeComponent();
//            _currentUserEmail = userEmail;
//            this.Text = $"Dashboard - Welcome, {_currentUserEmail}";
//            this.FormClosing += UserDashboardFrm_FormClosing; // Manually add the event handler
//        }

//        private void UserDashboardFrm_Load(object sender, EventArgs e)
//        {
//            LoadTasksWithPlanning();
//        }

//        private void LoadTasksWithPlanning()
//        {
//            taskView.DataSource = _planningController.GetTasksWithPlanning();
//            searchBox.Clear();
//        }

//        // ... (addTaskBtn_Click, editTaskBtn_Click, deleteTaskBtn_Click, planTaskBtn_Click remain the same)

//        private void searchBtn_Click(object sender, EventArgs e)
//        {
//            string searchTerm = searchBox.Text.Trim();
//            if (string.IsNullOrEmpty(searchTerm))
//            {
//                LoadTasksWithPlanning();
//            }
//            else
//            {
//                taskView.DataSource = _taskController.SearchTasks(searchTerm);
//            }
//        }

//        private void logoutBtn_Click(object sender, EventArgs e)
//        {
//            isLoggingOut = true; // Set the flag
//            this.Close(); // Close this form
//        }

//        // This event handler is the key to fixing the crash
//        private void UserDashboardFrm_FormClosing(object sender, FormClosingEventArgs e)
//        {
//            if (isLoggingOut)
//            {
//                // If we are logging out, just open the login form
//                LoginFrm loginForm = new LoginFrm();
//                loginForm.Show();
//            }
//            else
//            {
//                // If the user clicks the 'X' button, exit the entire application
//                Application.Exit();
//            }
//        }

//        // PASTE THE EXISTING EVENT HANDLERS FOR THE OTHER BUTTONS HERE
//        // (addTaskBtn_Click, editTaskBtn_Click, deleteTaskBtn_Click, planTaskBtn_Click)

//        private void addTaskBtn_Click(object sender, EventArgs e)
//        {
//            using (TaskFrm taskForm = new TaskFrm())
//            {
//                if (taskForm.ShowDialog() == DialogResult.OK)
//                {
//                    LoadTasksWithPlanning();
//                }
//            }
//        }

//        private void editTaskBtn_Click(object sender, EventArgs e)
//        {
//            if (taskView.SelectedRows.Count > 0)
//            {
//                DataGridViewRow selectedRow = taskView.SelectedRows[0];
//                int taskId = Convert.ToInt32(selectedRow.Cells["taskId"].Value);
//                string taskName = selectedRow.Cells["taskName"].Value.ToString();
//                string status = selectedRow.Cells["status"].Value.ToString();
//                string category = selectedRow.Cells["category"].Value.ToString();
//                string priority = selectedRow.Cells["priority"].Value.ToString();

//                using (TaskFrm taskForm = new TaskFrm(taskId, taskName, status, category, priority))
//                {
//                    if (taskForm.ShowDialog() == DialogResult.OK)
//                    {
//                        LoadTasksWithPlanning();
//                    }
//                }
//            }
//            else
//            {
//                MessageBox.Show("Please select a task to edit.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//        }

//        private void deleteTaskBtn_Click(object sender, EventArgs e)
//        {
//            if (taskView.SelectedRows.Count > 0)
//            {
//                int taskId = Convert.ToInt32(taskView.SelectedRows[0].Cells["taskId"].Value);
//                var confirmResult = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

//                if (confirmResult == DialogResult.Yes)
//                {
//                    if (_taskController.DeleteTask(taskId))
//                    {
//                        LoadTasksWithPlanning();
//                    }
//                    else
//                    {
//                        MessageBox.Show("Failed to delete the task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//            }
//            else
//            {
//                MessageBox.Show("Please select a task to delete.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//        }

//        private void planTaskBtn_Click(object sender, EventArgs e)
//        {
//            if (taskView.SelectedRows.Count > 0)
//            {
//                int taskId = Convert.ToInt32(taskView.SelectedRows[0].Cells["taskId"].Value);
//                string taskName = taskView.SelectedRows[0].Cells["taskName"].Value.ToString();

//                using (PlanningFrm planningForm = new PlanningFrm(taskId, taskName, _currentUserEmail))
//                {
//                    if (planningForm.ShowDialog() == DialogResult.OK)
//                    {
//                        LoadTasksWithPlanning();
//                    }
//                }
//            }
//            else
//            {
//                MessageBox.Show("Please select a task to plan.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            }
//        }
//    }
//}












using MasterPlanner.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace MasterPlanner.Views
{
    public partial class UserDashboardFrm : Form
    {
        private readonly TaskController _taskController = new TaskController();
        private readonly PlanningController _planningController = new PlanningController();
        private readonly string _currentUserEmail;
        private bool isLoggingOut = false;

        public UserDashboardFrm(string userEmail)
        {
            InitializeComponent();
            _currentUserEmail = userEmail;
            this.Text = $"Dashboard - Welcome, {_currentUserEmail}";
            this.FormClosing += UserDashboardFrm_FormClosing;
        }

        private void UserDashboardFrm_Load(object sender, EventArgs e)
        {
            LoadTasksWithPlanning();
        }

        private void LoadTasksWithPlanning()
        {
            taskView.DataSource = _planningController.GetTasksWithPlanning();
            searchBox.Clear();
        }

        // This is the new event handler for instant search!
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadTasksWithPlanning();
            }
            else
            {
                taskView.DataSource = _taskController.SearchTasks(searchTerm);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;
            this.Close();
        }

        private void UserDashboardFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggingOut)
            {
                LoginFrm loginForm = new LoginFrm();
                loginForm.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        // --- Other button click events remain the same ---

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            using (TaskFrm taskForm = new TaskFrm())
            {
                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTasksWithPlanning();
                }
            }
        }

        private void editTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = taskView.SelectedRows[0];
                int taskId = Convert.ToInt32(selectedRow.Cells["taskId"].Value);
                string taskName = selectedRow.Cells["taskName"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();
                string category = selectedRow.Cells["category"].Value.ToString();
                string priority = selectedRow.Cells["priority"].Value.ToString();

                using (TaskFrm taskForm = new TaskFrm(taskId, taskName, status, category, priority))
                {
                    if (taskForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTasksWithPlanning();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskView.SelectedRows.Count > 0)
            {
                int taskId = Convert.ToInt32(taskView.SelectedRows[0].Cells["taskId"].Value);
                var confirmResult = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    if (_taskController.DeleteTask(taskId))
                    {
                        LoadTasksWithPlanning();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void planTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskView.SelectedRows.Count > 0)
            {
                int taskId = Convert.ToInt32(taskView.SelectedRows[0].Cells["taskId"].Value);
                string taskName = taskView.SelectedRows[0].Cells["taskName"].Value.ToString();

                using (PlanningFrm planningForm = new PlanningFrm(taskId, taskName, _currentUserEmail))
                {
                    if (planningForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTasksWithPlanning();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to plan.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}