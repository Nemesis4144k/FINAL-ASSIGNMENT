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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         String ConnectionString = "Data Source=DESKTOP-P43TIUK\\SQLEXPRESS2024;Initial Catalog=\"final assaigment\";Integrated Security=True;Encrypt=False";
         SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string username = textBox1.Text;
            string email = textBox3.Text; 
            string password = textBox2.Text;
            String Querry = "insert into Users values ('" + username + "','" + email + "','" + password + "')";

            SqlCommand cmd = new SqlCommand(Querry,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered Successfully");

            LOGIN form2 = new LOGIN();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
