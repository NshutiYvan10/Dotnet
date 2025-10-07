using MasterPlanner.Controllers;
using System;
using System.Windows.Forms;

namespace MasterPlanner.Views
{
    public partial class RegisterFrm : Form
    {
        private readonly UserController _userController = new UserController();

        public RegisterFrm()
        {
            InitializeComponent();
            roleComboBox.Items.Add("User");
            roleComboBox.Items.Add("Admin");
            roleComboBox.SelectedIndex = 0;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordBox.Text != confirmPasswordBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSuccess = _userController.RegisterUser(emailBox.Text, passwordBox.Text, roleComboBox.SelectedItem.ToString());

            if (isSuccess)
            {
                MessageBox.Show("Registration successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginFrm loginForm = new LoginFrm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Registration failed. This email may already be in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginFrm loginForm = new LoginFrm();
            loginForm.Show();
        }
    }
}