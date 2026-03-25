namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        string operacao;
        double numero1, numero2;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "0";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {

            txtResultado.Text += ",";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "3"; ;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "4";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += "9";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            operacao = "/";
            txtResultado.Clear();

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            operacao = "*";
            txtResultado.Clear();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            operacao = "-";
            txtResultado.Clear();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            operacao = "+";
            txtResultado.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);
            double resultado = 0;
            string operacaoHistorico = "";

            if (operacao == "+")
            {
                resultado = numero1 + numero2;
                operacaoHistorico = "+";
            }
            else if (operacao == "-")
            {
                resultado = numero1 - numero2;
                operacaoHistorico = "-";
            }
            else if (operacao == "*")
            {
                resultado = numero1 * numero2;
                operacaoHistorico = "x";
            }
            else if (operacao == "/")
            {
                if (numero2 == 0)
                {
                    txtResultado.Text = "null";
                    lsHistorico.Items.Add("null (Divisão por zero)");
                    return;
                }

                resultado = numero1 / numero2;
                operacaoHistorico = "÷";
            }

            txtResultado.Text = resultado.ToString();

            lsHistorico.Items.Add($"{numero1} {operacaoHistorico} {numero2} = {resultado}");



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            lsHistorico.Items.Clear();
            txtResultado.Text = "0";
        }

        private void lblHistorico_Click(object sender, EventArgs e)
        {

        }
    }
}
