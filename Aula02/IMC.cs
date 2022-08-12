namespace Aula02
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Calculadora de IMC";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);

           var(descricaoIMC, resultadoIMC) = CalcularIMC(peso, altura / 100);
            lblResultado.Text = $"{descricaoIMC}\n{resultadoIMC}";
        }
        private (string, double) CalcularIMC(double peso, double altura)
        {
            double imc = peso / (altura * altura);

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };
            return (resultado, imc);
         



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = String.Empty;
            lblResultado.Text = String.Empty;

            txtPeso.Focus();
        }
    }
}