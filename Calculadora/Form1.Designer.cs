namespace Calculadora
{
    partial class frmCalculadora
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
            txtResultado = new TextBox();
            btnLimpar = new Button();
            btnApagar = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnSomar = new Button();
            btnIgual = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            lsHistorico = new ListBox();
            btnLimparHistorico = new Button();
            lblHistorico = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Anchor = AnchorStyles.None;
            txtResultado.BackColor = Color.FromArgb(64, 64, 64);
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Font = new Font("Segoe UI", 24F);
            txtResultado.ForeColor = Color.White;
            txtResultado.Location = new Point(15, 159);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(274, 43);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Verdana", 20F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.DarkOrange;
            btnLimpar.Location = new Point(82, 219);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(64, 52);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "c";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Gray;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagar.ForeColor = Color.DarkOrange;
            btnApagar.Location = new Point(152, 219);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(64, 52);
            btnApagar.TabIndex = 2;
            btnApagar.Text = "⌫";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.Gray;
            btnDivisao.FlatStyle = FlatStyle.Popup;
            btnDivisao.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivisao.ForeColor = Color.DarkOrange;
            btnDivisao.Location = new Point(222, 219);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(64, 52);
            btnDivisao.TabIndex = 3;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.Gray;
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Verdana", 13F);
            btnMultiplicacao.ForeColor = Color.DarkOrange;
            btnMultiplicacao.Location = new Point(222, 280);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(64, 52);
            btnMultiplicacao.TabIndex = 4;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.Gray;
            btnSubtracao.FlatStyle = FlatStyle.Popup;
            btnSubtracao.Font = new Font("Verdana", 25F);
            btnSubtracao.ForeColor = Color.DarkOrange;
            btnSubtracao.Location = new Point(222, 345);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(64, 52);
            btnSubtracao.TabIndex = 5;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnSomar
            // 
            btnSomar.BackColor = Color.Gray;
            btnSomar.FlatStyle = FlatStyle.Popup;
            btnSomar.Font = new Font("Verdana", 13F);
            btnSomar.ForeColor = Color.DarkOrange;
            btnSomar.Location = new Point(222, 411);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(64, 52);
            btnSomar.TabIndex = 6;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = false;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.DarkOrange;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Verdana", 20F);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(222, 469);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(64, 52);
            btnIgual.TabIndex = 7;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gray;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(12, 280);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 52);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gray;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(82, 280);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 52);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gray;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(152, 280);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 52);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gray;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(12, 345);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 52);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gray;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(82, 345);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 52);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gray;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(152, 345);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 52);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(12, 412);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 52);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(82, 412);
            btn2.Name = "btn2";
            btn2.Size = new Size(64, 52);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gray;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(152, 412);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 52);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gray;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(82, 471);
            btn0.Name = "btn0";
            btn0.Size = new Size(64, 52);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.Gray;
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(152, 471);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(64, 52);
            btnVirgula.TabIndex = 18;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // lsHistorico
            // 
            lsHistorico.BackColor = Color.FromArgb(64, 64, 64);
            lsHistorico.BorderStyle = BorderStyle.None;
            lsHistorico.Font = new Font("Segoe UI", 11F);
            lsHistorico.ForeColor = Color.Gray;
            lsHistorico.FormattingEnabled = true;
            lsHistorico.Location = new Point(134, 42);
            lsHistorico.Name = "lsHistorico";
            lsHistorico.Size = new Size(155, 120);
            lsHistorico.TabIndex = 19;
            // 
            // btnLimparHistorico
            // 
            btnLimparHistorico.BackColor = Color.Gray;
            btnLimparHistorico.FlatStyle = FlatStyle.Popup;
            btnLimparHistorico.Font = new Font("Verdana", 15F, FontStyle.Bold);
            btnLimparHistorico.ForeColor = Color.DarkOrange;
            btnLimparHistorico.Location = new Point(12, 219);
            btnLimparHistorico.Name = "btnLimparHistorico";
            btnLimparHistorico.Size = new Size(64, 52);
            btnLimparHistorico.TabIndex = 20;
            btnLimparHistorico.Text = "AC";
            btnLimparHistorico.UseVisualStyleBackColor = false;
            btnLimparHistorico.Click += btnLimparHistorico_Click;
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.Font = new Font("Segoe UI", 12F);
            lblHistorico.ForeColor = Color.Silver;
            lblHistorico.Location = new Point(134, 18);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(72, 21);
            lblHistorico.TabIndex = 21;
            lblHistorico.Text = "Histórico";
            lblHistorico.Click += lblHistorico_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(300, 535);
            Controls.Add(lblHistorico);
            Controls.Add(btnLimparHistorico);
            Controls.Add(lsHistorico);
            Controls.Add(btnVirgula);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnIgual);
            Controls.Add(btnSomar);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnApagar);
            Controls.Add(btnLimpar);
            Controls.Add(txtResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += frmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnLimpar;
        private Button btnApagar;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnSomar;
        private Button btnIgual;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnVirgula;
        private ListBox lsHistorico;
        private Button btnLimparHistorico;
        private Label lblHistorico;
    }
}
