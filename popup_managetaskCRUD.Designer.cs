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
            tabControl1 = new TabControl();
            tab_createtask = new TabPage();
            tab_edittask = new TabPage();
            lbl_managetaskheading = new Label();
            tab_deletetask = new TabPage();
            tab_updatetask = new TabPage();
            lbl_taskdescription = new Label();
            lbl_extradetails = new Label();
            lbl_dollarrewards = new Label();
            btn_createtask = new Button();
            txt_taskdescription = new TextBox();
            txt_extradetails = new TextBox();
            txt_reward = new TextBox();
            lbl_task_edit_id = new Label();
            Description = new Label();
            lbl_taskid = new Label();
            txt_taskid = new TextBox();
            txt_task_Edit_id = new TextBox();
            txt_edit_description = new TextBox();
            Update = new Button();
            tabControl1.SuspendLayout();
            tab_createtask.SuspendLayout();
            tab_edittask.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_createtask);
            tabControl1.Controls.Add(tab_edittask);
            tabControl1.Controls.Add(tab_deletetask);
            tabControl1.Controls.Add(tab_updatetask);
            tabControl1.Location = new Point(54, 62);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(706, 339);
            tabControl1.TabIndex = 0;
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
            // tab_deletetask
            // 
            tab_deletetask.Location = new Point(4, 34);
            tab_deletetask.Name = "tab_deletetask";
            tab_deletetask.Size = new Size(698, 301);
            tab_deletetask.TabIndex = 2;
            tab_deletetask.Text = "Delete Task";
            tab_deletetask.UseVisualStyleBackColor = true;
            // 
            // tab_updatetask
            // 
            tab_updatetask.Location = new Point(4, 34);
            tab_updatetask.Name = "tab_updatetask";
            tab_updatetask.Size = new Size(698, 301);
            tab_updatetask.TabIndex = 3;
            tab_updatetask.Text = "Update Task";
            tab_updatetask.UseVisualStyleBackColor = true;
            // 
            // lbl_taskdescription
            // 
            lbl_taskdescription.AutoSize = true;
            lbl_taskdescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_taskdescription.Location = new Point(42, 46);
            lbl_taskdescription.Name = "lbl_taskdescription";
            lbl_taskdescription.Size = new Size(218, 38);
            lbl_taskdescription.TabIndex = 0;
            lbl_taskdescription.Text = "Task Description";
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
            // lbl_dollarrewards
            // 
            lbl_dollarrewards.AutoSize = true;
            lbl_dollarrewards.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_dollarrewards.Location = new Point(29, 142);
            lbl_dollarrewards.Name = "lbl_dollarrewards";
            lbl_dollarrewards.Size = new Size(231, 38);
            lbl_dollarrewards.TabIndex = 2;
            lbl_dollarrewards.Text = "Dollar Rewards: $";
            // 
            // btn_createtask
            // 
            btn_createtask.Location = new Point(280, 213);
            btn_createtask.Name = "btn_createtask";
            btn_createtask.Size = new Size(143, 47);
            btn_createtask.TabIndex = 3;
            btn_createtask.Text = "Create Task";
            btn_createtask.UseVisualStyleBackColor = true;
            // 
            // txt_taskdescription
            // 
            txt_taskdescription.Location = new Point(304, 54);
            txt_taskdescription.Name = "txt_taskdescription";
            txt_taskdescription.Size = new Size(277, 31);
            txt_taskdescription.TabIndex = 4;
            txt_taskdescription.TextChanged += textBox1_TextChanged;
            // 
            // txt_extradetails
            // 
            txt_extradetails.Location = new Point(303, 102);
            txt_extradetails.Name = "txt_extradetails";
            txt_extradetails.Size = new Size(278, 31);
            txt_extradetails.TabIndex = 5;
            // 
            // txt_reward
            // 
            txt_reward.Location = new Point(304, 150);
            txt_reward.Name = "txt_reward";
            txt_reward.Size = new Size(150, 31);
            txt_reward.TabIndex = 6;
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
            // txt_taskid
            // 
            txt_taskid.Location = new Point(304, 17);
            txt_taskid.Name = "txt_taskid";
            txt_taskid.Size = new Size(150, 31);
            txt_taskid.TabIndex = 8;
            // 
            // txt_task_Edit_id
            // 
            txt_task_Edit_id.Location = new Point(315, 83);
            txt_task_Edit_id.Name = "txt_task_Edit_id";
            txt_task_Edit_id.Size = new Size(213, 31);
            txt_task_Edit_id.TabIndex = 2;
            // 
            // txt_edit_description
            // 
            txt_edit_description.Location = new Point(314, 154);
            txt_edit_description.Name = "txt_edit_description";
            txt_edit_description.Size = new Size(214, 31);
            txt_edit_description.TabIndex = 3;
            // 
            // Update
            // 
            Update.Location = new Point(296, 233);
            Update.Name = "Update";
            Update.Size = new Size(112, 34);
            Update.TabIndex = 4;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            // 
            // popup_managetaskCRUD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_managetaskheading);
            Controls.Add(tabControl1);
            Name = "popup_managetaskCRUD";
            Text = "popup_managetaskCRUD";
            tabControl1.ResumeLayout(false);
            tab_createtask.ResumeLayout(false);
            tab_createtask.PerformLayout();
            tab_edittask.ResumeLayout(false);
            tab_edittask.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab_createtask;
        private TabPage tab_edittask;
        private TabPage tab_deletetask;
        private TabPage tab_updatetask;
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
    }
}