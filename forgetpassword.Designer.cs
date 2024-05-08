namespace finalooadproject
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
            textBox1 = new TextBox();
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
            lbl_newpassword.Location = new Point(121, 144);
            lbl_newpassword.Name = "lbl_newpassword";
            lbl_newpassword.Size = new Size(196, 38);
            lbl_newpassword.TabIndex = 1;
            lbl_newpassword.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 224);
            label3.Name = "label3";
            label3.Size = new Size(239, 38);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 31);
            textBox1.TabIndex = 3;
            // 
            // forgetpassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(lbl_newpassword);
            Controls.Add(lbl_forgotpasswordheading);
            Name = "forgetpassword";
            Text = "forgetpassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_forgotpasswordheading;
        private Label lbl_newpassword;
        private Label label3;
        private TextBox textBox1;
    }
}