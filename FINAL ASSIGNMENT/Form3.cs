﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FINAL_ASSIGNMENT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Final Assignment\";Integrated Security=True;Encrypt=False";
         SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string username = textBox1.Text;
            string email = textBox3.Text; 
            string password = textBox2.Text;
            String Querry = "insert into Users values ('" + username + "','" + email + "','" + password + "')";

            SqlCommand cmd = new SqlCommand(Querry,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered Successfully");

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
