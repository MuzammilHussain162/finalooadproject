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
    public partial class changepassword : Form
    {
        private string username;
        public changepassword(string usname)
        {
            InitializeComponent();
            this.username = usname;
        }

        private void changepassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboardmanager dash_man = new Dashboardmanager();
            dash_man.Show();
        }
    }
}
