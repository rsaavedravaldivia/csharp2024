namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private decimal average = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {




            if (decimal.TryParse(textBox1.Text, out decimal num1))
            {
            }
            else
            {
                MessageBox.Show("Non-numeric value for first number.");
                return;
            }

            if (decimal.TryParse(textBox2.Text, out decimal num2)) { }
            else
            {
                MessageBox.Show("Non-numeric value for second number.");
                return;
            }
            if (decimal.TryParse(textBox3.Text, out decimal num3)) { }
            else
            {
                MessageBox.Show("Non-numeric value for third number.");
                return;

            }

            average = (num1 + num2 + num3) / 3;
            label6.Text = average.ToString();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
