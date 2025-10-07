namespace MasterPlanner.Views
{
    partial class PlanningFrm
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
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.savePlanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskNameLabel.Location = new System.Drawing.Point(25, 25);
            this.taskNameLabel.MaximumSize = new System.Drawing.Size(340, 0);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(193, 37);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Schedule Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startDatePicker.Location = new System.Drawing.Point(32, 115);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(320, 29);
            this.startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.endDatePicker.Location = new System.Drawing.Point(32, 185);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(320, 29);
            this.endDatePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(28, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // savePlanBtn
            // 
            this.savePlanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.savePlanBtn.FlatAppearance.BorderSize = 0;
            this.savePlanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePlanBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePlanBtn.ForeColor = System.Drawing.Color.White;
            this.savePlanBtn.Location = new System.Drawing.Point(132, 240);
            this.savePlanBtn.Name = "savePlanBtn";
            this.savePlanBtn.Size = new System.Drawing.Size(120, 40);
            this.savePlanBtn.TabIndex = 5;
            this.savePlanBtn.Text = "Save Plan";
            this.savePlanBtn.UseVisualStyleBackColor = false;
            this.savePlanBtn.Click += new System.EventHandler(this.savePlanBtn_Click);
            // 
            // PlanningFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.savePlanBtn);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlanningFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Task";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savePlanBtn;
    }
}