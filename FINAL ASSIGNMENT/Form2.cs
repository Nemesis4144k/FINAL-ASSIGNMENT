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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=Nemesis\SQLEXPRESS02;Initial Catalog=""Final Assignment"";Integrated Security=True;Encrypt=False");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      

            String Username, user_password;
            Username = textBox1.Text;
            user_password = textBox2.Text;
            try
            {
                String Querry = "Select*From Users Where Customer_Name = '" + Username + "' AND Customer_Password '" + user_password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Querry, Conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count>0)
                {
                    Username = textBox1.Text;
                    user_password = textBox2.Text;

                    // to go to dashboard
                    Form4 form4= new Form4();
                    form4.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login Details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    //to focus username
                    textBox1.Focus();   
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                Conn.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
