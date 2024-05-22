namespace finalooadproject
{
    partial class managerdashboard
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
            lbl_dashboardmanager = new Label();
            btn_managetask = new Button();
            btn_manageworker = new Button();
            btn_changepassword = new Button();
            btn_search = new Button();
            button2 = new Button();
            btn_exit = new Button();
            txt_username = new TextBox();
            lbl_username = new Label();
            SuspendLayout();
            // 
            // lbl_dashboardmanager
            // 
            lbl_dashboardmanager.AutoSize = true;
            lbl_dashboardmanager.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_dashboardmanager.Location = new Point(222, 9);
            lbl_dashboardmanager.Name = "lbl_dashboardmanager";
            lbl_dashboardmanager.Size = new Size(365, 45);
            lbl_dashboardmanager.TabIndex = 0;
            lbl_dashboardmanager.Text = "DASHBOARD MANAGER";
            // 
            // btn_managetask
            // 
            btn_managetask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_managetask.Location = new Point(340, 69);
            btn_managetask.Name = "btn_managetask";
            btn_managetask.Size = new Size(269, 48);
            btn_managetask.TabIndex = 1;
            btn_managetask.Text = "Manage Task";
            btn_managetask.UseVisualStyleBackColor = true;
            btn_managetask.Click += btn_managetask_Click;
            // 
            // btn_manageworker
            // 
            btn_manageworker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_manageworker.Location = new Point(340, 138);
            btn_manageworker.Name = "btn_manageworker";
            btn_manageworker.Size = new Size(269, 45);
            btn_manageworker.TabIndex = 2;
            btn_manageworker.Text = "Manage Workers";
            btn_manageworker.UseVisualStyleBackColor = true;
            // 
            // btn_changepassword
            // 
            btn_changepassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_changepassword.Location = new Point(340, 206);
            btn_changepassword.Name = "btn_changepassword";
            btn_changepassword.Size = new Size(269, 47);
            btn_changepassword.TabIndex = 3;
            btn_changepassword.Text = "Change Password";
            btn_changepassword.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.Location = new Point(340, 277);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(269, 49);
            btn_search.TabIndex = 4;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(45, 409);
            button2.Name = "button2";
            button2.Size = new Size(269, 42);
            button2.TabIndex = 5;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(340, 358);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(269, 46);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(23, 107);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(260, 31);
            txt_username.TabIndex = 7;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(98, 79);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(104, 25);
            lbl_username.TabIndex = 8;
            lbl_username.Text = "USERNAME";
            // 
            // managerdashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_username);
            Controls.Add(txt_username);
            Controls.Add(btn_exit);
            Controls.Add(button2);
            Controls.Add(btn_search);
            Controls.Add(btn_changepassword);
            Controls.Add(btn_manageworker);
            Controls.Add(btn_managetask);
            Controls.Add(lbl_dashboardmanager);
            Name = "managerdashboard";
            Text = "managerdashboard";
            Load += managerdashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_dashboardmanager;
        private Button btn_managetask;
        private Button btn_manageworker;
        private Button btn_changepassword;
        private Button btn_search;
        private Button button2;
        private Button btn_exit;
        private TextBox txt_username;
        private Label lbl_username;
    }
}