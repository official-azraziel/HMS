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
    public partial class doctor_portal : Form
    {
        public doctor_portal()
        {
            InitializeComponent();
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            doctor_details dd = new doctor_details();
            dd.Show();
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            patient_details pd = new patient_details();
            pd.Show();
        }
    }
}
