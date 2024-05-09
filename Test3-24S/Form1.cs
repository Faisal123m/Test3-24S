using System.Diagnostics.CodeAnalysis;

namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = int.Parse(textBox1.Text);
            sum = sum + int.Parse(textBox2.Text);
            textBox2.Text = sum.ToString();
            double count = 1;
            count = count + int.Parse(textBox3.Text);
            textBox3.Text = (count).ToString();
            Double avrage = sum / count;
            textBox4.Text = avrage.ToString();




        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
