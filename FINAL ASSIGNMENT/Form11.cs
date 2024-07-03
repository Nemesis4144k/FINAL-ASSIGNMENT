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
    public partial class Form11 : Form
    {
        public static string Budget_F_needs = "";
        public static string Budget_Wants = "";
        public static string Budget_Savings = "";
        public static string Budget_Month = "";
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=Nemesis\\SQLEXPRESS02;Initial Catalog=\"Finall Assignment\";Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Budget_F_needs= textBox2.Text;
            String Budget_Wants=textBox4.Text;
            String Budget_Savings=textBox5.Text;
            String Budget_Month=comboBox1.Text;

            string Querry = "Insert into Budget values('" + LOGIN.Username + "','"+Budget_Month+"','"+Budget_F_needs+"','"+Budget_Wants+"','" + Budget_Savings + "')";
            SqlCommand cmd = new SqlCommand(Querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Budget Successfully set!");
        }
    }
}
