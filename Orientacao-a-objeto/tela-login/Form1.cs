namespace tela_login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void panelUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Entrou no campo de usuário");
            panelUsuario.BackColor = Color.Red;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            panelUsuario.BackColor = Color.Gray;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            panelSenha.BackColor = Color.Blue;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            panelSenha.BackColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
