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
using finalooadproject.Business_Logic_Layer;
namespace finalooadproject
{
    public partial class signupformanager : Form
    {
        private readonly BLL businessLogic;
        public signupformanager()
        {
            InitializeComponent();
            businessLogic = new BLL();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            loginform lgf = new loginform();
            lgf.Show();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            try
            {
                bool success = businessLogic.RegisterManager(username, password);
                if (success)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupformanager_Load(object sender, EventArgs e)
        {

        }
    }
}
