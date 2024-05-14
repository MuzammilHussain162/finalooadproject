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
            linklbl_loginasemployee.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_loginasemployee.Location = new Point(282, 131);
            linklbl_loginasemployee.Name = "linklbl_loginasemployee";
            linklbl_loginasemployee.Size = new Size(311, 45);
            linklbl_loginasemployee.TabIndex = 1;
            linklbl_loginasemployee.TabStop = true;
            linklbl_loginasemployee.Text = "Login as a Employee";
            linklbl_loginasemployee.LinkClicked += linklbl_loginasemployee_LinkClicked;
            // 
            // linkLbl_loginasmanager
            // 
            linkLbl_loginasmanager.AutoSize = true;
            linkLbl_loginasmanager.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLbl_loginasmanager.Location = new Point(282, 218);
            linkLbl_loginasmanager.Name = "linkLbl_loginasmanager";
            linkLbl_loginasmanager.Size = new Size(298, 45);
            linkLbl_loginasmanager.TabIndex = 2;
            linkLbl_loginasmanager.TabStop = true;
            linkLbl_loginasmanager.Text = "Login as a Manager";
            linkLbl_loginasmanager.LinkClicked += linkLbl_loginasmanager_LinkClicked;
            // 
            // linkLbl_signupforemployee
            // 
            linkLbl_signupforemployee.AutoSize = true;
            linkLbl_signupforemployee.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLbl_signupforemployee.Location = new Point(111, 383);
            linkLbl_signupforemployee.Name = "linkLbl_signupforemployee";
            linkLbl_signupforemployee.Size = new Size(276, 38);
            linkLbl_signupforemployee.TabIndex = 3;
            linkLbl_signupforemployee.TabStop = true;
            linkLbl_signupforemployee.Text = "Signup for employee";
            // 
            // linklbl_signupasmanager
            // 
            linklbl_signupasmanager.AutoSize = true;
            linklbl_signupasmanager.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_signupasmanager.Location = new Point(519, 383);
            linklbl_signupasmanager.Name = "linklbl_signupasmanager";
            linklbl_signupasmanager.Size = new Size(264, 38);
            linklbl_signupasmanager.TabIndex = 4;
            linklbl_signupasmanager.TabStop = true;
            linklbl_signupasmanager.Text = "Signup for Manager";
            // 
            // lbl_noaccountcreate
            // 
            lbl_noaccountcreate.AutoSize = true;
            lbl_noaccountcreate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_noaccountcreate.Location = new Point(234, 331);
            lbl_noaccountcreate.Name = "lbl_noaccountcreate";
            lbl_noaccountcreate.Size = new Size(396, 38);
            lbl_noaccountcreate.TabIndex = 5;
            lbl_noaccountcreate.Text = "No account? Create a new one";
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 573);
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
    }
}