namespace Practica_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = double.Parse(textBox1.Text);
            double fahrenheit = (celsius * 9 / 5) + 32;
            label1.Text = fahrenheit + " °F";
        }
    }
}
