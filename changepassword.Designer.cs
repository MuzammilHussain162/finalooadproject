namespace finalooadproject
{
    partial class changepassword
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
            lbl_changepasswordheading = new Label();
            lbl_currentpassword = new Label();
            lbl_newpassword = new Label();
            btn_update = new Button();
            txt_currentpassword = new TextBox();
            txt_newpassword = new TextBox();
            btn_back = new Button();
            SuspendLayout();
            // 
            // lbl_changepasswordheading
            // 
            lbl_changepasswordheading.AutoSize = true;
            lbl_changepasswordheading.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_changepasswordheading.Location = new Point(248, 9);
            lbl_changepasswordheading.Name = "lbl_changepasswordheading";
            lbl_changepasswordheading.Size = new Size(280, 38);
            lbl_changepasswordheading.TabIndex = 0;
            lbl_changepasswordheading.Text = "CHANGE PASSWORD";
            // 
            // lbl_currentpassword
            // 
            lbl_currentpassword.AutoSize = true;
            lbl_currentpassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_currentpassword.Location = new Point(94, 129);
            lbl_currentpassword.Name = "lbl_currentpassword";
            lbl_currentpassword.Size = new Size(233, 38);
            lbl_currentpassword.TabIndex = 1;
            lbl_currentpassword.Text = "Current Password";
            // 
            // lbl_newpassword
            // 
            lbl_newpassword.AutoSize = true;
            lbl_newpassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_newpassword.Location = new Point(131, 210);
            lbl_newpassword.Name = "lbl_newpassword";
            lbl_newpassword.Size = new Size(196, 38);
            lbl_newpassword.TabIndex = 2;
            lbl_newpassword.Text = "New Password";
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(474, 340);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 46);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txt_currentpassword
            // 
            txt_currentpassword.Location = new Point(378, 137);
            txt_currentpassword.Name = "txt_currentpassword";
            txt_currentpassword.PasswordChar = '*';
            txt_currentpassword.Size = new Size(267, 31);
            txt_currentpassword.TabIndex = 4;
            // 
            // txt_newpassword
            // 
            txt_newpassword.Location = new Point(378, 210);
            txt_newpassword.Name = "txt_newpassword";
            txt_newpassword.PasswordChar = '*';
            txt_newpassword.Size = new Size(267, 31);
            txt_newpassword.TabIndex = 5;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(192, 340);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 46);
            btn_back.TabIndex = 6;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // changepassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(txt_newpassword);
            Controls.Add(txt_currentpassword);
            Controls.Add(btn_update);
            Controls.Add(lbl_newpassword);
            Controls.Add(lbl_currentpassword);
            Controls.Add(lbl_changepasswordheading);
            Name = "changepassword";
            Text = "changepassword";
            Load += changepassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_changepasswordheading;
        private Label lbl_currentpassword;
        private Label lbl_newpassword;
        private Button btn_update;
        private TextBox txt_currentpassword;
        private TextBox txt_newpassword;
        private Button btn_back;
    }
}