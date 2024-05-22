namespace finalooadproject
{
    partial class Dashboard_Employee
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
            btn_markcomplete = new Button();
            btn_searchtask = new Button();
            btn_viewreward = new Button();
            button1 = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 45);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD WORKER";
            // 
            // btn_markcomplete
            // 
            btn_markcomplete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_markcomplete.Location = new Point(252, 77);
            btn_markcomplete.Name = "btn_markcomplete";
            btn_markcomplete.Size = new Size(301, 53);
            btn_markcomplete.TabIndex = 1;
            btn_markcomplete.Text = "Mark Task Complete";
            btn_markcomplete.UseVisualStyleBackColor = true;
            // 
            // btn_searchtask
            // 
            btn_searchtask.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_searchtask.Location = new Point(290, 146);
            btn_searchtask.Name = "btn_searchtask";
            btn_searchtask.Size = new Size(223, 51);
            btn_searchtask.TabIndex = 2;
            btn_searchtask.Text = "Search Task";
            btn_searchtask.UseVisualStyleBackColor = true;
            // 
            // btn_viewreward
            // 
            btn_viewreward.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_viewreward.Location = new Point(290, 216);
            btn_viewreward.Name = "btn_viewreward";
            btn_viewreward.Size = new Size(223, 62);
            btn_viewreward.TabIndex = 3;
            btn_viewreward.Text = "View Reward";
            btn_viewreward.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(252, 296);
            button1.Name = "button1";
            button1.Size = new Size(290, 52);
            button1.TabIndex = 4;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(325, 363);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(143, 56);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // Dashboard_Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(button1);
            Controls.Add(btn_viewreward);
            Controls.Add(btn_searchtask);
            Controls.Add(btn_markcomplete);
            Controls.Add(label1);
            Name = "Dashboard_Employee";
            Text = "Dashboard_Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_markcomplete;
        private Button btn_searchtask;
        private Button btn_viewreward;
        private Button button1;
        private Button btn_exit;
    }
}