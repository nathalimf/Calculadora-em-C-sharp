namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        private Operacoes OperacaoSelecionada { get; set; }
        private enum Operacoes
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e) => txtResultado.Text += "0";
        private void btnUm_Click(object sender, EventArgs e) => txtResultado.Text += "1";
        private void btnDois_Click(object sender, EventArgs e) => txtResultado.Text += "2";
        private void btnTres_Click(object sender, EventArgs e) => txtResultado.Text += "3";
        private void btnQuatro_Click(object sender, EventArgs e) => txtResultado.Text += "4";
        private void btnCinco_Click(object sender, EventArgs e) => txtResultado.Text += "5";
        private void btnSeis_Click(object sender, EventArgs e) => txtResultado.Text += "6";
        private void btnSete_Click(object sender, EventArgs e) => txtResultado.Text += "7";
        private void btnOito_Click(object sender, EventArgs e) => txtResultado.Text += "8";
        private void btnNove_Click(object sender, EventArgs e) => txtResultado.Text += "9";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacoes.Adicao;
            Valor = decimal.TryParse(txtResultado.Text, out decimal v) ? v : 0;
            txtResultado.Text = "";
            lblOperacao.Text = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text) || txtResultado.Text == "0")
            {
                if (txtResultado.Text.StartsWith("-"))
                    txtResultado.Text = txtResultado.Text.TrimStart('-');
                else
                    txtResultado.Text = "-";
                return;
            }

            if (txtResultado.Text == "-")
            {
                return;
            }

            OperacaoSelecionada = Operacoes.Subtracao;
            Valor = decimal.TryParse(txtResultado.Text, out decimal vv) ? vv : 0;
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacoes.Multiplicacao;
            Valor = decimal.TryParse(txtResultado.Text, out decimal v) ? v : 0;
            txtResultado.Text = "";
            lblOperacao.Text = "X";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacoes.Divisao;
            Valor = decimal.TryParse(txtResultado.Text, out decimal v) ? v : 0;
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal segundoValor = decimal.TryParse(txtResultado.Text, out decimal v) ? v : 0;

            switch (OperacaoSelecionada)
            {
                case Operacoes.Adicao:
                    Resultado = Valor + segundoValor;
                    break;

                case Operacoes.Subtracao:
                    Resultado = Valor - segundoValor;
                    break;

                case Operacoes.Multiplicacao:
                    Resultado = Valor * segundoValor;
                    break;

                case Operacoes.Divisao:
                    if (segundoValor == 0)
                    {
                        MessageBox.Show("Erro: divisão por zero!");
                        return;
                    }
                    Resultado = Valor / segundoValor;
                    break;

                default:
                    Resultado = segundoValor;
                    break;
            }

            txtResultado.Text = Resultado.ToString();
            lblOperacao.Text = "=";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void C_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
                return;

            if (txtResultado.Text.Length == 1)
            {
                txtResultado.Text = "";
                return;
            }

            txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            if (lblOperacao.Text == "=")
                lblOperacao.Text = "";
        }
    }
}
