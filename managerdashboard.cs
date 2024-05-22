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
        public string username;
        public void usname(string us)
        {
            username = us;
        }
        public managerdashboard()
        {
            InitializeComponent();
        }

        private void managerdashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_managetask_Click(object sender, EventArgs e)
        {
            popup_managetaskCRUD manCRUD = new popup_managetaskCRUD();
            manCRUD.Show();
        }
    }
}
