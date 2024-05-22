using Business_Logic_Layer;
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
using System.Diagnostics.Eventing.Reader;
namespace finalooadproject
{
    public partial class forgetpassword : Form
    {

        public string usertype;

        private readonly BLL businessLogic;
        public void username(string un)
        {
            usertype = un;
        }
        public forgetpassword()
        {
            InitializeComponent();
            businessLogic = new BLL();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            loginform lgf = new loginform();
            lgf.Show();

        }

        private void forgetpassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_DONE_Click(object sender, EventArgs e)
        {

            string tableName = usertype;
            string username =txt_username.Text;
            string newPassword = txt_newpassword.Text;
            string confirmPassword = txt_confirmpassword.Text;

            try
            {
                
                    bool success = businessLogic.UpdatePassword(tableName, username, newPassword, confirmPassword);
                    if (success)
                    {
                        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not available or incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
