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

namespace FINAL_ASSIGNMENT
{
    public partial class Savings : Form
    {
        public Savings()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P43TIUK\\SQLEXPRESS2024;Initial Catalog=\"final assaigment\";Integrated Security=True;Encrypt=False");
        private void button12_Click(object sender, EventArgs e)
        {
            Home newform = new Home();
            newform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Emergency Fund','" + Exp_Amount + "')";
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Expense Successfully added!");
            }
            else
            {
                MessageBox.Show("Please Enter Expense Amount!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Debt Payments','" + Exp_Amount + "')";
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Expense Successfully added!");
            }
            else
            {
                MessageBox.Show("Please Enter Expense Amount!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Insurance','" + Exp_Amount + "')";
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Expense Successfully added!");
            }
            else
            {
                MessageBox.Show("Please Enter Expense Amount!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Vacation Fund','" + Exp_Amount + "')";
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Expense Successfully added!");
            }
            else
            {
                MessageBox.Show("Please Enter Expense Amount!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','House Fund','" + Exp_Amount + "')";
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Expense Successfully added!");
            }
            else
            {
                MessageBox.Show("Please Enter Expense Amount!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Vehicle Fund','" + Exp_Amount + "')";
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Expense Successfully added!");
            }
            else
            {
                MessageBox.Show("Please Enter Expense Amount!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Savings','Pension Contribution','" + Exp_Amount + "')";
                SqlCommand cmd = new SqlCommand(Querry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Expense Successfully added!");
            }
            else
            {
                MessageBox.Show("Please Enter Expense Amount!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
