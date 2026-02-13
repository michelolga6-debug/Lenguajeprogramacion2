namespace Practica_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Es un número válido.");
            }
            else
            {
                MessageBox.Show("Error: Ingrese solo números.");
            }
        }
    }
}
