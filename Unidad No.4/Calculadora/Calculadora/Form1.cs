namespace Calculadora
{
    public partial class Form1 : Form
    {
        private enum Entrada
        {
            NINGUNA,
            DIGITO,
            OPERADOR,
            CE
        }

        private Entrada ultimaEntrada;
        private bool comaDecimal;
        private char operador;
        private byte numOperandos;
        private double operando1;
        private double operando2;

        public Form1()
        {
            InitializeComponent();
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            numOperandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private void DigitaClick(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaEntrada != Entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                textBox1.Text = "";
                ultimaEntrada = Entrada.DIGITO;
                comaDecimal = false;
            }
            textBox1.Text += objButton.Text;
        }

        private void OperacionClick(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            string textoBoton = objButton.Text;

            if (numOperandos == 0 && textoBoton[0] == '-')
                ultimaEntrada = Entrada.DIGITO;

            if (ultimaEntrada == Entrada.DIGITO)
                numOperandos += 1;

            if (numOperandos == 1)
                operando1 = double.Parse(textBox1.Text);
            else if (numOperandos == 2)
            {
                operando2 = double.Parse(textBox1.Text);
                switch (operador)
                {
                    case '+': operando1 += operando2; break;
                    case '-': operando1 -= operando2; break;
                    case '*': operando1 *= operando2; break;
                    case '/': operando1 /= operando2; break;
                    case '=': operando1 = operando2; break;
                }
                textBox1.Text = operando1.ToString();
                numOperandos = 1;
            }
            operador = textoBoton[0];
            ultimaEntrada = Entrada.OPERADOR;
        }

        private void btn0_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn1_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn2_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn3_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn4_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn5_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn6_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn7_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn8_Click(object sender, EventArgs e) => DigitaClick(sender, e);
        private void btn9_Click(object sender, EventArgs e) => DigitaClick(sender, e);

        private void btnMas_Click(object sender, EventArgs e) => OperacionClick(sender, e);
        private void btnMen_Click(object sender, EventArgs e) => OperacionClick(sender, e);
        private void btnMulti_Click(object sender, EventArgs e) => OperacionClick(sender, e);
        private void btnDiv_Click(object sender, EventArgs e) => OperacionClick(sender, e);
        private void btnIgual_Click(object sender, EventArgs e) => OperacionClick(sender, e);

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (ultimaEntrada != Entrada.DIGITO)
            {
                textBox1.Text = "0.";
                ultimaEntrada = Entrada.DIGITO;
            }
            else if (comaDecimal == false)
                textBox1.Text = textBox1.Text + ".";
            comaDecimal = true;
        }

        private void btnPorce_Click(object sender, EventArgs e)
        {
            double resultado;
            if (ultimaEntrada == Entrada.DIGITO)
            {
                resultado = operando1 * double.Parse(textBox1.Text) / 100;
                textBox1.Text = resultado.ToString();
                btnIgual.PerformClick();
                btnPorce.Focus();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.";
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            numOperandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.";
            ultimaEntrada = Entrada.CE;
            comaDecimal = false;
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
