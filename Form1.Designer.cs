namespace final_presentation_layer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_heading = new Label();
            lbl_username = new Label();
            lbl_password = new Label();
            linklbl_Signup_as_manager = new LinkLabel();
            label1 = new Label();
            linkLbl_signup_as_employee = new LinkLabel();
            txtbox_username = new TextBox();
            txtbox_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // lbl_heading
            // 
            lbl_heading.AutoSize = true;
            lbl_heading.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_heading.Location = new Point(265, 25);
            lbl_heading.Name = "lbl_heading";
            lbl_heading.Size = new Size(599, 60);
            lbl_heading.TabIndex = 0;
            lbl_heading.Text = "TASK MANAGEMENT SYSTEM";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(145, 164);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(142, 38);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(155, 235);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(132, 38);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Password";
            // 
            // linklbl_Signup_as_manager
            // 
            linklbl_Signup_as_manager.AutoSize = true;
            linklbl_Signup_as_manager.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_Signup_as_manager.Location = new Point(96, 421);
            linklbl_Signup_as_manager.Name = "linklbl_Signup_as_manager";
            linklbl_Signup_as_manager.Size = new Size(265, 38);
            linklbl_Signup_as_manager.TabIndex = 3;
            linklbl_Signup_as_manager.TabStop = true;
            linklbl_Signup_as_manager.Text = "Sign Up as manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 366);
            label1.Name = "label1";
            label1.Size = new Size(320, 38);
            label1.TabIndex = 4;
            label1.Text = "Don't have any account?";
            // 
            // linkLbl_signup_as_employee
            // 
            linkLbl_signup_as_employee.AutoSize = true;
            linkLbl_signup_as_employee.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLbl_signup_as_employee.Location = new Point(646, 421);
            linkLbl_signup_as_employee.Name = "linkLbl_signup_as_employee";
            linkLbl_signup_as_employee.Size = new Size(277, 38);
            linkLbl_signup_as_employee.TabIndex = 5;
            linkLbl_signup_as_employee.TabStop = true;
            linkLbl_signup_as_employee.Text = "Sign Up as Employee";
            // 
            // txtbox_username
            // 
            txtbox_username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_username.Location = new Point(312, 164);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(518, 45);
            txtbox_username.TabIndex = 6;
            // 
            // txtbox_password
            // 
            txtbox_password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_password.Location = new Point(312, 232);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.Size = new Size(518, 45);
            txtbox_password.TabIndex = 7;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(442, 313);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(134, 50);
            btn_login.TabIndex = 8;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 519);
            Controls.Add(btn_login);
            Controls.Add(txtbox_password);
            Controls.Add(txtbox_username);
            Controls.Add(linkLbl_signup_as_employee);
            Controls.Add(label1);
            Controls.Add(linklbl_Signup_as_manager);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(lbl_heading);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_heading;
        private Label lbl_username;
        private Label lbl_password;
        private LinkLabel linklbl_Signup_as_manager;
        private Label label1;
        private LinkLabel linkLbl_signup_as_employee;
        private TextBox txtbox_username;
        private TextBox txtbox_password;
        private Button btn_login;
    }
}
