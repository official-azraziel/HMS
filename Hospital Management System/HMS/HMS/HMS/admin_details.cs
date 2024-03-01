using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class admin_details : Form
    {
        public admin_details()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand insert = new SqlCommand("insert into admin_details values('" + txt_aid.Text + "','" + txt_name.Text + "','" + txt_pid.Text + "','" + txt_did.Text + "')", con);
            con.Open();
            insert.CommandType = CommandType.Text;
            insert.ExecuteNonQuery();
            MessageBox.Show("Data Added Successfully !", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand update = new SqlCommand("update admin_details set Name ='" + txt_name.Text + "', PID = '" + txt_pid.Text + "', DID ='" + txt_did.Text + "' where AID = '" + txt_aid.Text + "'", con);
            con.Open();
            update.CommandType = CommandType.Text;
            update.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully !", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand search = new SqlCommand("select * from admin_details where AID = '" + txt_aid.Text + "'", con);
            con.Open();
            SqlDataReader adr = search.ExecuteReader();
            if (adr.Read())
            {
                txt_aid.Text = adr[0].ToString();
                txt_name.Text = adr[1].ToString();
                txt_pid.Text = adr[2].ToString();
                txt_did.Text = adr[3].ToString();
            }
            else
            {
                MessageBox.Show("Data Not Found !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand delete = new SqlCommand("delete from admin_details where AID = '" + txt_aid.Text + "'", con);
            con.Open();
            delete.CommandType = CommandType.Text;
            delete.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully !", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_aid.Clear();
            txt_name.Clear();
            txt_pid.Clear();
            txt_did.Clear();
        }
    }
}
