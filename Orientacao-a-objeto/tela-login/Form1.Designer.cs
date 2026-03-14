namespace tela_login
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelSenha = new Panel();
            panelUsuario = new Panel();
            chcMostrarSenha = new CheckBox();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panelSenha);
            panel1.Controls.Add(panelUsuario);
            panel1.Controls.Add(chcMostrarSenha);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(lblUsuario);
            panel1.Location = new Point(148, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 571);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panelSenha
            // 
            panelSenha.BackColor = Color.Black;
            panelSenha.BorderStyle = BorderStyle.FixedSingle;
            panelSenha.Location = new Point(37, 322);
            panelSenha.Name = "panelSenha";
            panelSenha.Size = new Size(250, 2);
            panelSenha.TabIndex = 7;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.White;
            panelUsuario.BorderStyle = BorderStyle.FixedSingle;
            panelUsuario.Location = new Point(37, 234);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(250, 2);
            panelUsuario.TabIndex = 6;
            panelUsuario.Paint += panelUsuario_Paint;
            // 
            // chcMostrarSenha
            // 
            chcMostrarSenha.AutoSize = true;
            chcMostrarSenha.Location = new Point(196, 332);
            chcMostrarSenha.Name = "chcMostrarSenha";
            chcMostrarSenha.Size = new Size(101, 19);
            chcMostrarSenha.TabIndex = 5;
            chcMostrarSenha.Text = "Mostrar senha";
            chcMostrarSenha.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(73, 393);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(175, 47);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(37, 298);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(250, 22);
            txtSenha.TabIndex = 3;
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 10F);
            lblSenha.Location = new Point(37, 272);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 19);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(37, 210);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 22);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F);
            lblUsuario.Location = new Point(37, 184);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundoLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(613, 797);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaveSystem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chcMostrarSenha;
        private Button btnEntrar;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Panel panelUsuario;
        private Panel panelSenha;
    }
}
