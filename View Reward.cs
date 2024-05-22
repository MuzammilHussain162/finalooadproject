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
    public partial class View_Reward : Form
    {
        public View_Reward()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard_Employee dash_emp = new Dashboard_Employee();
            dash_emp.Show();
        }
    }
}
