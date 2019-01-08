using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        private object lblAnswer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox1.Text);
                double R2 = Convert.ToDouble(textBox2.Text);
                double R3 = Convert.ToDouble(textBox3.Text);
                double R4 = Convert.ToDouble(textBox4.Text);

                double ans = R1 + R2 + R3 + R4;

                label4.Text = "answer =" + ans.ToString("0.00");

            }
            catch
            {
                label4.Text = "answer =";
            }
        }
    }
}
