using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalooadproject
{
    public partial class loginmanager : Form
    {
        public loginmanager()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            loginform lgform = new loginform();
            lgform.Show();
        }

        private void loginmanager_Load(object sender, EventArgs e)
        {

        }

        private void lbl_forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword frgpass = new forgetpassword();
            frgpass.Show();
        }

        private void lbl_forgotpassword_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword frgpass = new forgetpassword();
            frgpass.Show();
        }
    }
}
