namespace finalooadproject
{
    partial class loginemployee
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
            lbl_loginemplyeeheading = new Label();
            lbl_username = new Label();
            lbl_password = new Label();
            lbl_forgetpassword = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_loginemployee = new Button();
            btn_back = new Button();
            SuspendLayout();
            // 
            // lbl_loginemplyeeheading
            // 
            lbl_loginemplyeeheading.AutoSize = true;
            lbl_loginemplyeeheading.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_loginemplyeeheading.Location = new Point(159, 9);
            lbl_loginemplyeeheading.Name = "lbl_loginemplyeeheading";
            lbl_loginemplyeeheading.Size = new Size(475, 65);
            lbl_loginemplyeeheading.TabIndex = 0;
            lbl_loginemplyeeheading.Text = "LOGIN AS EMPLOYEE";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.ForeColor = SystemColors.ActiveCaptionText;
            lbl_username.Location = new Point(60, 121);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(142, 38);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(70, 200);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(132, 38);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Password";
            // 
            // lbl_forgetpassword
            // 
            lbl_forgetpassword.AutoSize = true;
            lbl_forgetpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_forgetpassword.Location = new Point(289, 291);
            lbl_forgetpassword.Name = "lbl_forgetpassword";
            lbl_forgetpassword.Size = new Size(199, 32);
            lbl_forgetpassword.TabIndex = 3;
            lbl_forgetpassword.TabStop = true;
            lbl_forgetpassword.Text = "Forgot Password?";
            lbl_forgetpassword.LinkClicked += lbl_forgetpassword_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(276, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 45);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(276, 200);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(300, 45);
            textBox2.TabIndex = 5;
            // 
            // btn_loginemployee
            // 
            btn_loginemployee.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_loginemployee.Location = new Point(464, 360);
            btn_loginemployee.Name = "btn_loginemployee";
            btn_loginemployee.Size = new Size(112, 49);
            btn_loginemployee.TabIndex = 6;
            btn_loginemployee.Text = "LOGIN";
            btn_loginemployee.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(173, 361);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 48);
            btn_back.TabIndex = 7;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // loginemployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(btn_loginemployee);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_forgetpassword);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(lbl_loginemplyeeheading);
            Name = "loginemployee";
            Text = "loginemployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_loginemplyeeheading;
        private Label lbl_username;
        private Label lbl_password;
        private LinkLabel lbl_forgetpassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_loginemployee;
        private Button btn_back;
    }
}