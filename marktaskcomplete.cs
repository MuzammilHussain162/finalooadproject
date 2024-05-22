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
    public partial class marktaskcomplete : Form
    {
        private BLL bll;
        public marktaskcomplete()
        {
            InitializeComponent();
            bll = new BLL();
            LoadTasks();
        }
        private void LoadTasks()
        {
            DataTable tasks = bll.GetAllTasks();
            dataGridViewTasks.DataSource = tasks;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard_Employee dash_emp = new Dashboard_Employee();
            dash_emp.Show();
        }

        private void marktaskcomplete_Load(object sender, EventArgs e)
        {

        }

        private void btn_markcomplete_Click(object sender, EventArgs e)
        {
            string taskId = txt_taskidformarkcomplete.Text;
            if (bll.MarkTaskComplete(taskId))
            {
                MessageBox.Show("Task marked as complete successfully.");
                LoadTasks(); // Refresh the tasks list
            }
            else
            {
                MessageBox.Show("Error marking task as complete.");
            }
        }
    }
}
