namespace MasterPlanner.Views
{
    partial class ReportsFrm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.statusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.priorityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.statusChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // statusChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statusChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statusChart.Legends.Add(legend1);
            this.statusChart.Location = new System.Drawing.Point(30, 30);
            this.statusChart.Name = "statusChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "StatusSeries";
            this.statusChart.Series.Add(series1);
            this.statusChart.Size = new System.Drawing.Size(400, 400);
            this.statusChart.TabIndex = 0;
            this.statusChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Tasks by Status";
            this.statusChart.Titles.Add(title1);
            // 
            // priorityChart
            // 
            chartArea2.Name = "ChartArea1";
            this.priorityChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.priorityChart.Legends.Add(legend2);
            this.priorityChart.Location = new System.Drawing.Point(450, 30);
            this.priorityChart.Name = "priorityChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "PrioritySeries";
            this.priorityChart.Series.Add(series2);
            this.priorityChart.Size = new System.Drawing.Size(400, 400);
            this.priorityChart.TabIndex = 1;
            this.priorityChart.Text = "chart2";
            title2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Tasks by Priority";
            this.priorityChart.Titles.Add(title2);
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.priorityChart);
            this.Controls.Add(this.statusChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Reports";
            this.Load += new System.EventHandler(this.ReportsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart statusChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart priorityChart;
    }
}