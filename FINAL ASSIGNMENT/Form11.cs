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


namespace FINAL_ASSIGNMENT
{
    public partial class Budget : Form
    {
        public static int Budget_F_needs;
        public static int Budget_Wants;
        public static int Budget_Savings;
        public static string Budget_Month = "";
        public Budget()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ConnectionString = ("Data Source=DESKTOP-P43TIUK\\SQLEXPRESS2024;Initial Catalog=\"final assaigment\";Integrated Security=True;Encrypt=False");
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            int Budget_F_needs= Convert.ToInt32(textBox2.Text);
            int Budget_Wants=Convert.ToInt32(textBox4.Text);
            int Budget_Savings=Convert.ToInt32(textBox5.Text);
            String Budget_Month=comboBox1.Text;

            string Querry = "Insert into Budget values('" + LOGIN.Username + "','"+Budget_Month+"','"+Budget_F_needs+"','"+Budget_Wants+"','" + Budget_Savings + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Budget Successfully set!");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Home form4 = new Home();  
            form4.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
