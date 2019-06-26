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
        private const string Format = "0.000";
        private object lblAnswer;
        private object label13_Click_1;

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
            //series resistor, it calculates the total series resistace R1+R2+R3+R4
            double R1, R2, R3, R4, ans;
            try

            {
                R1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                R1 = 0;
            }

            try

            {
                R2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                R2 = 0;
            }

            try

            {
                R3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R3 = 0;
            }
            try

            {
                R4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R4 = 0;
            }

            ans = R1 + R2 + R3 + R4;

            label4.Text = "answer =" + ans.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //parallel resistor, it calculates the total parallel resistance 1.0 / (1.0 / R1 + 1.0 / R2 + 1.0 / R3 + 1.0 / R4)
            double R1, R2, R3, R4, ans;
            try

            {
                R1 = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                R1 = double.PositiveInfinity;
            }
            try

            {
                R2 = Convert.ToDouble(textBox7.Text);
            }
            catch
            {
                R2 = double.PositiveInfinity;
            }
            try

            {
                R3 = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                R3 = double.PositiveInfinity;
            }
            try

            {
                R4 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R4 = double.PositiveInfinity;
            }

            ans = 1.0 / (1.0 / R1 + 1.0 / R2 + 1.0 / R3 + 1.0 / R4);

            label3.Text = "answer =" + ans.ToString(Format);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textBox10.Text);

                double ans = 2 * 3.1415 * R1;

                label6.Text = "answer =" + ans.ToString("0.00");

            }
            catch
            {
                label6.Text = "answer =";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(textbox11.Text);
                double R2 = Convert.ToDouble(textBox12.Text);

                double ans = R1 * R1 + R2 * R2;

                label9.Text = "C = answer =" + ans.ToString(Format);

            }
            catch
            {
                label9.Text = "C = answer =";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_2(object sender, EventArgs e)
        {

        }
    }
}