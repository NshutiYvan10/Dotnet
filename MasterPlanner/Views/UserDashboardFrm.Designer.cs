namespace MasterPlanner.Views
{
    partial class UserDashboardFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.planTaskBtn = new System.Windows.Forms.Button();
            this.deleteTaskBtn = new System.Windows.Forms.Button();
            this.editTaskBtn = new System.Windows.Forms.Button();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.planTaskBtn);
            this.panel1.Controls.Add(this.deleteTaskBtn);
            this.panel1.Controls.Add(this.editTaskBtn);
            this.panel1.Controls.Add(this.addTaskBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 80);
            this.panel1.TabIndex = 0;
            // 
            // planTaskBtn
            // 
            this.planTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.planTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.planTaskBtn.FlatAppearance.BorderSize = 0;
            this.planTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.planTaskBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planTaskBtn.ForeColor = System.Drawing.Color.White;
            this.planTaskBtn.Location = new System.Drawing.Point(479, 25);
            this.planTaskBtn.Name = "planTaskBtn";
            this.planTaskBtn.Size = new System.Drawing.Size(115, 35);
            this.planTaskBtn.TabIndex = 4;
            this.planTaskBtn.Text = "Plan Task";
            this.planTaskBtn.UseVisualStyleBackColor = false;
            this.planTaskBtn.Click += new System.EventHandler(this.planTaskBtn_Click);
            // 
            // deleteTaskBtn
            // 
            this.deleteTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(2)))), ((int)(((byte)(27)))));
            this.deleteTaskBtn.FlatAppearance.BorderSize = 0;
            this.deleteTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTaskBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTaskBtn.ForeColor = System.Drawing.Color.White;
            this.deleteTaskBtn.Location = new System.Drawing.Point(600, 25);
            this.deleteTaskBtn.Name = "deleteTaskBtn";
            this.deleteTaskBtn.Size = new System.Drawing.Size(115, 35);
            this.deleteTaskBtn.TabIndex = 3;
            this.deleteTaskBtn.Text = "Delete Task";
            this.deleteTaskBtn.UseVisualStyleBackColor = false;
            this.deleteTaskBtn.Click += new System.EventHandler(this.deleteTaskBtn_Click);
            // 
            // editTaskBtn
            // 
            this.editTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.editTaskBtn.FlatAppearance.BorderSize = 0;
            this.editTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTaskBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTaskBtn.ForeColor = System.Drawing.Color.White;
            this.editTaskBtn.Location = new System.Drawing.Point(721, 25);
            this.editTaskBtn.Name = "editTaskBtn";
            this.editTaskBtn.Size = new System.Drawing.Size(115, 35);
            this.editTaskBtn.TabIndex = 2;
            this.editTaskBtn.Text = "Edit Task";
            this.editTaskBtn.UseVisualStyleBackColor = false;
            this.editTaskBtn.Click += new System.EventHandler(this.editTaskBtn_Click);
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.addTaskBtn.FlatAppearance.BorderSize = 0;
            this.addTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskBtn.ForeColor = System.Drawing.Color.White;
            this.addTaskBtn.Location = new System.Drawing.Point(842, 25);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(115, 35);
            this.addTaskBtn.TabIndex = 1;
            this.addTaskBtn.Text = "+ Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = false;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Tasks";
            // 
            // taskView
            // 
            this.taskView.AllowUserToAddRows = false;
            this.taskView.AllowUserToDeleteRows = false;
            this.taskView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskView.BackgroundColor = System.Drawing.Color.White;
            this.taskView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.taskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.taskView.DefaultCellStyle = dataGridViewCellStyle2;
            this.taskView.EnableHeadersVisualStyles = false;
            this.taskView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.taskView.Location = new System.Drawing.Point(27, 95);
            this.taskView.MultiSelect = false;
            this.taskView.Name = "taskView";
            this.taskView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.taskView.RowHeadersVisible = false;
            this.taskView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskView.Size = new System.Drawing.Size(930, 425);
            this.taskView.TabIndex = 1;
            // 
            // UserDashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.taskView);
            this.Controls.Add(this.panel1);
            this.Name = "UserDashboardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.UserDashboardFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView taskView;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Button deleteTaskBtn;
        private System.Windows.Forms.Button editTaskBtn;
        private System.Windows.Forms.Button planTaskBtn;
    }
}