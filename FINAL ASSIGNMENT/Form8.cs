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
using System.Windows.Forms.DataVisualization.Charting;

namespace FINAL_ASSIGNMENT
{
    public partial class Progress_tracker : Form
    {
        public Progress_tracker()
        {
            InitializeComponent();
            // Set the title
            chart1.Titles.Clear();

            Title chartTitle = chart1.Titles.Add("Expense Distribution");
            chartTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);        
        }
        SqlConnection con = new SqlConnection("Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False");
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

            //Income
            con.Open();
            string Query_4 = "Select SUM(Income_Amount) From Income where Username='" + LOGIN.Username + "' and year(Income_DateTime)= year(getdate()) and month(Income_DateTime)= month(getdate())";
            SqlCommand cmd_4 = new SqlCommand(Query_4, con);
            SqlDataReader sum_in = cmd_4.ExecuteReader();
            while (sum_in.Read())
            {

                label48.Text = sum_in.GetValue(0).ToString();
            }
            con.Close();
            int sum_income = Convert.ToInt32(label48.Text);

            new_total = (expense_percent * sum_income) / 100;
                label10.Text = new_total.ToString();
            //Percentage spent
            int spent = Convert.ToInt32(label11.Text);
            int p_spent = (spent / new_total) * 100;
            label13.Text = p_spent.ToString();

            //pie chart
            string query = "SELECT Expense_Name, SUM(expense_amount) AS total_amount FROM Expenses where Expense_Type='Fundamental Needs' and year(Expense_DateTime)= year(getdate()) and month(Expense_DateTime)= month(getdate()) GROUP BY Expense_Name ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dtExpenses = new DataTable();
            con.Open();
            adapter.Fill(dtExpenses);

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            Series series = new Series
            {
                Name = "Expenses",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            chart1.Series.Add(series);

            // Add data points to the series
            foreach (DataRow row in dtExpenses.Rows)
            {
                series.Points.AddXY(row["Expense_Name"], row["total_amount"]);
            }
            // Set the series labels font
            series.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            con.Close();

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Month
            label30.Text = comboBox1.Text;
          
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
       
            con.Close();

            //Income
            con.Open();
            string Query_4 = "Select SUM(Income_Amount) From Income where Username='" + LOGIN.Username + "' and year(Income_DateTime)= year(getdate()) and month(Income_DateTime)= month(getdate())";
            SqlCommand cmd_4 = new SqlCommand(Query_4, con);
            SqlDataReader sum_in = cmd_4.ExecuteReader();
            while (sum_in.Read())
            {

                label48.Text = sum_in.GetValue(0).ToString();
            }
            con.Close();

            int new_total;
            int expense_percent = Convert.ToInt32(label25.Text);
            int sum_income = Convert.ToInt32(label48.Text);

            new_total = (expense_percent * sum_income) / 100;
            label28.Text = new_total.ToString();
            //Percentage spent
            int spent = Convert.ToInt32(label27.Text);
            int p_spent = (spent / new_total) * 100;
            label26.Text = p_spent.ToString();

            string query = "SELECT Expense_Name, SUM(expense_amount) AS total_amount FROM Expenses where Expense_Type='Wants' and year(Expense_DateTime)= year(getdate()) and month(Expense_DateTime)= month(getdate()) GROUP BY Expense_Name ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dtExpenses = new DataTable();
            con.Open();
            adapter.Fill(dtExpenses);

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            Series series = new Series
            {
                Name = "Expenses",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            chart1.Series.Add(series);

            // Add data points to the series
            foreach (DataRow row in dtExpenses.Rows)
            {
                series.Points.AddXY(row["Expense_Name"], row["total_amount"]);
            }

            // Set the series labels font
            series.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Month
            label44.Text = comboBox1.Text;
            
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
            int expense_percent = Convert.ToInt32(label39.Text);
            con.Close();

            //Income
            con.Open();
            string Query_4 = "Select SUM(Income_Amount) From Income where Username='" + LOGIN.Username + "' and year(Income_DateTime)= year(getdate()) and month(Income_DateTime)= month(getdate())";
            SqlCommand cmd_4 = new SqlCommand(Query_4, con);
            SqlDataReader sum_in = cmd_4.ExecuteReader();
            while (sum_in.Read())
            {

                label48.Text = sum_in.GetValue(0).ToString();
            }
            con.Close();
            int sum_income = Convert.ToInt32(label48.Text);

            new_total = (expense_percent * sum_income) / 100;
            label42.Text = new_total.ToString();
            //Percentage spent
            int spent = Convert.ToInt32(label41.Text);
            int p_spent = (spent / new_total) * 100;
            label40.Text = p_spent.ToString();

            string query = "SELECT Expense_Name, SUM(expense_amount) AS total_amount FROM Expenses where Expense_Type='Savings' and year(Expense_DateTime)= year(getdate()) and month(Expense_DateTime)= month(getdate()) GROUP BY Expense_Name ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dtExpenses = new DataTable();
            con.Open();
            adapter.Fill(dtExpenses);

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            Series series = new Series
            {
                Name = "Expenses",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            chart1.Series.Add(series);

            // Add data points to the series
            foreach (DataRow row in dtExpenses.Rows)
            {
                series.Points.AddXY(row["Expense_Name"], row["total_amount"]);
            }
            // Set the series labels font
            series.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            con.Close();

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();  
            form4.Show();
            this.Hide();
        }

        private void Label48_Click(object sender, EventArgs e)
        {

        }
    }
}
