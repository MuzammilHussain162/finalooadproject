namespace finalooadproject
{
    partial class loginform
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
            lbl_projectheading = new Label();
            linklbl_loginasemployee = new LinkLabel();
            linkLbl_loginasmanager = new LinkLabel();
            linkLbl_signupforemployee = new LinkLabel();
            linklbl_signupasmanager = new LinkLabel();
            lbl_noaccountcreate = new Label();
            combobox_loginas = new ComboBox();
            label1 = new Label();
            lbl_username = new Label();
            lbl_password = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            linklbl_forgotpassword = new LinkLabel();
            SuspendLayout();
            // 
            // lbl_projectheading
            // 
            lbl_projectheading.AutoSize = true;
            lbl_projectheading.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_projectheading.Location = new Point(131, 9);
            lbl_projectheading.Name = "lbl_projectheading";
            lbl_projectheading.Size = new Size(599, 60);
            lbl_projectheading.TabIndex = 0;
            lbl_projectheading.Text = "TASK MANAGEMENT SYSTEM";
            lbl_projectheading.Click += lbl_projectheading_Click;
            // 
            // linklbl_loginasemployee
            // 
            linklbl_loginasemployee.AutoSize = true;
            linklbl_loginasemployee.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_loginasemployee.Location = new Point(432, 536);
            linklbl_loginasemployee.Name = "linklbl_loginasemployee";
            linklbl_loginasemployee.Size = new Size(190, 28);
            linklbl_loginasemployee.TabIndex = 1;
            linklbl_loginasemployee.TabStop = true;
            linklbl_loginasemployee.Text = "Login as a Employee";
            linklbl_loginasemployee.Visible = false;
            linklbl_loginasemployee.LinkClicked += linklbl_loginasemployee_LinkClicked;
            // 
            // linkLbl_loginasmanager
            // 
            linkLbl_loginasmanager.AutoSize = true;
            linkLbl_loginasmanager.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLbl_loginasmanager.Location = new Point(292, 536);
            linkLbl_loginasmanager.Name = "linkLbl_loginasmanager";
            linkLbl_loginasmanager.Size = new Size(182, 28);
            linkLbl_loginasmanager.TabIndex = 2;
            linkLbl_loginasmanager.TabStop = true;
            linkLbl_loginasmanager.Text = "Login as a Manager";
            linkLbl_loginasmanager.Visible = false;
            linkLbl_loginasmanager.LinkClicked += linkLbl_loginasmanager_LinkClicked;
            // 
            // linkLbl_signupforemployee
            // 
            linkLbl_signupforemployee.AutoSize = true;
            linkLbl_signupforemployee.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLbl_signupforemployee.Location = new Point(107, 459);
            linkLbl_signupforemployee.Name = "linkLbl_signupforemployee";
            linkLbl_signupforemployee.Size = new Size(244, 38);
            linkLbl_signupforemployee.TabIndex = 3;
            linkLbl_signupforemployee.TabStop = true;
            linkLbl_signupforemployee.Text = "Signup for Worker";
            linkLbl_signupforemployee.LinkClicked += linkLbl_signupforemployee_LinkClicked;
            // 
            // linklbl_signupasmanager
            // 
            linklbl_signupasmanager.AutoSize = true;
            linklbl_signupasmanager.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_signupasmanager.Location = new Point(505, 459);
            linklbl_signupasmanager.Name = "linklbl_signupasmanager";
            linklbl_signupasmanager.Size = new Size(264, 38);
            linklbl_signupasmanager.TabIndex = 4;
            linklbl_signupasmanager.TabStop = true;
            linklbl_signupasmanager.Text = "Signup for Manager";
            linklbl_signupasmanager.LinkClicked += linklbl_signupasmanager_LinkClicked;
            // 
            // lbl_noaccountcreate
            // 
            lbl_noaccountcreate.AutoSize = true;
            lbl_noaccountcreate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_noaccountcreate.Location = new Point(226, 399);
            lbl_noaccountcreate.Name = "lbl_noaccountcreate";
            lbl_noaccountcreate.Size = new Size(396, 38);
            lbl_noaccountcreate.TabIndex = 5;
            lbl_noaccountcreate.Text = "No account? Create a new one";
            // 
            // combobox_loginas
            // 
            combobox_loginas.FormattingEnabled = true;
            combobox_loginas.Items.AddRange(new object[] { "MANAGER", "WORKER" });
            combobox_loginas.Location = new Point(302, 134);
            combobox_loginas.Name = "combobox_loginas";
            combobox_loginas.Size = new Size(278, 33);
            combobox_loginas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 135);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 7;
            label1.Text = "Login As";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(175, 190);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(121, 32);
            lbl_username.TabIndex = 8;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(185, 245);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(111, 32);
            lbl_password.TabIndex = 9;
            lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(302, 182);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(423, 45);
            txt_username.TabIndex = 10;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(302, 237);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(423, 45);
            txt_password.TabIndex = 11;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(398, 347);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 49);
            btn_login.TabIndex = 12;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // linklbl_forgotpassword
            // 
            linklbl_forgotpassword.AutoSize = true;
            linklbl_forgotpassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_forgotpassword.Location = new Point(350, 296);
            linklbl_forgotpassword.Name = "linklbl_forgotpassword";
            linklbl_forgotpassword.Size = new Size(234, 38);
            linklbl_forgotpassword.TabIndex = 13;
            linklbl_forgotpassword.TabStop = true;
            linklbl_forgotpassword.Text = "Forgot Password?";
            linklbl_forgotpassword.LinkClicked += linklbl_forgotpassword_LinkClicked;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 573);
            Controls.Add(linklbl_forgotpassword);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(label1);
            Controls.Add(combobox_loginas);
            Controls.Add(lbl_noaccountcreate);
            Controls.Add(linklbl_signupasmanager);
            Controls.Add(linkLbl_signupforemployee);
            Controls.Add(linkLbl_loginasmanager);
            Controls.Add(linklbl_loginasemployee);
            Controls.Add(lbl_projectheading);
            Name = "loginform";
            Text = "loginform";
            Load += loginform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_projectheading;
        private LinkLabel linklbl_loginasemployee;
        private LinkLabel linkLbl_loginasmanager;
        private LinkLabel linkLbl_signupforemployee;
        private LinkLabel linklbl_signupasmanager;
        private Label lbl_noaccountcreate;
        private ComboBox combobox_loginas;
        private Label label1;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private LinkLabel linklbl_forgotpassword;
    }
}