namespace finalooadproject
{
    partial class marktaskcomplete
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
            lbl_marktaskcomplete = new Label();
            lbl_entertaskid = new Label();
            txt_taskidformarkcomplete = new TextBox();
            btn_back = new Button();
            btn_markcomplete = new Button();
            datagridview_marktaskcomplete = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagridview_marktaskcomplete).BeginInit();
            SuspendLayout();
            // 
            // lbl_marktaskcomplete
            // 
            lbl_marktaskcomplete.AutoSize = true;
            lbl_marktaskcomplete.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_marktaskcomplete.Location = new Point(285, 9);
            lbl_marktaskcomplete.Name = "lbl_marktaskcomplete";
            lbl_marktaskcomplete.Size = new Size(352, 45);
            lbl_marktaskcomplete.TabIndex = 0;
            lbl_marktaskcomplete.Text = "MARK TASK COMPLETE";
            // 
            // lbl_entertaskid
            // 
            lbl_entertaskid.AutoSize = true;
            lbl_entertaskid.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_entertaskid.Location = new Point(12, 103);
            lbl_entertaskid.Name = "lbl_entertaskid";
            lbl_entertaskid.Size = new Size(523, 38);
            lbl_entertaskid.TabIndex = 1;
            lbl_entertaskid.Text = "Enter Task ID you want to mark complete";
            // 
            // txt_taskidformarkcomplete
            // 
            txt_taskidformarkcomplete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_taskidformarkcomplete.Location = new Point(552, 103);
            txt_taskidformarkcomplete.Name = "txt_taskidformarkcomplete";
            txt_taskidformarkcomplete.Size = new Size(237, 45);
            txt_taskidformarkcomplete.TabIndex = 2;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(203, 459);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(161, 43);
            btn_back.TabIndex = 3;
            btn_back.Text = "BACK";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_markcomplete
            // 
            btn_markcomplete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_markcomplete.Location = new Point(465, 459);
            btn_markcomplete.Name = "btn_markcomplete";
            btn_markcomplete.Size = new Size(205, 43);
            btn_markcomplete.TabIndex = 4;
            btn_markcomplete.Text = "Mark Complete";
            btn_markcomplete.UseVisualStyleBackColor = true;
            btn_markcomplete.Click += btn_markcomplete_Click;
            // 
            // datagridview_marktaskcomplete
            // 
            datagridview_marktaskcomplete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview_marktaskcomplete.Location = new Point(50, 190);
            datagridview_marktaskcomplete.Name = "datagridview_marktaskcomplete";
            datagridview_marktaskcomplete.RowHeadersWidth = 62;
            datagridview_marktaskcomplete.Size = new Size(780, 225);
            datagridview_marktaskcomplete.TabIndex = 5;
            // 
            // marktaskcomplete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 514);
            Controls.Add(datagridview_marktaskcomplete);
            Controls.Add(btn_markcomplete);
            Controls.Add(btn_back);
            Controls.Add(txt_taskidformarkcomplete);
            Controls.Add(lbl_entertaskid);
            Controls.Add(lbl_marktaskcomplete);
            Name = "marktaskcomplete";
            Text = "marktaskcomplete";
            Load += marktaskcomplete_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview_marktaskcomplete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_marktaskcomplete;
        private Label lbl_entertaskid;
        private TextBox txt_taskidformarkcomplete;
        private Button btn_back;
        private Button btn_markcomplete;
        private DataGridView datagridview_marktaskcomplete;
    }
}