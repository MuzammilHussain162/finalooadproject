namespace finalooadproject
{
    partial class signupforemployee
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
            label2 = new Label();
            lbl_email = new Label();
            lbl_password = new Label();
            btn_register = new Button();
            btn_back = new Button();
            txt_username = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(501, 65);
            label1.TabIndex = 0;
            label1.Text = "SIGNUP FOR WORKER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 169);
            label2.Name = "label2";
            label2.Size = new Size(142, 38);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(154, 111);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(83, 38);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "Email";
            lbl_email.Visible = false;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(137, 224);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(132, 38);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Password";
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(439, 356);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(150, 50);
            btn_register.TabIndex = 4;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(179, 356);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(137, 50);
            btn_back.TabIndex = 5;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(308, 162);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(310, 45);
            txt_username.TabIndex = 6;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(307, 111);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(310, 45);
            txt_email.TabIndex = 7;
            txt_email.Visible = false;
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(307, 217);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(311, 45);
            txt_password.TabIndex = 8;
            // 
            // signupforemployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_username);
            Controls.Add(btn_back);
            Controls.Add(btn_register);
            Controls.Add(lbl_password);
            Controls.Add(lbl_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signupforemployee";
            Text = "signupforemployee";
            Load += signupforemployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_email;
        private Label lbl_password;
        private Button btn_register;
        private Button btn_back;
        private TextBox txt_username;
        private TextBox txt_email;
        private TextBox txt_password;
    }
}