﻿namespace finalooadproject
{
    partial class forgetpassword
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
            lbl_forgotpasswordheading = new Label();
            lbl_newpassword = new Label();
            label3 = new Label();
            txt_newpassword = new TextBox();
            txt_confirmpassword = new TextBox();
            btn_DONE = new Button();
            BACK = new Button();
            lbl_username = new Label();
            txt_username = new TextBox();
            SuspendLayout();
            // 
            // lbl_forgotpasswordheading
            // 
            lbl_forgotpasswordheading.AutoSize = true;
            lbl_forgotpasswordheading.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_forgotpasswordheading.Location = new Point(183, 9);
            lbl_forgotpasswordheading.Name = "lbl_forgotpasswordheading";
            lbl_forgotpasswordheading.Size = new Size(493, 65);
            lbl_forgotpasswordheading.TabIndex = 0;
            lbl_forgotpasswordheading.Text = "FORGOT PASSWORD?";
            // 
            // lbl_newpassword
            // 
            lbl_newpassword.AutoSize = true;
            lbl_newpassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_newpassword.Location = new Point(121, 184);
            lbl_newpassword.Name = "lbl_newpassword";
            lbl_newpassword.Size = new Size(196, 38);
            lbl_newpassword.TabIndex = 1;
            lbl_newpassword.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 249);
            label3.Name = "label3";
            label3.Size = new Size(239, 38);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // txt_newpassword
            // 
            txt_newpassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_newpassword.Location = new Point(378, 184);
            txt_newpassword.Name = "txt_newpassword";
            txt_newpassword.PasswordChar = '*';
            txt_newpassword.Size = new Size(261, 45);
            txt_newpassword.TabIndex = 3;
            // 
            // txt_confirmpassword
            // 
            txt_confirmpassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confirmpassword.Location = new Point(378, 249);
            txt_confirmpassword.Name = "txt_confirmpassword";
            txt_confirmpassword.PasswordChar = '*';
            txt_confirmpassword.Size = new Size(261, 45);
            txt_confirmpassword.TabIndex = 4;
            // 
            // btn_DONE
            // 
            btn_DONE.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DONE.Location = new Point(405, 351);
            btn_DONE.Name = "btn_DONE";
            btn_DONE.Size = new Size(112, 52);
            btn_DONE.TabIndex = 5;
            btn_DONE.Text = "DONE";
            btn_DONE.UseVisualStyleBackColor = true;
            btn_DONE.Click += btn_DONE_Click;
            // 
            // BACK
            // 
            BACK.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BACK.Location = new Point(205, 354);
            BACK.Name = "BACK";
            BACK.Size = new Size(112, 49);
            BACK.TabIndex = 6;
            BACK.Text = "BACK";
            BACK.UseVisualStyleBackColor = true;
            BACK.Click += BACK_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(162, 117);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(142, 38);
            lbl_username.TabIndex = 7;
            lbl_username.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(378, 117);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(261, 45);
            txt_username.TabIndex = 8;
            // 
            // forgetpassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_username);
            Controls.Add(lbl_username);
            Controls.Add(BACK);
            Controls.Add(btn_DONE);
            Controls.Add(txt_confirmpassword);
            Controls.Add(txt_newpassword);
            Controls.Add(label3);
            Controls.Add(lbl_newpassword);
            Controls.Add(lbl_forgotpasswordheading);
            Name = "forgetpassword";
            Text = "forgetpassword";
            Load += forgetpassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_forgotpasswordheading;
        private Label lbl_newpassword;
        private Label label3;
        private TextBox txt_newpassword;
        private TextBox txt_confirmpassword;
        private Button btn_DONE;
        private Button BACK;
        private Label lbl_username;
        private TextBox txt_username;
    }
}