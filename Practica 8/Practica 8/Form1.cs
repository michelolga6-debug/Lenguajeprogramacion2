namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int conteo = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            conteo++;
            label1.Text = "Veces presionado: " + conteo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
