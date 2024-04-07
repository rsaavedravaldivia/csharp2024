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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        float result;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                result = (values[0] + values[1] + values[2]) / 3;
            }

            else if (radioButton2.Checked)
            {
                result = values.Max();
            }

            else if (radioButton3.Checked)
            {
                result = values.Min();
            }

            label6.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        float[] values = new float[3];

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            values[0] = float.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            values[1] = float.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            values[2] = float.Parse(textBox3.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
