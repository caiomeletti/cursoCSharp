namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            if (!int.TryParse(txtPrimeiroNum.Text, out int primeiroNum)) 
            {
                lblResultado.Text = "Insira um número inteiro!";
                return;
            }
            if (!int.TryParse(txtSegundoNum.Text, out int segundoNum))
            {
                lblResultado.Text = "Insira um número inteiro!";
                return;
            }

            lblResultado.Text = "O resultado é " + (primeiroNum + segundoNum);
        }
    }
}