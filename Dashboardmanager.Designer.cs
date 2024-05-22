namespace finalooadproject
{
    partial class Dashboardmanager
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
            tab_changepassword = new TabControl();
            tab_managetask = new TabPage();
            tab_changepass = new TabPage();
            tab_searchtask = new TabPage();
            tab_manageworkers = new TabPage();
            tab_goback = new TabPage();
            tab_exitlogout = new TabPage();
            tabControl1 = new TabControl();
            tab_createtask = new TabPage();
            tab_edittask = new TabPage();
            tab_deletetask = new TabPage();
            table_confirmtask = new TabPage();
            lbl_description = new Label();
            lbl_extradetails = new Label();
            lbl_dollarrewards = new Label();
            lbl_otherrewards = new Label();
            txt_description = new TextBox();
            txt_extradetails = new TextBox();
            txt_dollarrewards = new TextBox();
            txt_otherrewards = new TextBox();
            btn_addtask = new Button();
            lbl_taskid = new Label();
            txt_taskid = new TextBox();
            lbl_taskidupdate = new Label();
            lbl_descriptionupdate = new Label();
            lbl_extradetailsupdate = new Label();
            lbl_dollarrateupdate = new Label();
            lbl_otherrewardsupdate = new Label();
            lbl_taskpara = new Label();
            UPDATE = new Button();
            txt_taskidforupdate = new TextBox();
            txt_descriptionupdate = new TextBox();
            txt_extradetailsupdate = new TextBox();
            txt_dollarrewardsupdate = new TextBox();
            txt_otherewardsupdate = new TextBox();
            lbl_taskiddelete = new Label();
            txt_taskiddelete = new TextBox();
            dataGridView1 = new DataGridView();
            dataviewfordeletingtab = new DataGridView();
            tab_changepassword.SuspendLayout();
            tab_managetask.SuspendLayout();
            tabControl1.SuspendLayout();
            tab_createtask.SuspendLayout();
            tab_edittask.SuspendLayout();
            tab_deletetask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataviewfordeletingtab).BeginInit();
            SuspendLayout();
            // 
            // tab_changepassword
            // 
            tab_changepassword.Controls.Add(tab_managetask);
            tab_changepassword.Controls.Add(tab_changepass);
            tab_changepassword.Controls.Add(tab_searchtask);
            tab_changepassword.Controls.Add(tab_manageworkers);
            tab_changepassword.Controls.Add(tab_goback);
            tab_changepassword.Controls.Add(tab_exitlogout);
            tab_changepassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tab_changepassword.Location = new Point(12, 12);
            tab_changepassword.Name = "tab_changepassword";
            tab_changepassword.SelectedIndex = 0;
            tab_changepassword.Size = new Size(967, 490);
            tab_changepassword.TabIndex = 0;
            tab_changepassword.Tag = "";
            // 
            // tab_managetask
            // 
            tab_managetask.BackColor = Color.Lime;
            tab_managetask.BorderStyle = BorderStyle.Fixed3D;
            tab_managetask.Controls.Add(tabControl1);
            tab_managetask.ForeColor = Color.Black;
            tab_managetask.Location = new Point(4, 41);
            tab_managetask.Name = "tab_managetask";
            tab_managetask.Padding = new Padding(3);
            tab_managetask.Size = new Size(959, 445);
            tab_managetask.TabIndex = 1;
            tab_managetask.Text = "Manage Tasks";
            tab_managetask.Click += this.tabPage2_Click;
            // 
            // tab_changepass
            // 
            tab_changepass.BackColor = Color.Magenta;
            tab_changepass.Location = new Point(4, 41);
            tab_changepass.Name = "tab_changepass";
            tab_changepass.Padding = new Padding(3);
            tab_changepass.Size = new Size(959, 445);
            tab_changepass.TabIndex = 2;
            tab_changepass.Text = "Change Password";
            // 
            // tab_searchtask
            // 
            tab_searchtask.BackColor = Color.Gold;
            tab_searchtask.Location = new Point(4, 41);
            tab_searchtask.Name = "tab_searchtask";
            tab_searchtask.Size = new Size(959, 445);
            tab_searchtask.TabIndex = 3;
            tab_searchtask.Text = "Search Tasks";
            // 
            // tab_manageworkers
            // 
            tab_manageworkers.BackColor = Color.PaleTurquoise;
            tab_manageworkers.Location = new Point(4, 41);
            tab_manageworkers.Name = "tab_manageworkers";
            tab_manageworkers.Size = new Size(959, 445);
            tab_manageworkers.TabIndex = 4;
            tab_manageworkers.Text = "Manage Workers";
            // 
            // tab_goback
            // 
            tab_goback.BackColor = Color.DeepSkyBlue;
            tab_goback.Location = new Point(4, 41);
            tab_goback.Name = "tab_goback";
            tab_goback.Size = new Size(959, 445);
            tab_goback.TabIndex = 5;
            tab_goback.Text = "Go Back?";
            // 
            // tab_exitlogout
            // 
            tab_exitlogout.BackColor = Color.DarkViolet;
            tab_exitlogout.Location = new Point(4, 41);
            tab_exitlogout.Name = "tab_exitlogout";
            tab_exitlogout.Size = new Size(959, 445);
            tab_exitlogout.TabIndex = 6;
            tab_exitlogout.Text = "Logout";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_createtask);
            tabControl1.Controls.Add(tab_edittask);
            tabControl1.Controls.Add(tab_deletetask);
            tabControl1.Controls.Add(table_confirmtask);
            tabControl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(6, 6);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(943, 429);
            tabControl1.TabIndex = 0;
            // 
            // tab_createtask
            // 
            tab_createtask.BackColor = Color.FromArgb(255, 192, 192);
            tab_createtask.Controls.Add(txt_taskid);
            tab_createtask.Controls.Add(lbl_taskid);
            tab_createtask.Controls.Add(btn_addtask);
            tab_createtask.Controls.Add(txt_otherrewards);
            tab_createtask.Controls.Add(txt_dollarrewards);
            tab_createtask.Controls.Add(txt_extradetails);
            tab_createtask.Controls.Add(txt_description);
            tab_createtask.Controls.Add(lbl_otherrewards);
            tab_createtask.Controls.Add(lbl_dollarrewards);
            tab_createtask.Controls.Add(lbl_extradetails);
            tab_createtask.Controls.Add(lbl_description);
            tab_createtask.Location = new Point(4, 47);
            tab_createtask.Name = "tab_createtask";
            tab_createtask.Padding = new Padding(3);
            tab_createtask.Size = new Size(935, 378);
            tab_createtask.TabIndex = 0;
            tab_createtask.Text = "Create Task";
            // 
            // tab_edittask
            // 
            tab_edittask.BackColor = Color.FromArgb(255, 255, 192);
            tab_edittask.Controls.Add(txt_otherewardsupdate);
            tab_edittask.Controls.Add(txt_dollarrewardsupdate);
            tab_edittask.Controls.Add(txt_extradetailsupdate);
            tab_edittask.Controls.Add(txt_descriptionupdate);
            tab_edittask.Controls.Add(txt_taskidforupdate);
            tab_edittask.Controls.Add(UPDATE);
            tab_edittask.Controls.Add(lbl_taskpara);
            tab_edittask.Controls.Add(lbl_otherrewardsupdate);
            tab_edittask.Controls.Add(lbl_dollarrateupdate);
            tab_edittask.Controls.Add(lbl_extradetailsupdate);
            tab_edittask.Controls.Add(lbl_descriptionupdate);
            tab_edittask.Controls.Add(lbl_taskidupdate);
            tab_edittask.Location = new Point(4, 47);
            tab_edittask.Name = "tab_edittask";
            tab_edittask.Padding = new Padding(3);
            tab_edittask.Size = new Size(935, 378);
            tab_edittask.TabIndex = 1;
            tab_edittask.Text = "Edit Task";
            // 
            // tab_deletetask
            // 
            tab_deletetask.BackColor = Color.FromArgb(192, 255, 255);
            tab_deletetask.Controls.Add(dataviewfordeletingtab);
            tab_deletetask.Controls.Add(dataGridView1);
            tab_deletetask.Controls.Add(txt_taskiddelete);
            tab_deletetask.Controls.Add(lbl_taskiddelete);
            tab_deletetask.Location = new Point(4, 47);
            tab_deletetask.Name = "tab_deletetask";
            tab_deletetask.Size = new Size(935, 378);
            tab_deletetask.TabIndex = 2;
            tab_deletetask.Text = "Delete Task";
            // 
            // table_confirmtask
            // 
            table_confirmtask.BackColor = Color.Yellow;
            table_confirmtask.Location = new Point(4, 47);
            table_confirmtask.Name = "table_confirmtask";
            table_confirmtask.Size = new Size(935, 378);
            table_confirmtask.TabIndex = 3;
            table_confirmtask.Text = "Confirm Complete Task";
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Location = new Point(201, 89);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(158, 38);
            lbl_description.TabIndex = 0;
            lbl_description.Text = "Description";
            // 
            // lbl_extradetails
            // 
            lbl_extradetails.AutoSize = true;
            lbl_extradetails.Location = new Point(190, 153);
            lbl_extradetails.Name = "lbl_extradetails";
            lbl_extradetails.Size = new Size(169, 38);
            lbl_extradetails.TabIndex = 1;
            lbl_extradetails.Text = "Extra Details";
            // 
            // lbl_dollarrewards
            // 
            lbl_dollarrewards.AutoSize = true;
            lbl_dollarrewards.Location = new Point(128, 216);
            lbl_dollarrewards.Name = "lbl_dollarrewards";
            lbl_dollarrewards.Size = new Size(231, 38);
            lbl_dollarrewards.TabIndex = 2;
            lbl_dollarrewards.Text = "Dollar Rewards: $";
            // 
            // lbl_otherrewards
            // 
            lbl_otherrewards.AutoSize = true;
            lbl_otherrewards.Location = new Point(146, 273);
            lbl_otherrewards.Name = "lbl_otherrewards";
            lbl_otherrewards.Size = new Size(213, 38);
            lbl_otherrewards.TabIndex = 3;
            lbl_otherrewards.Text = "Other Rewards: ";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(383, 82);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(372, 45);
            txt_description.TabIndex = 4;
            // 
            // txt_extradetails
            // 
            txt_extradetails.Location = new Point(383, 146);
            txt_extradetails.Name = "txt_extradetails";
            txt_extradetails.Size = new Size(372, 45);
            txt_extradetails.TabIndex = 5;
            // 
            // txt_dollarrewards
            // 
            txt_dollarrewards.Location = new Point(383, 209);
            txt_dollarrewards.Name = "txt_dollarrewards";
            txt_dollarrewards.Size = new Size(133, 45);
            txt_dollarrewards.TabIndex = 6;
            // 
            // txt_otherrewards
            // 
            txt_otherrewards.Location = new Point(383, 269);
            txt_otherrewards.Name = "txt_otherrewards";
            txt_otherrewards.Size = new Size(325, 45);
            txt_otherrewards.TabIndex = 7;
            // 
            // btn_addtask
            // 
            btn_addtask.Location = new Point(360, 320);
            btn_addtask.Margin = new Padding(0, 3, 3, 3);
            btn_addtask.Name = "btn_addtask";
            btn_addtask.Size = new Size(150, 50);
            btn_addtask.TabIndex = 8;
            btn_addtask.Text = "Add Task";
            btn_addtask.UseVisualStyleBackColor = true;
            // 
            // lbl_taskid
            // 
            lbl_taskid.AutoSize = true;
            lbl_taskid.Location = new Point(235, 29);
            lbl_taskid.Name = "lbl_taskid";
            lbl_taskid.Size = new Size(104, 38);
            lbl_taskid.TabIndex = 9;
            lbl_taskid.Text = "Task ID";
            // 
            // txt_taskid
            // 
            txt_taskid.Location = new Point(383, 26);
            txt_taskid.Name = "txt_taskid";
            txt_taskid.Size = new Size(150, 45);
            txt_taskid.TabIndex = 10;
            // 
            // lbl_taskidupdate
            // 
            lbl_taskidupdate.AutoSize = true;
            lbl_taskidupdate.Location = new Point(216, 36);
            lbl_taskidupdate.Name = "lbl_taskidupdate";
            lbl_taskidupdate.Size = new Size(114, 38);
            lbl_taskidupdate.TabIndex = 0;
            lbl_taskidupdate.Text = "TASK ID";
            // 
            // lbl_descriptionupdate
            // 
            lbl_descriptionupdate.AutoSize = true;
            lbl_descriptionupdate.Location = new Point(216, 86);
            lbl_descriptionupdate.Name = "lbl_descriptionupdate";
            lbl_descriptionupdate.Size = new Size(158, 38);
            lbl_descriptionupdate.TabIndex = 1;
            lbl_descriptionupdate.Text = "Description";
            // 
            // lbl_extradetailsupdate
            // 
            lbl_extradetailsupdate.AutoSize = true;
            lbl_extradetailsupdate.Location = new Point(216, 135);
            lbl_extradetailsupdate.Name = "lbl_extradetailsupdate";
            lbl_extradetailsupdate.Size = new Size(169, 38);
            lbl_extradetailsupdate.TabIndex = 2;
            lbl_extradetailsupdate.Text = "Extra Details";
            // 
            // lbl_dollarrateupdate
            // 
            lbl_dollarrateupdate.AutoSize = true;
            lbl_dollarrateupdate.Location = new Point(216, 185);
            lbl_dollarrateupdate.Name = "lbl_dollarrateupdate";
            lbl_dollarrateupdate.Size = new Size(231, 38);
            lbl_dollarrateupdate.TabIndex = 3;
            lbl_dollarrateupdate.Text = "Dollar Rewards: $";
            // 
            // lbl_otherrewardsupdate
            // 
            lbl_otherrewardsupdate.AutoSize = true;
            lbl_otherrewardsupdate.Location = new Point(216, 236);
            lbl_otherrewardsupdate.Name = "lbl_otherrewardsupdate";
            lbl_otherrewardsupdate.Size = new Size(213, 38);
            lbl_otherrewardsupdate.TabIndex = 4;
            lbl_otherrewardsupdate.Text = "Other Rewards: ";
            // 
            // lbl_taskpara
            // 
            lbl_taskpara.AutoSize = true;
            lbl_taskpara.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_taskpara.Location = new Point(22, 36);
            lbl_taskpara.Name = "lbl_taskpara";
            lbl_taskpara.Size = new Size(196, 28);
            lbl_taskpara.TabIndex = 5;
            lbl_taskpara.Text = "For Update Enter -->";
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(346, 300);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(173, 56);
            UPDATE.TabIndex = 6;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // txt_taskidforupdate
            // 
            txt_taskidforupdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_taskidforupdate.Location = new Point(391, 36);
            txt_taskidforupdate.Name = "txt_taskidforupdate";
            txt_taskidforupdate.Size = new Size(424, 37);
            txt_taskidforupdate.TabIndex = 7;
            // 
            // txt_descriptionupdate
            // 
            txt_descriptionupdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_descriptionupdate.Location = new Point(391, 86);
            txt_descriptionupdate.Name = "txt_descriptionupdate";
            txt_descriptionupdate.Size = new Size(424, 37);
            txt_descriptionupdate.TabIndex = 8;
            // 
            // txt_extradetailsupdate
            // 
            txt_extradetailsupdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_extradetailsupdate.Location = new Point(391, 137);
            txt_extradetailsupdate.Name = "txt_extradetailsupdate";
            txt_extradetailsupdate.Size = new Size(424, 37);
            txt_extradetailsupdate.TabIndex = 9;
            // 
            // txt_dollarrewardsupdate
            // 
            txt_dollarrewardsupdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_dollarrewardsupdate.Location = new Point(453, 185);
            txt_dollarrewardsupdate.Name = "txt_dollarrewardsupdate";
            txt_dollarrewardsupdate.Size = new Size(136, 37);
            txt_dollarrewardsupdate.TabIndex = 10;
            // 
            // txt_otherewardsupdate
            // 
            txt_otherewardsupdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_otherewardsupdate.Location = new Point(453, 240);
            txt_otherewardsupdate.Name = "txt_otherewardsupdate";
            txt_otherewardsupdate.Size = new Size(362, 37);
            txt_otherewardsupdate.TabIndex = 11;
            // 
            // lbl_taskiddelete
            // 
            lbl_taskiddelete.AutoSize = true;
            lbl_taskiddelete.Location = new Point(33, 46);
            lbl_taskiddelete.Name = "lbl_taskiddelete";
            lbl_taskiddelete.Size = new Size(469, 38);
            lbl_taskiddelete.TabIndex = 0;
            lbl_taskiddelete.Text = "FOR DELETING TASK Enter TASK ID:  ";
            // 
            // txt_taskiddelete
            // 
            txt_taskiddelete.Location = new Point(508, 43);
            txt_taskiddelete.Name = "txt_taskiddelete";
            txt_taskiddelete.Size = new Size(168, 45);
            txt_taskiddelete.TabIndex = 1;
            txt_taskiddelete.TextChanged += this.txt_taskiddelete_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(218, 441);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 10);
            dataGridView1.TabIndex = 2;
            dataGridView1.Visible = false;
            // 
            // dataviewfordeletingtab
            // 
            dataviewfordeletingtab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataviewfordeletingtab.Location = new Point(33, 110);
            dataviewfordeletingtab.Name = "dataviewfordeletingtab";
            dataviewfordeletingtab.RowHeadersWidth = 62;
            dataviewfordeletingtab.Size = new Size(886, 255);
            dataviewfordeletingtab.TabIndex = 3;
            dataviewfordeletingtab.CellContentClick += this.dataviewfordeletingtab_CellContentClick;
            // 
            // Dashboardmanager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 535);
            Controls.Add(tab_changepassword);
            Name = "Dashboardmanager";
            Text = "Dashboard";
            Load += this.Dashboardmanager_Load;
            tab_changepassword.ResumeLayout(false);
            tab_managetask.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tab_createtask.ResumeLayout(false);
            tab_createtask.PerformLayout();
            tab_edittask.ResumeLayout(false);
            tab_edittask.PerformLayout();
            tab_deletetask.ResumeLayout(false);
            tab_deletetask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataviewfordeletingtab).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_changepassword;
        private TabPage tab_managetask;
        private TabPage tab_changepass;
        private TabPage tab_searchtask;
        private TabPage tab_manageworkers;
        private TabPage tab_goback;
        private TabPage tab_exitlogout;
        private TabControl tabControl1;
        private TabPage tab_createtask;
        private TabPage tab_edittask;
        private TabPage tab_deletetask;
        private TabPage table_confirmtask;
        private Label lbl_otherrewards;
        private Label lbl_dollarrewards;
        private Label lbl_extradetails;
        private Label lbl_description;
        private Button btn_addtask;
        private TextBox txt_otherrewards;
        private TextBox txt_dollarrewards;
        private TextBox txt_extradetails;
        private TextBox txt_description;
        private TextBox txt_taskid;
        private Label lbl_taskid;
        private Label lbl_taskpara;
        private Label lbl_otherrewardsupdate;
        private Label lbl_dollarrateupdate;
        private Label lbl_extradetailsupdate;
        private Label lbl_descriptionupdate;
        private Label lbl_taskidupdate;
        private Button UPDATE;
        private TextBox txt_taskidforupdate;
        private TextBox txt_otherewardsupdate;
        private TextBox txt_dollarrewardsupdate;
        private TextBox txt_extradetailsupdate;
        private TextBox txt_descriptionupdate;
        private Label lbl_taskiddelete;
        private DataGridView dataviewfordeletingtab;
        private DataGridView dataGridView1;
        private TextBox txt_taskiddelete;
    }
}