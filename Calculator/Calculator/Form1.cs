using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string action;
        public string number1;
        public bool number2;
        public Form1()
        {
            InitializeComponent();
            number2 = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cureitecran_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number2)
            {
                number2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void egal_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(number1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (action == "+")
            {
                res = dn1 + dn2;
            }
            if (action == "-")
            {
                res = dn1 - dn2;
            }
            if (action == "X")
            {
                res = dn1 * dn2;
            }
            if (action == "/")
            {
                res = dn1 / dn2;
            }
            if (action == "%")
            {
                res = dn1 * dn2 / 100;
            }
            action = "=";
            number2 = true;
            textBox1.Text = res.ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            number1 = textBox1.Text;
            number2 = true;
        }

        private void pozitvnegativ_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void punct_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void delastnum_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            number1 = textBox1.Text;
            number2 = true;
        }
    }
}
