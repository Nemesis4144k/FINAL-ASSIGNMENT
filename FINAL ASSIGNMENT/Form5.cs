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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_ASSIGNMENT
{
    public partial class Fundamental_Needs : Form
    {
      
        public Fundamental_Needs()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P43TIUK\\SQLEXPRESS2024;Initial Catalog=\"final assaigment\";Integrated Security=True;Encrypt=False");
        private void label2_Click(object sender, EventArgs e)
        {

        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Food','" + Exp_Amount + "')";
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
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Rent/Mortgage','" + Exp_Amount + "')";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
      

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Healthcare','" + Exp_Amount + "')";
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
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Utilities','" + Exp_Amount + "')";
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
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Phonebills','" + Exp_Amount + "')";
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

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Education','" + Exp_Amount + "')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Transportation','" + Exp_Amount + "')";
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
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Groceries','" + Exp_Amount + "')";
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                con.Open();
                String Exp_Amount = textBox2.Text;
                string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Fundamental Needs','Children Education','" + Exp_Amount + "')";
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

        private void Button9_Click(object sender, EventArgs e)
        {

        }
    }
}
