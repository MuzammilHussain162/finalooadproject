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
//using finalooadproject.Business_Logic_Layer;
namespace finalooadproject
{
    public partial class signupforemployee : Form
    {
        private readonly BLL busiLogic;
        public signupforemployee()
        {
            InitializeComponent();
            busiLogic = new BLL();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            loginform lgf = new loginform();
            lgf.Show();
            //signupforemployee sgu = new signupforemployee();
            //sgu.Hide();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            string username = txt_username.Text;
            string password = txt_password.Text;

            try
            {
                bool success = busiLogic.RegisterWorker(username, password);
                if (success)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard_Employee dash_emp = new Dashboard_Employee();
                    dash_emp.Show();
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
    

        private void signupforemployee_Load(object sender, EventArgs e)
        {

        }
    }
}
