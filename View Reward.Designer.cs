namespace finalooadproject
{
    partial class View_Reward
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
            lbl_ViewReward = new Label();
            lbl_rewardis = new Label();
            btn_back = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lbl_ViewReward
            // 
            lbl_ViewReward.AutoSize = true;
            lbl_ViewReward.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ViewReward.Location = new Point(259, 9);
            lbl_ViewReward.Name = "lbl_ViewReward";
            lbl_ViewReward.Size = new Size(224, 48);
            lbl_ViewReward.TabIndex = 0;
            lbl_ViewReward.Text = "View Reward";
            // 
            // lbl_rewardis
            // 
            lbl_rewardis.AutoSize = true;
            lbl_rewardis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_rewardis.Location = new Point(86, 169);
            lbl_rewardis.Name = "lbl_rewardis";
            lbl_rewardis.Size = new Size(301, 48);
            lbl_rewardis.TabIndex = 1;
            lbl_rewardis.Text = "Your Reward Is : $";
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(322, 365);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(121, 41);
            btn_back.TabIndex = 2;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(409, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 50);
            textBox1.TabIndex = 3;
            // 
            // View_Reward
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btn_back);
            Controls.Add(lbl_rewardis);
            Controls.Add(lbl_ViewReward);
            Name = "View_Reward";
            Text = "View_Reward";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ViewReward;
        private Label lbl_rewardis;
        private Button btn_back;
        private TextBox textBox1;
    }
}