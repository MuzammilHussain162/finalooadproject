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
    public partial class loginemployee : Form
    {
        public loginemployee()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            loginform lgf = new loginform();
            lgf.Show();
            //loginemployee lgemp = new loginemployee();
            //lgemp.Hide();

        }

        private void lbl_forgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword frgpass = new forgetpassword();
            frgpass.Show();
        }
    }
}
