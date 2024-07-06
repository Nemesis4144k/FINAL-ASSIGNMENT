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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4();
            newform.Show();
            this.Hide();

        }
        SqlConnection con = new SqlConnection("Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False");
        private void button7_Click(object sender, EventArgs e)
        {
            
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Wants','Subscriptions','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");
        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Wants','Donations','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Wants','Gym','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Wants','Clothing','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Wants','Hobbies','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Wants','Cosmetics','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            con.Open();
            String Exp_Amount = textBox2.Text;
            string Querry = "Insert into Expenses values('" + LOGIN.Username + "',SYSDATETIME(),'Wants','Electronic Goods','" + Exp_Amount + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Successfully added!");

        }
    }
}
