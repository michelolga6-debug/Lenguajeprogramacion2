namespace Practica_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

                textBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) ;

            string ruta = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(ruta, textBox1.Text);
            MessageBox.Show("Archivo guardado correctamente en: " + ruta);
        }
    }
}
