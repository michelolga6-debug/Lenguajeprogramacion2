namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (comboBox1.Text == "Verde")
            {
                this.BackColor = Color.Green;
            }
            else if (comboBox1.Text == "Azul")
            {
                this.BackColor = Color.Blue;
            }
        }
    }
}
