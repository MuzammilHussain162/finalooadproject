namespace finalooadproject
{
    partial class signupformanager
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
            lbl_signupmanagerheading = new Label();
            lbl_username = new Label();
            lbl_email = new Label();
            lbl_password = new Label();
            txt_username = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            btn_back = new Button();
            btn_register = new Button();
            SuspendLayout();
            // 
            // lbl_signupmanagerheading
            // 
            lbl_signupmanagerheading.AutoSize = true;
            lbl_signupmanagerheading.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_signupmanagerheading.Location = new Point(142, 9);
            lbl_signupmanagerheading.Name = "lbl_signupmanagerheading";
            lbl_signupmanagerheading.Size = new Size(536, 65);
            lbl_signupmanagerheading.TabIndex = 0;
            lbl_signupmanagerheading.Text = "SIGNUP FOR MANAGER";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(122, 116);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(142, 38);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Username";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(122, 199);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(83, 38);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "Email";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(122, 269);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(132, 38);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(291, 116);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(299, 45);
            txt_username.TabIndex = 4;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(293, 199);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(297, 45);
            txt_email.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(291, 269);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(299, 45);
            txt_password.TabIndex = 6;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(161, 359);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(125, 50);
            btn_back.TabIndex = 7;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(439, 359);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(151, 50);
            btn_register.TabIndex = 8;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // signupformanager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_register);
            Controls.Add(btn_back);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_email);
            Controls.Add(lbl_username);
            Controls.Add(lbl_signupmanagerheading);
            Name = "signupformanager";
            Text = "signupformanager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_signupmanagerheading;
        private Label lbl_username;
        private Label lbl_email;
        private Label lbl_password;
        private TextBox txt_username;
        private TextBox txt_email;
        private TextBox txt_password;
        private Button btn_back;
        private Button btn_register;
    }
}