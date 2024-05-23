namespace finalooadproject
{
    partial class manage_workers
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
            tabControl1 = new TabControl();
            tab_viewworkers = new TabPage();
            btn_refresh = new Button();
            dataGridView_viewallworkers = new DataGridView();
            tab_deleteworkers = new TabPage();
            btn_deleteworker = new Button();
            txt_employeeid = new TextBox();
            lbl_EnterEmployeeid = new Label();
            dataGridView1 = new DataGridView();
            btn_back = new Button();
            tabControl1.SuspendLayout();
            tab_viewworkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_viewallworkers).BeginInit();
            tab_deleteworkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 45);
            label1.TabIndex = 0;
            label1.Text = "MANAGE WORKERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_viewworkers);
            tabControl1.Controls.Add(tab_deleteworkers);
            tabControl1.Location = new Point(34, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 418);
            tabControl1.TabIndex = 1;
            // 
            // tab_viewworkers
            // 
            tab_viewworkers.Controls.Add(btn_refresh);
            tab_viewworkers.Controls.Add(dataGridView_viewallworkers);
            tab_viewworkers.Location = new Point(4, 34);
            tab_viewworkers.Name = "tab_viewworkers";
            tab_viewworkers.Padding = new Padding(3);
            tab_viewworkers.Size = new Size(778, 380);
            tab_viewworkers.TabIndex = 0;
            tab_viewworkers.Text = "View All Workers";
            tab_viewworkers.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            btn_refresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_refresh.Location = new Point(311, 327);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(112, 47);
            btn_refresh.TabIndex = 1;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // dataGridView_viewallworkers
            // 
            dataGridView_viewallworkers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_viewallworkers.Location = new Point(40, 26);
            dataGridView_viewallworkers.Name = "dataGridView_viewallworkers";
            dataGridView_viewallworkers.RowHeadersWidth = 62;
            dataGridView_viewallworkers.Size = new Size(632, 295);
            dataGridView_viewallworkers.TabIndex = 0;
            dataGridView_viewallworkers.CellContentClick += dataGridView_viewallworkers_CellContentClick;
            // 
            // tab_deleteworkers
            // 
            tab_deleteworkers.Controls.Add(btn_deleteworker);
            tab_deleteworkers.Controls.Add(txt_employeeid);
            tab_deleteworkers.Controls.Add(lbl_EnterEmployeeid);
            tab_deleteworkers.Controls.Add(dataGridView1);
            tab_deleteworkers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tab_deleteworkers.Location = new Point(4, 34);
            tab_deleteworkers.Name = "tab_deleteworkers";
            tab_deleteworkers.Padding = new Padding(3);
            tab_deleteworkers.Size = new Size(778, 380);
            tab_deleteworkers.TabIndex = 1;
            tab_deleteworkers.Text = "Delete Workers";
            tab_deleteworkers.UseVisualStyleBackColor = true;
            // 
            // btn_deleteworker
            // 
            btn_deleteworker.Location = new Point(311, 318);
            btn_deleteworker.Name = "btn_deleteworker";
            btn_deleteworker.Size = new Size(112, 46);
            btn_deleteworker.TabIndex = 3;
            btn_deleteworker.Text = "Delete";
            btn_deleteworker.UseVisualStyleBackColor = true;
            btn_deleteworker.Click += btn_deleteworker_Click;
            // 
            // txt_employeeid
            // 
            txt_employeeid.Location = new Point(323, 30);
            txt_employeeid.Name = "txt_employeeid";
            txt_employeeid.Size = new Size(245, 39);
            txt_employeeid.TabIndex = 2;
            txt_employeeid.TextChanged += txt_employeeid_TextChanged;
            // 
            // lbl_EnterEmployeeid
            // 
            lbl_EnterEmployeeid.AutoSize = true;
            lbl_EnterEmployeeid.Location = new Point(106, 33);
            lbl_EnterEmployeeid.Name = "lbl_EnterEmployeeid";
            lbl_EnterEmployeeid.Size = new Size(211, 32);
            lbl_EnterEmployeeid.TabIndex = 1;
            lbl_EnterEmployeeid.Text = "Enter Employee ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(711, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.Location = new Point(349, 481);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(112, 51);
            btn_back.TabIndex = 2;
            btn_back.Text = "BACK ";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += button1_Click;
            // 
            // manage_workers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 544);
            Controls.Add(btn_back);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "manage_workers";
            Text = "manage_workers";
            Load += manage_workers_Load;
            tabControl1.ResumeLayout(false);
            tab_viewworkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_viewallworkers).EndInit();
            tab_deleteworkers.ResumeLayout(false);
            tab_deleteworkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tab_viewworkers;
        private TabPage tab_deleteworkers;
        private Button btn_back;
        private DataGridView dataGridView_viewallworkers;
        private Button btn_deleteworker;
        private TextBox txt_employeeid;
        private Label lbl_EnterEmployeeid;
        private DataGridView dataGridView1;
        private Button btn_refresh;
    }
}