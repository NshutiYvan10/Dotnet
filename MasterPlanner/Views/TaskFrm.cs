using MasterPlanner.Controllers;
using System;
using System.Windows.Forms;

namespace MasterPlanner.Views
{
    public partial class TaskFrm : Form
    {
        private readonly TaskController _taskController = new TaskController();
        private readonly int? _taskId;

        public TaskFrm()
        {
            InitializeComponent();
            _taskId = null;
            this.Text = "Add New Task";
            label1.Text = "Add New Task";
            PopulateComboBoxes();
        }

        public TaskFrm(int taskId, string taskName, string status, string category, string priority)
        {
            InitializeComponent();
            _taskId = taskId;
            this.Text = "Edit Task";
            label1.Text = "Edit Task";

            taskNameBox.Text = taskName;
            PopulateComboBoxes();
            statusComboBox.SelectedItem = status;
            categoryComboBox.SelectedItem = category;
            priorityComboBox.SelectedItem = priority;
        }

        private void PopulateComboBoxes()
        {
            statusComboBox.Items.AddRange(new object[] { "Not Started", "In Progress", "Completed", "Missed" });
            statusComboBox.SelectedIndex = 0;
            categoryComboBox.Items.AddRange(new object[] { "Work", "Personal", "Study", "Health" });
            categoryComboBox.SelectedIndex = 0;
            priorityComboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priorityComboBox.SelectedIndex = 1;
        }

        private void saveTaskBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(taskNameBox.Text))
            {
                MessageBox.Show("Task name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string taskName = taskNameBox.Text;
            string status = statusComboBox.SelectedItem.ToString();
            string category = categoryComboBox.SelectedItem.ToString();
            string priority = priorityComboBox.SelectedItem.ToString();
            bool success;

            if (_taskId.HasValue)
            {
                success = _taskController.UpdateTask(_taskId.Value, taskName, status, category, priority);
            }
            else
            {
                success = _taskController.AddTask(taskName, status, category, priority);
            }

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save the task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}