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

namespace finalooadproject
{
    public partial class manage_workers : Form
    {
        private readonly BLL businessLogic;
        public manage_workers()
        {
            InitializeComponent();
            LoadWorkers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerdashboard mngdash = new managerdashboard();
            mngdash.Show();
        }
        private void LoadWorkers()
        {
            DataTable workers = businessLogic.GetWorkers();
            dataGridView_viewallworkers.DataSource = workers;
            dataGridView1.DataSource = workers;
        }

        private void dataGridView_viewallworkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadWorkers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
