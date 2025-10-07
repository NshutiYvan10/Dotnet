using MasterPlanner.Controllers;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MasterPlanner.Views
{
    public partial class ReportsFrm : Form
    {
        private readonly ReportController _reportController = new ReportController();

        public ReportsFrm()
        {
            InitializeComponent();
        }

        private void ReportsFrm_Load(object sender, EventArgs e)
        {
            LoadStatusChart();
            LoadPriorityChart();
        }

        private void LoadStatusChart()
        {
            DataTable statusData = _reportController.GetTaskStatusDistribution();
            statusChart.Series["StatusSeries"].Points.Clear();
            foreach (DataRow row in statusData.Rows)
            {
                statusChart.Series["StatusSeries"].Points.AddXY(row["status"].ToString(), row["TaskCount"]);
            }
        }

        private void LoadPriorityChart()
        {
            DataTable priorityData = _reportController.GetTaskPriorityDistribution();
            priorityChart.Series["PrioritySeries"].Points.Clear();
            foreach (DataRow row in priorityData.Rows)
            {
                priorityChart.Series["PrioritySeries"].Points.AddXY(row["priority"].ToString(), row["TaskCount"]);
            }
        }
    }
}