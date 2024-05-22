namespace finalooadproject
{
    partial class popup_managetaskCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tab_CRUDtasks = new TabControl();
            tab_createtask = new TabPage();
            txt_taskid = new TextBox();
            lbl_taskid = new Label();
            txt_reward = new TextBox();
            txt_extradetails = new TextBox();
            txt_taskdescription = new TextBox();
            btn_createtask = new Button();
            lbl_dollarrewards = new Label();
            lbl_extradetails = new Label();
            lbl_taskdescription = new Label();
            tab_edittask = new TabPage();
            Update = new Button();
            txt_edit_description = new TextBox();
            txt_task_Edit_id = new TextBox();
            Description = new Label();
            lbl_task_edit_id = new Label();
            tab_deletetask = new TabPage();
            datagridview_deletetask = new DataGridView();
            txt_taskiddelete = new TextBox();
            lbl_entertaskid = new Label();
            btn_deletetask = new Button();
            tab_viewtask = new TabPage();
            lbl_viewalltasks = new Label();
            dataGridView_viewalltasks = new DataGridView();
            lbl_managetaskheading = new Label();
            btn_back = new Button();
            tab_CRUDtasks.SuspendLayout();
            tab_createtask.SuspendLayout();
            tab_edittask.SuspendLayout();
            tab_deletetask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_deletetask).BeginInit();
            tab_viewtask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_viewalltasks).BeginInit();
            SuspendLayout();
            // 
            // tab_CRUDtasks
            // 
            tab_CRUDtasks.Controls.Add(tab_createtask);
            tab_CRUDtasks.Controls.Add(tab_edittask);
            tab_CRUDtasks.Controls.Add(tab_deletetask);
            tab_CRUDtasks.Controls.Add(tab_viewtask);
            tab_CRUDtasks.Location = new Point(54, 58);
            tab_CRUDtasks.Name = "tab_CRUDtasks";
            tab_CRUDtasks.SelectedIndex = 0;
            tab_CRUDtasks.Size = new Size(706, 339);
            tab_CRUDtasks.TabIndex = 0;
            // 
            // tab_createtask
            // 
            tab_createtask.Controls.Add(txt_taskid);
            tab_createtask.Controls.Add(lbl_taskid);
            tab_createtask.Controls.Add(txt_reward);
            tab_createtask.Controls.Add(txt_extradetails);
            tab_createtask.Controls.Add(txt_taskdescription);
            tab_createtask.Controls.Add(btn_createtask);
            tab_createtask.Controls.Add(lbl_dollarrewards);
            tab_createtask.Controls.Add(lbl_extradetails);
            tab_createtask.Controls.Add(lbl_taskdescription);
            tab_createtask.Location = new Point(4, 34);
            tab_createtask.Name = "tab_createtask";
            tab_createtask.Padding = new Padding(3);
            tab_createtask.Size = new Size(698, 301);
            tab_createtask.TabIndex = 0;
            tab_createtask.Text = "Create Task";
            tab_createtask.UseVisualStyleBackColor = true;
            tab_createtask.Click += tabPage1_Click;
            // 
            // txt_taskid
            // 
            txt_taskid.Location = new Point(304, 17);
            txt_taskid.Name = "txt_taskid";
            txt_taskid.Size = new Size(150, 31);
            txt_taskid.TabIndex = 8;
            // 
            // lbl_taskid
            // 
            lbl_taskid.AutoSize = true;
            lbl_taskid.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_taskid.Location = new Point(106, 12);
            lbl_taskid.Name = "lbl_taskid";
            lbl_taskid.Size = new Size(104, 38);
            lbl_taskid.TabIndex = 7;
            lbl_taskid.Text = "Task ID";
            // 
            // txt_reward
            // 
            txt_reward.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_reward.Location = new Point(304, 150);
            txt_reward.Name = "txt_reward";
            txt_reward.Size = new Size(150, 39);
            txt_reward.TabIndex = 6;
            // 
            // txt_extradetails
            // 
            txt_extradetails.Location = new Point(303, 102);
            txt_extradetails.Name = "txt_extradetails";
            txt_extradetails.Size = new Size(278, 31);
            txt_extradetails.TabIndex = 5;
            // 
            // txt_taskdescription
            // 
            txt_taskdescription.Location = new Point(303, 58);
            txt_taskdescription.Name = "txt_taskdescription";
            txt_taskdescription.Size = new Size(277, 31);
            txt_taskdescription.TabIndex = 4;
            txt_taskdescription.TextChanged += textBox1_TextChanged;
            // 
            // btn_createtask
            // 
            btn_createtask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_createtask.Location = new Point(280, 213);
            btn_createtask.Name = "btn_createtask";
            btn_createtask.Size = new Size(143, 47);
            btn_createtask.TabIndex = 3;
            btn_createtask.Text = "Create Task";
            btn_createtask.UseVisualStyleBackColor = true;
            btn_createtask.Click += btn_createtask_Click;
            // 
            // lbl_dollarrewards
            // 
            lbl_dollarrewards.AutoSize = true;
            lbl_dollarrewards.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_dollarrewards.Location = new Point(29, 142);
            lbl_dollarrewards.Name = "lbl_dollarrewards";
            lbl_dollarrewards.Size = new Size(231, 38);
            lbl_dollarrewards.TabIndex = 2;
            lbl_dollarrewards.Text = "Dollar Rewards: $";
            lbl_dollarrewards.Click += lbl_dollarrewards_Click;
            // 
            // lbl_extradetails
            // 
            lbl_extradetails.AutoSize = true;
            lbl_extradetails.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_extradetails.Location = new Point(91, 94);
            lbl_extradetails.Name = "lbl_extradetails";
            lbl_extradetails.Size = new Size(169, 38);
            lbl_extradetails.TabIndex = 1;
            lbl_extradetails.Text = "Extra Details";
            // 
            // lbl_taskdescription
            // 
            lbl_taskdescription.AutoSize = true;
            lbl_taskdescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_taskdescription.Location = new Point(42, 50);
            lbl_taskdescription.Name = "lbl_taskdescription";
            lbl_taskdescription.Size = new Size(218, 38);
            lbl_taskdescription.TabIndex = 0;
            lbl_taskdescription.Text = "Task Description";
            // 
            // tab_edittask
            // 
            tab_edittask.Controls.Add(Update);
            tab_edittask.Controls.Add(txt_edit_description);
            tab_edittask.Controls.Add(txt_task_Edit_id);
            tab_edittask.Controls.Add(Description);
            tab_edittask.Controls.Add(lbl_task_edit_id);
            tab_edittask.Location = new Point(4, 34);
            tab_edittask.Name = "tab_edittask";
            tab_edittask.Padding = new Padding(3);
            tab_edittask.Size = new Size(698, 301);
            tab_edittask.TabIndex = 1;
            tab_edittask.Text = "Edit Task";
            tab_edittask.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            Update.Location = new Point(296, 233);
            Update.Name = "Update";
            Update.Size = new Size(112, 34);
            Update.TabIndex = 4;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // txt_edit_description
            // 
            txt_edit_description.Location = new Point(314, 154);
            txt_edit_description.Name = "txt_edit_description";
            txt_edit_description.Size = new Size(214, 31);
            txt_edit_description.TabIndex = 3;
            // 
            // txt_task_Edit_id
            // 
            txt_task_Edit_id.Location = new Point(315, 83);
            txt_task_Edit_id.Name = "txt_task_Edit_id";
            txt_task_Edit_id.Size = new Size(213, 31);
            txt_task_Edit_id.TabIndex = 2;
            txt_task_Edit_id.TextChanged += txt_task_Edit_id_TextChanged;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Description.Location = new Point(83, 136);
            Description.Name = "Description";
            Description.Size = new Size(158, 38);
            Description.TabIndex = 1;
            Description.Text = "Description";
            // 
            // lbl_task_edit_id
            // 
            lbl_task_edit_id.AutoSize = true;
            lbl_task_edit_id.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_task_edit_id.Location = new Point(99, 80);
            lbl_task_edit_id.Name = "lbl_task_edit_id";
            lbl_task_edit_id.Size = new Size(114, 38);
            lbl_task_edit_id.TabIndex = 0;
            lbl_task_edit_id.Text = "TASK ID";
            // 
            // tab_deletetask
            // 
            tab_deletetask.Controls.Add(datagridview_deletetask);
            tab_deletetask.Controls.Add(txt_taskiddelete);
            tab_deletetask.Controls.Add(lbl_entertaskid);
            tab_deletetask.Controls.Add(btn_deletetask);
            tab_deletetask.Location = new Point(4, 34);
            tab_deletetask.Name = "tab_deletetask";
            tab_deletetask.Size = new Size(698, 301);
            tab_deletetask.TabIndex = 2;
            tab_deletetask.Text = "Delete Task";
            tab_deletetask.UseVisualStyleBackColor = true;
            // 
            // datagridview_deletetask
            // 
            datagridview_deletetask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_deletetask.Location = new Point(43, 95);
            datagridview_deletetask.Name = "datagridview_deletetask";
            datagridview_deletetask.RowHeadersWidth = 62;
            datagridview_deletetask.Size = new Size(611, 151);
            datagridview_deletetask.TabIndex = 3;
            // 
            // txt_taskiddelete
            // 
            txt_taskiddelete.Location = new Point(274, 37);
            txt_taskiddelete.Name = "txt_taskiddelete";
            txt_taskiddelete.Size = new Size(179, 31);
            txt_taskiddelete.TabIndex = 2;
            txt_taskiddelete.TextChanged += txt_taskiddelete_TextChanged;
            // 
            // lbl_entertaskid
            // 
            lbl_entertaskid.AutoSize = true;
            lbl_entertaskid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_entertaskid.Location = new Point(76, 34);
            lbl_entertaskid.Name = "lbl_entertaskid";
            lbl_entertaskid.Size = new Size(150, 32);
            lbl_entertaskid.TabIndex = 1;
            lbl_entertaskid.Text = "Enter Task ID";
            // 
            // btn_deletetask
            // 
            btn_deletetask.Location = new Point(296, 252);
            btn_deletetask.Name = "btn_deletetask";
            btn_deletetask.Size = new Size(157, 34);
            btn_deletetask.TabIndex = 0;
            btn_deletetask.Text = "DELETE TASK";
            btn_deletetask.UseVisualStyleBackColor = true;
            btn_deletetask.Click += btn_deletetask_Click;
            // 
            // tab_viewtask
            // 
            tab_viewtask.Controls.Add(lbl_viewalltasks);
            tab_viewtask.Controls.Add(dataGridView_viewalltasks);
            tab_viewtask.Location = new Point(4, 34);
            tab_viewtask.Name = "tab_viewtask";
            tab_viewtask.Size = new Size(698, 301);
            tab_viewtask.TabIndex = 3;
            tab_viewtask.Text = "View Task";
            tab_viewtask.UseVisualStyleBackColor = true;
            // 
            // lbl_viewalltasks
            // 
            lbl_viewalltasks.AutoSize = true;
            lbl_viewalltasks.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_viewalltasks.Location = new Point(265, 9);
            lbl_viewalltasks.Name = "lbl_viewalltasks";
            lbl_viewalltasks.Size = new Size(188, 38);
            lbl_viewalltasks.TabIndex = 1;
            lbl_viewalltasks.Text = "View All Tasks";
            // 
            // dataGridView_viewalltasks
            // 
            dataGridView_viewalltasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_viewalltasks.Location = new Point(58, 60);
            dataGridView_viewalltasks.Name = "dataGridView_viewalltasks";
            dataGridView_viewalltasks.RowHeadersWidth = 62;
            dataGridView_viewalltasks.Size = new Size(584, 225);
            dataGridView_viewalltasks.TabIndex = 0;
            dataGridView_viewalltasks.CellContentClick += dataGridView_viewalltasks_CellContentClick;
            // 
            // lbl_managetaskheading
            // 
            lbl_managetaskheading.AutoSize = true;
            lbl_managetaskheading.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_managetaskheading.Location = new Point(308, 9);
            lbl_managetaskheading.Name = "lbl_managetaskheading";
            lbl_managetaskheading.Size = new Size(203, 45);
            lbl_managetaskheading.TabIndex = 1;
            lbl_managetaskheading.Text = "Manage Task";
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(352, 418);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(105, 51);
            btn_back.TabIndex = 2;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // popup_managetaskCRUD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(btn_back);
            Controls.Add(lbl_managetaskheading);
            Controls.Add(tab_CRUDtasks);
            Name = "popup_managetaskCRUD";
            Text = "popup_managetaskCRUD";
            tab_CRUDtasks.ResumeLayout(false);
            tab_createtask.ResumeLayout(false);
            tab_createtask.PerformLayout();
            tab_edittask.ResumeLayout(false);
            tab_edittask.PerformLayout();
            tab_deletetask.ResumeLayout(false);
            tab_deletetask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview_deletetask).EndInit();
            tab_viewtask.ResumeLayout(false);
            tab_viewtask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_viewalltasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tab_CRUDtasks;
        private TabPage tab_createtask;
        private TabPage tab_edittask;
        private TabPage tab_deletetask;
        private TabPage tab_viewtask;
        private Label lbl_managetaskheading;
        private Button btn_createtask;
        private Label lbl_dollarrewards;
        private Label lbl_extradetails;
        private Label lbl_taskdescription;
        private TextBox txt_reward;
        private TextBox txt_extradetails;
        private TextBox txt_taskdescription;
        private TextBox txt_taskid;
        private Label lbl_taskid;
        private Label Description;
        private Label lbl_task_edit_id;
        private Button Update;
        private TextBox txt_edit_description;
        private TextBox txt_task_Edit_id;
        private Button btn_back;
        private Label lbl_entertaskid;
        private Button btn_deletetask;
        private TextBox txt_taskiddelete;
        private DataGridView datagridview_deletetask;
        private Label lbl_viewalltasks;
        private DataGridView dataGridView_viewalltasks;
    }
}