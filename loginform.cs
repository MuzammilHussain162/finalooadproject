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
    }
}
