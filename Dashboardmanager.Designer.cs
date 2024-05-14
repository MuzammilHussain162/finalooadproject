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
            tab_changepassword.SuspendLayout();
            tab_managetask.SuspendLayout();
            tabControl1.SuspendLayout();
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
            tab_managetask.BackColor = Color.White;
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
            tab_changepass.Location = new Point(4, 41);
            tab_changepass.Name = "tab_changepass";
            tab_changepass.Padding = new Padding(3);
            tab_changepass.Size = new Size(959, 445);
            tab_changepass.TabIndex = 2;
            tab_changepass.Text = "Change Password";
            tab_changepass.UseVisualStyleBackColor = true;
            // 
            // tab_searchtask
            // 
            tab_searchtask.Location = new Point(4, 41);
            tab_searchtask.Name = "tab_searchtask";
            tab_searchtask.Size = new Size(959, 445);
            tab_searchtask.TabIndex = 3;
            tab_searchtask.Text = "Search Tasks";
            tab_searchtask.UseVisualStyleBackColor = true;
            // 
            // tab_manageworkers
            // 
            tab_manageworkers.Location = new Point(4, 41);
            tab_manageworkers.Name = "tab_manageworkers";
            tab_manageworkers.Size = new Size(959, 445);
            tab_manageworkers.TabIndex = 4;
            tab_manageworkers.Text = "Manage Workers";
            tab_manageworkers.UseVisualStyleBackColor = true;
            // 
            // tab_goback
            // 
            tab_goback.Location = new Point(4, 41);
            tab_goback.Name = "tab_goback";
            tab_goback.Size = new Size(959, 445);
            tab_goback.TabIndex = 5;
            tab_goback.Text = "Go Back?";
            tab_goback.UseVisualStyleBackColor = true;
            // 
            // tab_exitlogout
            // 
            tab_exitlogout.Location = new Point(4, 41);
            tab_exitlogout.Name = "tab_exitlogout";
            tab_exitlogout.Size = new Size(959, 445);
            tab_exitlogout.TabIndex = 6;
            tab_exitlogout.Text = "Logout";
            tab_exitlogout.UseVisualStyleBackColor = true;
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
            tabControl1.Size = new Size(943, 419);
            tabControl1.TabIndex = 0;
            // 
            // tab_createtask
            // 
            tab_createtask.Location = new Point(4, 47);
            tab_createtask.Name = "tab_createtask";
            tab_createtask.Padding = new Padding(3);
            tab_createtask.Size = new Size(935, 368);
            tab_createtask.TabIndex = 0;
            tab_createtask.Text = "Create Task";
            tab_createtask.UseVisualStyleBackColor = true;
            // 
            // tab_edittask
            // 
            tab_edittask.Location = new Point(4, 47);
            tab_edittask.Name = "tab_edittask";
            tab_edittask.Padding = new Padding(3);
            tab_edittask.Size = new Size(935, 368);
            tab_edittask.TabIndex = 1;
            tab_edittask.Text = "Edit Task";
            tab_edittask.UseVisualStyleBackColor = true;
            // 
            // tab_deletetask
            // 
            tab_deletetask.Location = new Point(4, 47);
            tab_deletetask.Name = "tab_deletetask";
            tab_deletetask.Size = new Size(935, 368);
            tab_deletetask.TabIndex = 2;
            tab_deletetask.Text = "Delete Task";
            tab_deletetask.UseVisualStyleBackColor = true;
            // 
            // table_confirmtask
            // 
            table_confirmtask.Location = new Point(4, 47);
            table_confirmtask.Name = "table_confirmtask";
            table_confirmtask.Size = new Size(935, 368);
            table_confirmtask.TabIndex = 3;
            table_confirmtask.Text = "Confirm Complete Task";
            table_confirmtask.UseVisualStyleBackColor = true;
            // 
            // Dashboardmanager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 535);
            Controls.Add(tab_changepassword);
            Name = "Dashboardmanager";
            Text = "Dashboard";
            tab_changepassword.ResumeLayout(false);
            tab_managetask.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
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
    }
}