using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_ASSIGNMENT
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN newform = new LOGIN();
            newform.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LOGIN newform = new LOGIN();
            newform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up newform = new Sign_up();
            newform.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
