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
    public partial class Form13 : Form
    {
        private decimal goalFinalAmount;
        private decimal goalCurrentAmount;
        public Form13()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False");
        private void Form13_Load(object sender, EventArgs e)
        {

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {             
                con.Open();

                string query = "SELECT Goal_Name,Goal_Start_DateTime,Goal_Current_Amount,Goal_Total_Amount,Goal_End_Date FROM goals Where Goal_ID='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    label1.Text = reader["Goal_Name"].ToString();
                    label4.Text = reader["Goal_Start_DateTime"].ToString();
                    label7.Text = reader["Goal_End_Date"].ToString();
                    label9.Text = reader["Goal_Current_Amount"].ToString();
                    label8.Text = reader["Goal_Total_Amount"].ToString();
                    goalFinalAmount = (decimal)reader["Goal_Total_Amount"];
                    goalCurrentAmount = (decimal)reader["Goal_Current_Amount"];
                }
                reader.Close();

                // Calculate the progress percentage
                int progressPercentage = (int)((goalCurrentAmount / goalFinalAmount) * 100);

                // Update the ProgressBar value
                progressBar1.Value = progressPercentage;

                goalCurrentAmount += 100;
                if (goalCurrentAmount > goalFinalAmount)
                {
                    goalCurrentAmount = goalFinalAmount;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Goal ID!");
            }

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
                   
            con.Open();
            string Query_1 = "select * from Goals where Username='" + LOGIN.Username + "'";

            SqlCommand cmd_1 = new SqlCommand(Query_1, con);
            var reader_1 = cmd_1.ExecuteReader();

            DataTable dataTable_1 = new DataTable();
            dataTable_1.Load(reader_1);

            dataGridView2.DataSource = dataTable_1;
            cmd_1.ExecuteNonQuery();


            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {              
                con.Open();
                string query = "UPDATE Goals SET Goal_Current_Amount = '" + textBox2.Text + "' WHERE Goal_ID = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated!");
            }
            else
            {
                MessageBox.Show("Please Enter Goal ID and Current Goal Amount!");
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {        
                con.Open();
                string Query = "delete from Goals Where Goal_ID='" + textBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Goal Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please Enter Goal ID!");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "Insert into Goals values('" + LOGIN.Username + "','"+textBox4.Text+"',SYSDATETIME(),'"+textBox5.Text+"','"+textBox7.Text+"','" +textBox6.Text+"')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Goal Successfully added!");
           
        }
    }
}
