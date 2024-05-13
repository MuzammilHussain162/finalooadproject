namespace finalooadproject
{
    partial class loginmanager
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
            label1 = new Label();
            lbl_username = new Label();
            lbl_password = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_back = new Button();
            btn_login = new Button();
            lbl_forgotpassword = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(476, 65);
            label1.TabIndex = 0;
            label1.Text = "LOGIN AS MANAGER";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(93, 123);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(142, 38);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(93, 203);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(132, 38);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(287, 125);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(325, 39);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(287, 203);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(325, 45);
            txt_password.TabIndex = 4;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(215, 330);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 47);
            btn_back.TabIndex = 5;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(459, 330);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 47);
            btn_login.TabIndex = 6;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // lbl_forgotpassword
            // 
            lbl_forgotpassword.AutoSize = true;
            lbl_forgotpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_forgotpassword.Location = new Point(296, 278);
            lbl_forgotpassword.Name = "lbl_forgotpassword";
            lbl_forgotpassword.Size = new Size(199, 32);
            lbl_forgotpassword.TabIndex = 7;
            lbl_forgotpassword.TabStop = true;
            lbl_forgotpassword.Text = "Forgot Password?";
            // 
            // loginmanager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(lbl_forgotpassword);
            Controls.Add(btn_login);
            Controls.Add(btn_back);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(label1);
            Name = "loginmanager";
            Text = "loginmanager";
            Load += loginmanager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_back;
        private Button btn_login;
        private LinkLabel lbl_forgotpassword;
    }
}