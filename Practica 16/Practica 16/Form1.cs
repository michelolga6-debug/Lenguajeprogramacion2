namespace Practica_16
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        string operacion = "";
        bool operadorPresionado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "6";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "4";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "7";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "0";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtpantalla.Text);
            operacion = "-";
            operadorPresionado = true;
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtpantalla.Text);
            operacion = "/";
            operadorPresionado = true;
        }

        private void btnmultipicacion_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtpantalla.Text);
            operacion = "+";
            operadorPresionado = true;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "5";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0" || operadorPresionado) txtpantalla.Clear();
            operadorPresionado = false;
            txtpantalla.Text += "8";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {


            double valor2 = double.Parse(txtpantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = valor1 + valor2; break;
                case "-": resultado = valor1 - valor2; break;
                case "*": resultado = valor1 * valor2; break;
                case "/": resultado = valor1 / valor2; break;
            }
            txtpantalla.Text = resultado.ToString();
            operadorPresionado = true;
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtpantalla.Text);
            operacion = "+";
            operadorPresionado = true;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = "0";
            valor1 = 0;
           
            operacion = "";
            operadorPresionado = false;
        }
    }
}
