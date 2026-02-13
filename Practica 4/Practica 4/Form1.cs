namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int resultado = numero1 + numero2;
            label1.Text = "El resultado es : " + resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
