using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Business_Logic_Layer;

//using finalooadproject.Business_Logic_Layer;
namespace finalooadproject
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void lbl_projectheading_Click(object sender, EventArgs e)
        {

        }

        private void linklbl_loginasemployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginemployee lgemployee = new loginemployee();
            lgemployee.Show();
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void linkLbl_loginasmanager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginmanager lgmanger = new loginmanager();
            lgmanger.Show();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLbl_signupforemployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupforemployee suemployee = new signupforemployee();
            suemployee.Show();
        }

        private void linklbl_signupasmanager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupformanager sumanager = new signupformanager();
            sumanager.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                BLL bll = new BLL();
                if (combobox_loginas.SelectedItem == null)
                {
                    MessageBox.Show("Please select a user type.");
                    return;
                }

                string userType = combobox_loginas.SelectedItem.ToString();
                string username = txt_username.Text;
                string password = txt_password.Text;

                bool isValid = bll.Login(userType, username, password);
                if (isValid)
                {
                    
                    if (userType == "MANAGER") {

                        Dashboardmanager dash_man = new Dashboardmanager();
                        dash_man.Show();
                        MessageBox.Show("Login successful!");
                    }
                    else{
                        Dashboard_Employee dash_emp = new Dashboard_Employee();
                        dash_emp.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void linklbl_forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string utype= combobox_loginas.SelectedItem.ToString();
            forgetpassword frgot = new forgetpassword();
            frgot.username(utype);
            frgot.Show();
            
        }
    }
}

