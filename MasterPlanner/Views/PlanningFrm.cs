using MasterPlanner.Controllers;
using System;
using System.Windows.Forms;

namespace MasterPlanner.Views
{
    public partial class PlanningFrm : Form
    {
        private readonly PlanningController _planningController = new PlanningController();
        private readonly int _taskId;
        private readonly string _userEmail;

        public PlanningFrm(int taskId, string taskName, string userEmail)
        {
            InitializeComponent();
            _taskId = taskId;
            _userEmail = userEmail;
            taskNameLabel.Text = taskName;
        }

        private void savePlanBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be before the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = _planningController.AddOrUpdatePlan(_taskId, _userEmail, startDate, endDate);

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save the plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}