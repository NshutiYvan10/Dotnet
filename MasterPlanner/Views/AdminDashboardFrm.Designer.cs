//namespace MasterPlanner.Views
//{
//    partial class AdminDashboardFrm
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.reportsBtn = new System.Windows.Forms.Button();
//            this.label1 = new System.Windows.Forms.Label();
//            this.tabControl1 = new System.Windows.Forms.TabControl();
//            this.tabPage1 = new System.Windows.Forms.TabPage();
//            this.userView = new System.Windows.Forms.DataGridView();
//            this.tabPage2 = new System.Windows.Forms.TabPage();
//            this.allTasksView = new System.Windows.Forms.DataGridView();
//            this.panel1.SuspendLayout();
//            this.tabControl1.SuspendLayout();
//            this.tabPage1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.userView)).BeginInit();
//            this.tabPage2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.allTasksView)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.Color.White;
//            this.panel1.Controls.Add(this.reportsBtn);
//            this.panel1.Controls.Add(this.label1);
//            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panel1.Location = new System.Drawing.Point(0, 0);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(984, 80);
//            this.panel1.TabIndex = 1;
//            // 
//            // reportsBtn
//            // 
//            this.reportsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.reportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
//            this.reportsBtn.FlatAppearance.BorderSize = 0;
//            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.reportsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.reportsBtn.ForeColor = System.Drawing.Color.White;
//            this.reportsBtn.Location = new System.Drawing.Point(822, 25);
//            this.reportsBtn.Name = "reportsBtn";
//            this.reportsBtn.Size = new System.Drawing.Size(135, 35);
//            this.reportsBtn.TabIndex = 1;
//            this.reportsBtn.Text = "View Reports";
//            this.reportsBtn.UseVisualStyleBackColor = false;
//            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            this.label1.Location = new System.Drawing.Point(20, 20);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(273, 40);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Admin Dashboard";
//            // 
//            // tabControl1
//            // 
//            this.tabControl1.Controls.Add(this.tabPage1);
//            this.tabControl1.Controls.Add(this.tabPage2);
//            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.tabControl1.Location = new System.Drawing.Point(0, 80);
//            this.tabControl1.Name = "tabControl1";
//            this.tabControl1.SelectedIndex = 0;
//            this.tabControl1.Size = new System.Drawing.Size(984, 481);
//            this.tabControl1.TabIndex = 2;
//            // 
//            // tabPage1
//            // 
//            this.tabPage1.Controls.Add(this.userView);
//            this.tabPage1.Location = new System.Drawing.Point(4, 26);
//            this.tabPage1.Name = "tabPage1";
//            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
//            this.tabPage1.Size = new System.Drawing.Size(976, 451);
//            this.tabPage1.TabIndex = 0;
//            this.tabPage1.Text = "User Management";
//            this.tabPage1.UseVisualStyleBackColor = true;
//            // 
//            // userView
//            // 
//            this.userView.AllowUserToAddRows = false;
//            this.userView.AllowUserToDeleteRows = false;
//            this.userView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.userView.BackgroundColor = System.Drawing.Color.White;
//            this.userView.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.userView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
//            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
//            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
//            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.userView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            this.userView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
//            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
//            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.userView.DefaultCellStyle = dataGridViewCellStyle2;
//            this.userView.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.userView.EnableHeadersVisualStyles = false;
//            this.userView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
//            this.userView.Location = new System.Drawing.Point(10, 10);
//            this.userView.Name = "userView";
//            this.userView.ReadOnly = true;
//            this.userView.RowHeadersVisible = false;
//            this.userView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.userView.Size = new System.Drawing.Size(956, 431);
//            this.userView.TabIndex = 0;
//            // 
//            // tabPage2
//            // 
//            this.tabPage2.Controls.Add(this.allTasksView);
//            this.tabPage2.Location = new System.Drawing.Point(4, 26);
//            this.tabPage2.Name = "tabPage2";
//            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
//            this.tabPage2.Size = new System.Drawing.Size(976, 451);
//            this.tabPage2.TabIndex = 1;
//            this.tabPage2.Text = "All System Tasks";
//            this.tabPage2.UseVisualStyleBackColor = true;
//            // 
//            // allTasksView
//            // 
//            this.allTasksView.AllowUserToAddRows = false;
//            this.allTasksView.AllowUserToDeleteRows = false;
//            this.allTasksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.allTasksView.BackgroundColor = System.Drawing.Color.White;
//            this.allTasksView.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.allTasksView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
//            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
//            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
//            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
//            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.allTasksView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
//            this.allTasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
//            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
//            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.allTasksView.DefaultCellStyle = dataGridViewCellStyle4;
//            this.allTasksView.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.allTasksView.EnableHeadersVisualStyles = false;
//            this.allTasksView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
//            this.allTasksView.Location = new System.Drawing.Point(10, 10);
//            this.allTasksView.Name = "allTasksView";
//            this.allTasksView.ReadOnly = true;
//            this.allTasksView.RowHeadersVisible = false;
//            this.allTasksView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.allTasksView.Size = new System.Drawing.Size(956, 431);
//            this.allTasksView.TabIndex = 1;
//            // 
//            // AdminDashboardFrm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
//            this.ClientSize = new System.Drawing.Size(984, 561);
//            this.Controls.Add(this.tabControl1);
//            this.Controls.Add(this.panel1);
//            this.Name = "AdminDashboardFrm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Admin Dashboard";
//            this.Load += new System.EventHandler(this.AdminDashboardFrm_Load);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            this.tabControl1.ResumeLayout(false);
//            this.tabPage1.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.userView)).EndInit();
//            this.tabPage2.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.allTasksView)).EndInit();
//            this.ResumeLayout(false);
//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Button reportsBtn;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TabControl tabControl1;
//        private System.Windows.Forms.TabPage tabPage1;
//        private System.Windows.Forms.TabPage tabPage2;
//        private System.Windows.Forms.DataGridView userView;
//        private System.Windows.Forms.DataGridView allTasksView;
//    }
//}












