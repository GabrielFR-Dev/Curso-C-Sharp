namespace Termostado
{
    public partial class frmTermostado : Form
    {
        private int temperatura = 23;
        public frmTermostado()
        {
            InitializeComponent();

        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
           if (temperatura < pbTemperatura.Maximum)
            {
                temperatura = temperatura + 1;
                pbTemperatura.Value = temperatura;
                lblTemperatura.Text = "Temperatura: " + temperatura + "°C";
            }
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
           if(temperatura > pbTemperatura.Minimum)
            {
                temperatura = temperatura - 1;
                pbTemperatura.Value = temperatura;
                lblTemperatura.Text = "Temperatura: " + temperatura + "°C";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            temperatura = Convert.ToInt16(updTemperaturaPadrao.Value);

            pbTemperatura.Value = temperatura;
            lblTemperatura.Text = "Temperatura: " + temperatura + "°C";
        }
    }
}
