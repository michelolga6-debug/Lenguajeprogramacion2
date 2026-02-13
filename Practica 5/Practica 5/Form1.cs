namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Usted seleccionó la Opción 1";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Usted seleccionó la Opción 2";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Usted seleccionó la Opción 3";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
