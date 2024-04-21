namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private double average = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    average = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text)) / 3;
                    label6.Text = average.ToString();
                }
                else { return; }
            }
            catch (Exception)
            {

                label6.Text = "Invalid Input.";
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
