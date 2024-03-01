using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class payments : Form
    {
        public payments()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand insert = new SqlCommand("insert into payment_details values('" + txt_pmid.Text + "','" + txt_pid.Text + "','" + txt_name.Text + "','" + txt_date.Text + "','" + txt_amount.Text + "')", con);
            con.Open();
            insert.CommandType = CommandType.Text;
            insert.ExecuteNonQuery();
            MessageBox.Show("Data Added Successfully !", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand update = new SqlCommand("update payment_details set PID ='" + txt_pid.Text + "', Name = '" + txt_name.Text + "', Date ='" + txt_date.Text + "',Amount ='" + txt_amount.Text + "' where PMID = '" + txt_pmid.Text + "'", con);
            con.Open();
            update.CommandType = CommandType.Text;
            update.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully !", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand search = new SqlCommand("select * from payment_details where PMID = '" + txt_pmid.Text + "'", con);
            con.Open();
            SqlDataReader adr = search.ExecuteReader();
            if (adr.Read())
            {
                txt_pmid.Text = adr[0].ToString();
                txt_pid.Text = adr[1].ToString();
                txt_name.Text = adr[2].ToString();
                txt_date.Text = adr[3].ToString();
                txt_amount.Text = adr[4].ToString();
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
            SqlCommand delete = new SqlCommand("delete from payment_details where PMID = '" + txt_pmid.Text + "'", con);
            con.Open();
            delete.CommandType = CommandType.Text;
            delete.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully !", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pmid.Clear();
            txt_pid.Clear();
            txt_name.Clear();
            txt_date.Clear();
            txt_amount.Clear();
        }
    }
}
