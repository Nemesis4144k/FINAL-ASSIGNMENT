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
    
    public partial class LOGIN: Form
    {
        public static string Username = "";
        public LOGIN()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-P43TIUK\\SQLEXPRESS2024;Initial Catalog=\"final assaigment\";Integrated Security=True;Encrypt=False");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
      

            String User_password;
            Username = txt_username.Text;
            User_password = txt_password.Text;
           
                String Querry = "Select * From Users Where Username = '" + Username + "' AND User_Password = '" + User_password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Querry, Conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
            
                if (dtable.Rows.Count > 0)
                {
                    Username = txt_username.Text;
                    User_password = txt_password.Text;

                    // to go to dashboard
                    Home form4 = new Home();
                    form4.Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    //to focus username
                    txt_username.Focus();
                }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sign_up form3 = new Sign_up();
            form3.Show();
            this.Hide();
        }
    }
}
