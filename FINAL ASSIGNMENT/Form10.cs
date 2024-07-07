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
    public partial class Previous_Transactions : Form
    {
        public Previous_Transactions()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P43TIUK\\SQLEXPRESS2024;Initial Catalog=\"final assaigment\";Integrated Security=True;Encrypt=False");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
          

            con.Open();
            string Query_1 = "select * from Income where Username='" + LOGIN.Username + "'";

            SqlCommand cmd_1 = new SqlCommand(Query_1, con);
            var reader_1 = cmd_1.ExecuteReader();

            DataTable dataTable_1 = new DataTable();
            dataTable_1.Load(reader_1);

            dataGridView1.DataSource = dataTable_1;
            cmd_1.ExecuteNonQuery();

            string Query_2 = "select * from Expenses where Username='" + LOGIN.Username + "'";

            SqlCommand cmd_2 = new SqlCommand(Query_2, con);
            var reader_2 = cmd_2.ExecuteReader();

            DataTable dataTable_2 = new DataTable();
            dataTable_2.Load(reader_2);

            dataGridView2.DataSource = dataTable_2;
            cmd_2.ExecuteNonQuery();
            con.Close();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Home form4 = new Home();
            form4.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            

            con.Open();
            string Query = "delete from Expenses Where Expense_ID='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense Deleted Successfully!");


        }

        private void Button1_Click(object sender, EventArgs e)
        {
       

            con.Open();
            string Query = "delete from Income Where Income_ID='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Income Deleted Successfully!");
        }
    }
}
