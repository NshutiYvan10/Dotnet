namespace MasterPlanner
{
    partial class RegisterFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(46, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 402);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLink.Location = new System.Drawing.Point(502, 346);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(159, 22);
            this.loginLink.TabIndex = 14;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Click here to login";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Location = new System.Drawing.Point(432, 274);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(322, 20);
            this.confirmPasswordBox.TabIndex = 13;
            this.confirmPasswordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(431, 117);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(322, 20);
            this.emailBox.TabIndex = 12;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(516, 383);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(129, 43);
            this.registerBtn.TabIndex = 11;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirm Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(432, 186);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(322, 20);
            this.passwordBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(432, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(219, 23);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Agree to Terms and Conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterFrm";
            this.Text = "RegisterFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}