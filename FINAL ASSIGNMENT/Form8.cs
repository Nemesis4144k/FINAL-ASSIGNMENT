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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FINAL_ASSIGNMENT
{
    public partial class Progress_tracker : Form
    {
        public Progress_tracker()
        {
            InitializeComponent();
         


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {   //Month
            label9.Text = comboBox1.Text;
            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            //Expense total
            con.Open();
            string Query_3 = "Select SUM(Expense_Amount) From Expenses where Username='" + LOGIN.Username + "' and Expense_Type='"+comboBox2.Text+"'";
            SqlCommand cmd_3 = new SqlCommand(Query_3, con);
            SqlDataReader sum_expense = cmd_3.ExecuteReader();
            while (sum_expense.Read())
            {

                label11.Text = sum_expense.GetValue(0).ToString();
            }
            con.Close();
            //Expense Percentage
            con.Open();
            string Query_2 = "Select (Fundamental_Needs) From Budget where Username='" + LOGIN.Username + "' and Budget_Month='"+comboBox1.Text+"'";
            SqlCommand cmd_2 = new SqlCommand(Query_2, con);
            SqlDataReader exp_percent = cmd_2.ExecuteReader();
            while (exp_percent.Read())
            {

                label15.Text = exp_percent.GetValue(0).ToString();
            }
            con.Close();
            //Budget for the month
            int new_total;
            int expense_percent = Convert.ToInt32(label15.Text);          
            con.Close();
            int sum_income = Form4.sum_income; 
            new_total = (expense_percent * sum_income) / 100;
                label10.Text = new_total.ToString();
            //Percentage spent
            int spent = Convert.ToInt32(label11.Text);
            int p_spent = spent / new_total * 100;
            label13.Text = p_spent.ToString();                          
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Month
            label30.Text = comboBox1.Text;
            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            //Expense total
            con.Open();
            string Query_3 = "Select SUM(Expense_Amount) From Expenses where Username='" + LOGIN.Username + "' and Expense_Type='" + comboBox2.Text + "'";
            SqlCommand cmd_3 = new SqlCommand(Query_3, con);
            SqlDataReader sum_expense = cmd_3.ExecuteReader();
            while (sum_expense.Read())
            {

                label27.Text = sum_expense.GetValue(0).ToString();
            }
            con.Close();
            //Expense Percentage
            con.Open();
            string Query_2 = "Select (Wants) From Budget where Username='" + LOGIN.Username + "' and Budget_Month='" + comboBox1.Text + "'";
            SqlCommand cmd_2 = new SqlCommand(Query_2, con);
            SqlDataReader exp_percent = cmd_2.ExecuteReader();
            while (exp_percent.Read())
            {

                label25.Text = exp_percent.GetValue(0).ToString();
            }
            con.Close();
            //Budget for the month
            int new_total;
            int expense_percent = Convert.ToInt32(label15.Text);
            con.Close();
            int sum_income = Form4.sum_income;
            new_total = (expense_percent * sum_income) / 100;
            label28.Text = new_total.ToString();
            //Percentage spent
            int spent = Convert.ToInt32(label11.Text);
            int p_spent = spent / new_total * 100;
            label26.Text = p_spent.ToString();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Month
            label44.Text = comboBox1.Text;
            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            //Expense total
            con.Open();
            string Query_3 = "Select SUM(Expense_Amount) From Expenses where Username='" + LOGIN.Username + "' and Expense_Type='" + comboBox2.Text + "'";
            SqlCommand cmd_3 = new SqlCommand(Query_3, con);
            SqlDataReader sum_expense = cmd_3.ExecuteReader();
            while (sum_expense.Read())
            {

                label41.Text = sum_expense.GetValue(0).ToString();
            }
            con.Close();
            //Expense Percentage
            con.Open();
            string Query_2 = "Select (Savings) From Budget where Username='" + LOGIN.Username + "' and Budget_Month='" + comboBox1.Text + "'";
            SqlCommand cmd_2 = new SqlCommand(Query_2, con);
            SqlDataReader exp_percent = cmd_2.ExecuteReader();
            while (exp_percent.Read())
            {

                label39.Text = exp_percent.GetValue(0).ToString();
            }
            con.Close();
            //Budget for the month
            int new_total;
            int expense_percent = Convert.ToInt32(label15.Text);
            con.Close();
            int sum_income = Form4.sum_income;
            new_total = (expense_percent * sum_income) / 100;
            label42.Text = new_total.ToString();
            //Percentage spent
            int spent = Convert.ToInt32(label11.Text);
            int p_spent = spent / new_total * 100;
            label40.Text = p_spent.ToString();
        }
    }
}
