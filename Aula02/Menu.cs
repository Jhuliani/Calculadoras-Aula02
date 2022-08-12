

namespace Aula02
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMenuImc_Click(object sender, EventArgs e)
        {
            this.Hide();
            IMC imc = new IMC();
            imc.ShowDialog();
            this.Show();
        }

        private void btnMenuCalNor_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculadoraNormal imc = new CalculadoraNormal();
            imc.ShowDialog();
            this.Show();
        }
    }
}
