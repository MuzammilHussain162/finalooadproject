using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;
using finalooadproject;

namespace expensetracker1._1
{
    public partial class dbconnector : Form
    {
        private readonly BLL businessLogic;

        public dbconnector()
        {
            InitializeComponent();
            businessLogic = new BLL();
        }

        private void localbtn_Click(object sender, EventArgs e)
        {
            string serverIP = serveriptxtb.Text;
            string serverName = servernametxtb.Text;
            string username = usernametxtb.Text;
            string password = passwordtxtb.Text;

            try
            {
                // Attempt to connect to the local database using BLL method
                businessLogic.LocalConnection(serverIP, serverName, username, password);

                // Save connection settings
                businessLogic.SaveConnectionSettings(serverIP, serverName, username, password);

                // Display connection result message
                MessageBox.Show("Local database connection established successfully.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to the LoginPage form upon successful connection
                loginform loginPage = new loginform();
                loginPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to local database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void remotetbtn_Click(object sender, EventArgs e)
        {
            string serverIP = serveriptxtb.Text;
            string serverName = servernametxtb.Text;
            string username = usernametxtb.Text;
            string password = passwordtxtb.Text;

            try
            {
                // Attempt to connect to the remote database using BLL method
                businessLogic.RemoteConnection(serverIP, serverName, username, password);

                // Save connection settings
                businessLogic.SaveConnectionSettings(serverIP, serverName, username, password);

                // Display connection result message
                MessageBox.Show("Remote database connection established successfully.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to the LoginPage form upon successful connection
                loginform loginPage = new loginform();
                loginPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to remote database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dbconnector_Load(object sender, EventArgs e)
        {
            // Load saved connection settings into the form fields
            var settings = businessLogic.LoadConnectionSettings();
            serveriptxtb.Text = settings.Item1;
            servernametxtb.Text = settings.Item2;
            usernametxtb.Text = settings.Item3;
            passwordtxtb.Text = settings.Item4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



