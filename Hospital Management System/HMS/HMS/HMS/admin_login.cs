﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user_id = txt_username.Text;
            string password = txt_password.Text;
            if (user_id == "admin" && password == "admin123")
            {
                admin_panel ap = new admin_panel();
                ap.Show();
            }
            else
            {
                MessageBox.Show("Login Not Success! Please Try Again!", "Login Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
