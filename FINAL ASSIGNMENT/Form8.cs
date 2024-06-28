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
    public partial class Progress_tracker : Form
    {
        public Progress_tracker()
        {
            InitializeComponent();
            chart1.Titles.Add("Expenses");

            chart1.Series["s1"].Points.AddXY("Food", "50");
            chart1.Series["s1"].Points.AddXY("Education", "67");
            chart1.Series["s1"].Points.AddXY("Transportation", "120");
            chart1.Series["s1"].Points.AddXY("Utilities", "90");
            chart1.Series["s1"].Points.AddXY("Phonebill", "20");


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
    }
}
