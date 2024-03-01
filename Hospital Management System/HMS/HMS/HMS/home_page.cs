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
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            admin_login al = new admin_login();
            al.Show();
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            patient_login pl = new patient_login();
            pl.Show();
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            doctor_login dl = new doctor_login();
            dl.Show();
        }
    }
}
