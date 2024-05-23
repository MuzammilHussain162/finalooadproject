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
    public partial class managerdashboard : Form
    {
        private string username;

        public managerdashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            txt_username.Text = this.username;
        }

        private void managerdashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_managetask_Click(object sender, EventArgs e)
        {
            popup_managetaskCRUD manCRUD = new popup_managetaskCRUD();
            manCRUD.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            loginform lgf = new loginform();
            lgf.Show();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            changepassword chngpass = new changepassword(username);
            chngpass.Show();
        }

        private void btn_manageworker_Click(object sender, EventArgs e)
        {
            manage_workers mngwork = new manage_workers(txt_username.Text);
            mngwork.Show();
        }
    }
}
