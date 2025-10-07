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

//        public UserDashboardFrm(string userEmail)
//        {
//            InitializeComponent();
//            _currentUserEmail = userEmail;
//            this.Text = $"Dashboard - Welcome, {_currentUserEmail}";
//        }

//        private void UserDashboardFrm_Load(object sender, EventArgs e)
//        {
//            LoadTasksWithPlanning();
//        }

//        private void LoadTasksWithPlanning()
//        {
//            taskView.DataSource = _planningController.GetTasksWithPlanning();
//        }

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

//                using (AdminDashboardFrm planningForm = new PlanningFrm(taskId, taskName, _currentUserEmail))
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

        public UserDashboardFrm(string userEmail)
        {
            InitializeComponent();
            _currentUserEmail = userEmail;
            this.Text = $"Dashboard - Welcome, {_currentUserEmail}";
        }

        private void UserDashboardFrm_Load(object sender, EventArgs e)
        {
            LoadTasksWithPlanning();
        }

        private void LoadTasksWithPlanning()
        {
            taskView.DataSource = _planningController.GetTasksWithPlanning();
        }

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
                var confirmResult = MessageBox.Show("Are you sure you want to delete this task? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

                // The error was here. I have corrected the form type to PlanningFrm.
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