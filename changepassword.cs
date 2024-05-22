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
namespace finalooadproject
{
    public partial class changepassword : Form
    {
        private readonly BLL businessLogic;
        private string username;
        public changepassword(string usname)
        {
            InitializeComponent();
            this.username = usname;
            businessLogic = new BLL();
        }

        private void changepassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           bool sucess= businessLogic.VerifyCurrentPassword(username,txt_currentpassword.Text);
            if (sucess)
            {

                businessLogic.UpdateManagerPassword(username, txt_currentpassword.Text, txt_newpassword.Text);
            }
            else {
                MessageBox.Show("Current Password not match with real password. Try Again XD");
            
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboardmanager dash_man = new Dashboardmanager();
            dash_man.Show();
        }
    }
}
