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
using System.Reflection.Emit;

namespace FINAL_ASSIGNMENT
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4();
            newform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Rent/Mortgage','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            
            string Querry = "Select SUM(Expene_Amount) From Expenses where Username='"+LOGIN.Username+"'";
            SqlCommand cmd = new SqlCommand(Querry, con);
            
            SqlDataReader sum = cmd.ExecuteReader();
            while (sum.Read())
            {
                label4.Text = sum.GetValue(0).ToString();
            }
            
            
            con.Close();
            MessageBox.Show("Successfully Refreshed");
        }
    }
}
