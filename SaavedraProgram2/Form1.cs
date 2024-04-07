using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double average = (firstNumber + secondNumber + thirdNumber) / 3;

            label6.Text = Math.Round(average, 3).ToString();

        }
        public double firstNumber;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBox1.Text);

        }

        public double secondNumber;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            secondNumber = Double.Parse(textBox2.Text);
        }

        public double thirdNumber;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            thirdNumber = Double.Parse(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
