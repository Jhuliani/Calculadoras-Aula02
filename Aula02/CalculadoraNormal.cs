using System.Globalization;

namespace Aula02
{
    public partial class CalculadoraNormal : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public CalculadoraNormal()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            if(operacao == "Soma")
            {
               txtResult.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "Sub")
            {
               txtResult.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "Mult")
            {
                txtResult.Text = Convert.ToString(valor1 * valor2);
            }
            else 
            {
                txtResult.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void btnSubc_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            txtResult.Text = "";
            operacao = "Sub";
            lblOperacao.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            txtResult.Text = "";
            operacao = "Mult";
            lblOperacao.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            txtResult.Text = "";
            operacao = "Div";
            lblOperacao.Text = "/";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnAdic_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            txtResult.Text = "";
            operacao = "Soma";
            lblOperacao.Text = "+";

        }
    }
}