namespace MasterPlanner.Views
{
    partial class AdminDashboardFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.allTasksView = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allTasksView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.reportsBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 80);
            this.panel1.TabIndex = 1;
            // 
            // reportsBtn
            // 
            this.reportsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.White;
            this.reportsBtn.Location = new System.Drawing.Point(837, 25);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(135, 35);
            this.reportsBtn.TabIndex = 1;
            this.reportsBtn.Text = "View Reports";
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 440);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logoutBtn);
            this.tabPage1.Controls.Add(this.userView);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(976, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userView
            // 
            this.userView.AllowUserToAddRows = false;
            this.userView.AllowUserToDeleteRows = false;
            this.userView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userView.BackgroundColor = System.Drawing.Color.White;
            this.userView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userView.DefaultCellStyle = dataGridViewCellStyle1;
            this.userView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userView.EnableHeadersVisualStyles = false;
            this.userView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userView.Location = new System.Drawing.Point(10, 10);
            this.userView.Name = "userView";
            this.userView.ReadOnly = true;
            this.userView.RowHeadersVisible = false;
            this.userView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userView.Size = new System.Drawing.Size(956, 390);
            this.userView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.allTasksView);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(976, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All System Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // allTasksView
            // 
            this.allTasksView.AllowUserToAddRows = false;
            this.allTasksView.AllowUserToDeleteRows = false;
            this.allTasksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allTasksView.BackgroundColor = System.Drawing.Color.White;
            this.allTasksView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allTasksView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.allTasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allTasksView.DefaultCellStyle = dataGridViewCellStyle2;
            this.allTasksView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTasksView.EnableHeadersVisualStyles = false;
            this.allTasksView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.allTasksView.Location = new System.Drawing.Point(10, 10);
            this.allTasksView.Name = "allTasksView";
            this.allTasksView.ReadOnly = true;
            this.allTasksView.RowHeadersVisible = false;
            this.allTasksView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allTasksView.Size = new System.Drawing.Size(956, 390);
            this.allTasksView.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.BackColor = System.Drawing.Color.DimGray;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(891, 375);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(85, 35);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AdminDashboardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboardFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allTasksView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView userView;
        private System.Windows.Forms.DataGridView allTasksView;
        private System.Windows.Forms.Button logoutBtn;
    }
}