﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalooadproject
{
    public partial class loginmanager : Form
    {
        public loginmanager()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            loginform lgform = new loginform();
            lgform.Show();
        }

        private void loginmanager_Load(object sender, EventArgs e)
        {

        }
    }
}
