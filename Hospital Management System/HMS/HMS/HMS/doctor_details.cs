﻿using System;
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
    public partial class doctor_details : Form
    {
        public doctor_details()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand insert = new SqlCommand("insert into doctor_details values('" + txt_did.Text + "','" + txt_name.Text + "','" + txt_gender.Text + "','" + txt_age.Text + "','"+txt_contact.Text+"','"+txt_dob.Text+"','"+txt_spec.Text+"')", con);
            con.Open();
            insert.CommandType = CommandType.Text;
            insert.ExecuteNonQuery();
            MessageBox.Show("Data Added Successfully !", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand update = new SqlCommand("update doctor_details set Name ='" + txt_name.Text + "', Gender = '" + txt_gender.Text + "', Age ='" + txt_gender.Text + "', Contact ='"+txt_contact.Text+"', DOB ='"+txt_dob.Text+"', Specialization ='"+txt_spec.Text+"' where DID = '" + txt_did.Text + "'", con);
            con.Open();
            update.CommandType = CommandType.Text;
            update.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully !", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CAT\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;");
            SqlCommand search = new SqlCommand("select * from doctor_details where DID = '" + txt_did.Text + "'", con);
            con.Open();
            SqlDataReader adr = search.ExecuteReader();
            if (adr.Read())
            {
                txt_did.Text = adr[0].ToString();
                txt_name.Text = adr[1].ToString();
                txt_gender.Text = adr[2].ToString();
                txt_age.Text = adr[3].ToString();
                txt_contact.Text = adr[4].ToString();
                txt_dob.Text = adr[5].ToString();
                txt_spec.Text = adr[6].ToString();
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
            SqlCommand delete = new SqlCommand("delete from doctor_details where DID = '" + txt_did.Text + "'", con);
            con.Open();
            delete.CommandType = CommandType.Text;
            delete.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully !", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_did.Clear();
            txt_name.Clear();
            txt_gender.Clear();
            txt_age.Clear();
            txt_contact.Clear();
            txt_dob.Clear();
            txt_spec.Clear();
        }
    }
}
