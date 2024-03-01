using System;
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
    public partial class doctor_login : Form
    {
        public doctor_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user_id = txt_username.Text;
            string password = txt_password.Text;
            if (user_id == "doctor" && password == "doctor123")
            {
                doctor_portal dp = new doctor_portal();
                dp.Show();
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
