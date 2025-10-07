using MasterPlanner.Controllers;
using System;
using System.Windows.Forms;

namespace MasterPlanner.Views
{
    public partial class LoginFrm : Form
    {
        private readonly UserController _userController = new UserController();

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passwordBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userRole = _userController.Login(email, password);

            if (userRole != null)
            {
                this.Hide();
                if (userRole == "Admin")
                {
                    AdminDashboardFrm adminDashboard = new AdminDashboardFrm();
                    adminDashboard.Show();
                }
                else
                {
                    UserDashboardFrm userDashboard = new UserDashboardFrm(email);
                    userDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterFrm registerForm = new RegisterFrm();
            registerForm.Show();
        }
    }
}