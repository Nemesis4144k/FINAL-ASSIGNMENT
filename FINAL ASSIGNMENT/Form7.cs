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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False");
        private void button12_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4();
            newform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Emergency Fund','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Debt Payments','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Insurance','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Vacation Fund','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','House Fund','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button7_Click(object sender, EventArgs e)
        {
        
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Vehicle Fund','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Pension Contribution','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }
    }
}
