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

namespace FINAL_ASSIGNMENT
{
    public partial class Form4 : Form       
    {
       
        public Form4()
        {
            InitializeComponent();
            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            //Expense
            con.Open();
            string Query_1 = "Select SUM(Expene_Amount) From Expenses where Username='"+LOGIN.Username+"'";
            SqlCommand cmd_1 = new SqlCommand(Query_1, con);
            SqlDataReader sum_exp = cmd_1.ExecuteReader();
            while (sum_exp.Read())
            {
                label5.Text = sum_exp.GetValue(0).ToString();
            }
            con.Close();

            //Income
            con.Open();
            string Query_2 = "Select SUM(Income_Amount) From Income where Username='"+LOGIN.Username+"'";
            SqlCommand cmd_2 = new SqlCommand(Query_2, con);
            SqlDataReader sum_in = cmd_2.ExecuteReader();
            while (sum_in.Read())
            {

                label7.Text = sum_in.GetValue(0).ToString();
            }
            con.Close();

            //Balance
            int sum_expense, sum_income;
            sum_expense = Convert.ToInt32(label5.Text);
            sum_income = Convert.ToInt32(label7.Text);
            int balance = sum_income - sum_expense;
            label6.Text = ("Rs." + balance.ToString());

            con.Open();
            string Query_3 = "Select SUM(Expene_Amount) From Expenses where Username='"+LOGIN.Username+"' and Expense_Type='Fundamental Needs'"  ;
            SqlCommand cmd_3 = new SqlCommand(Query_3, con);
            SqlDataReader sum_f_needs = cmd_3.ExecuteReader();
            while (sum_f_needs.Read())
            {

                label10.Text = sum_f_needs.GetValue(0).ToString();
            }
            con.Close();   


        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();  
            form11.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();  
            form6.Show(); 
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();  
            form7.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            //Expense
            con.Open();
            string Query_1= "Select SUM(Expene_Amount) From Expenses where Username='"+LOGIN.Username+"'";
            SqlCommand cmd_1 = new SqlCommand(Query_1, con);
            SqlDataReader sum_exp = cmd_1.ExecuteReader();
            while (sum_exp.Read())
            {
                label5.Text = sum_exp.GetValue(0).ToString();
            }
            con.Close();

            //Income
            con.Open();
            string Query_2 = "Select SUM(Income_Amount) From Income where Username='"+LOGIN.Username+"'";
            SqlCommand cmd_2 = new SqlCommand(Query_2, con);
            SqlDataReader sum_in = cmd_2.ExecuteReader();
            while (sum_in.Read())
            {
                
                label7.Text = sum_in.GetValue(0).ToString();
            }
            con.Close();

            //Balance
            int sum_expense = Convert.ToInt32(label5.Text);
            int sum_income = Convert.ToInt32(label7.Text);
            int balance = sum_income- sum_expense;
            label6.Text = ("Rs."+balance.ToString());
            MessageBox.Show("Successfully Refreshed");

        }

        private void label7_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query_2 = "Select SUM(Income_Amount) From Income where Username='"+LOGIN.Username+"'";
            SqlCommand cmd_2 = new SqlCommand(Query_2, con);
            SqlDataReader sum_in = cmd_2.ExecuteReader();
            while (sum_in.Read())
            {

                label7.Text = sum_in.GetValue(0).ToString();
            }
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            //Expense
            con.Open();
            string Query_1 = "Select SUM(Expene_Amount) From Expenses where Username='"+LOGIN.Username+"'";
            SqlCommand cmd_1 = new SqlCommand(Query_1, con);
            SqlDataReader sum_exp = cmd_1.ExecuteReader();
            while (sum_exp.Read())
            {
                label5.Text = sum_exp.GetValue(0).ToString();
            }
            con.Close();
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {
    


        }
    }
}
