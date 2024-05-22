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
    public partial class popup_managetaskCRUD : Form
    {
        private readonly BLL businessLogic;
        public popup_managetaskCRUD()
        {
            InitializeComponent();
            businessLogic = new BLL();
            LoadTasks();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_createtask_Click(object sender, EventArgs e)
        {
            int taskId = int.Parse(txt_taskid.Text);
            string taskDescription = txt_taskdescription.Text;
            string taskDetails = txt_extradetails.Text;
            decimal dollarReward = decimal.Parse(txt_reward.Text);

            try
            {
                bool success = businessLogic.CreateTask(taskId, taskDescription, taskDetails, dollarReward);
                if (success)
                {
                    MessageBox.Show("Task created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int taskId = int.Parse(txt_task_Edit_id.Text);
            string newTaskDescription = txt_edit_description.Text;

            try
            {
                bool success = businessLogic.UpdateTaskDescription(taskId, newTaskDescription);
                if (success)
                {
                    MessageBox.Show("Task description updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update task description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTasks()
        {
            DataTable tasks = businessLogic.GetTasks();
            datagridview_deletetask.DataSource = tasks;
        }

        private void txt_task_Edit_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_deletetask_Click(object sender, EventArgs e)
        {
            int taskId = int.Parse(txt_taskiddelete.Text);

            try
            {
                bool success = businessLogic.DeleteTask(taskId);
                if (success)
                {
                    MessageBox.Show("Task deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Failed to delete task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_taskiddelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_viewalltasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadTasks();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            managerdashboard mngrdash = new managerdashboard();
            mngrdash.Show();
        }

        private void lbl_dollarrewards_Click(object sender, EventArgs e)
        {

        }
    }
}
