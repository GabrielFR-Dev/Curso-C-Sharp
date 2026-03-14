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
            btnDividir = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnSomar = new Button();
            btnIgual = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Anchor = AnchorStyles.None;
            txtResultado.BackColor = Color.FromArgb(64, 64, 64);
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Font = new Font("Segoe UI", 24F);
            txtResultado.ForeColor = Color.White;
            txtResultado.Location = new Point(13, 154);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(256, 43);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.None;
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.DarkOrange;
            btnLimpar.Location = new Point(13, 219);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 51);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Anchor = AnchorStyles.None;
            btnApagar.BackColor = Color.Gray;
            btnApagar.FlatStyle = FlatStyle.Popup;
            btnApagar.Font = new Font("Verdana", 20F, FontStyle.Bold);
            btnApagar.ForeColor = Color.DarkOrange;
            btnApagar.Location = new Point(79, 219);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(56, 51);
            btnApagar.TabIndex = 2;
            btnApagar.Text = "⌫";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnDividir
            // 
            btnDividir.Anchor = AnchorStyles.None;
            btnDividir.BackColor = Color.Gray;
            btnDividir.FlatStyle = FlatStyle.Popup;
            btnDividir.Font = new Font("Verdana", 18F);
            btnDividir.ForeColor = Color.DarkOrange;
            btnDividir.Location = new Point(144, 219);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(56, 51);
            btnDividir.TabIndex = 3;
            btnDividir.Text = " ÷";
            btnDividir.TextAlign = ContentAlignment.MiddleLeft;
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Anchor = AnchorStyles.None;
            btnMultiplicacao.BackColor = Color.Gray;
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Verdana", 15F);
            btnMultiplicacao.ForeColor = Color.DarkOrange;
            btnMultiplicacao.Location = new Point(213, 220);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(56, 51);
            btnMultiplicacao.TabIndex = 4;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            
            // 
            // btnSubtracao
            // 
            btnSubtracao.Anchor = AnchorStyles.None;
            btnSubtracao.BackColor = Color.Gray;
            btnSubtracao.FlatStyle = FlatStyle.Popup;
            btnSubtracao.Font = new Font("Verdana", 25F);
            btnSubtracao.ForeColor = Color.DarkOrange;
            btnSubtracao.Location = new Point(213, 282);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(56, 51);
            btnSubtracao.TabIndex = 5;
            btnSubtracao.Text = "-";
            btnSubtracao.TextAlign = ContentAlignment.TopCenter;
            btnSubtracao.UseVisualStyleBackColor = false;
            // 
            // btnSomar
            // 
            btnSomar.Anchor = AnchorStyles.None;
            btnSomar.BackColor = Color.Gray;
            btnSomar.FlatStyle = FlatStyle.Popup;
            btnSomar.Font = new Font("Verdana", 20F);
            btnSomar.ForeColor = Color.DarkOrange;
            btnSomar.Location = new Point(213, 342);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(56, 51);
            btnSomar.TabIndex = 6;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = false;
            // 
            // btnIgual
            // 
            btnIgual.Anchor = AnchorStyles.None;
            btnIgual.BackColor = Color.Gray;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Verdana", 20F);
            btnIgual.ForeColor = Color.DarkOrange;
            btnIgual.Location = new Point(213, 399);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(56, 51);
            btnIgual.TabIndex = 7;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.None;
            btn7.BackColor = Color.Gray;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Verdana", 18F);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(13, 282);
            btn7.Name = "btn7";
            btn7.Size = new Size(56, 51);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Anchor = AnchorStyles.None;
            btn8.BackColor = Color.Gray;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Verdana", 18F);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(79, 282);
            btn8.Name = "btn8";
            btn8.Size = new Size(56, 51);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.None;
            btn9.BackColor = Color.Gray;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Verdana", 18F);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(144, 282);
            btn9.Name = "btn9";
            btn9.Size = new Size(56, 51);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.None;
            btn4.BackColor = Color.Gray;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Verdana", 18F);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(13, 341);
            btn4.Name = "btn4";
            btn4.Size = new Size(56, 51);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.None;
            btn5.BackColor = Color.Gray;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Verdana", 18F);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(79, 342);
            btn5.Name = "btn5";
            btn5.Size = new Size(56, 51);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.None;
            btn6.BackColor = Color.Gray;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Verdana", 18F);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(144, 341);
            btn6.Name = "btn6";
            btn6.Size = new Size(56, 51);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.None;
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Verdana", 18F);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(12, 398);
            btn1.Name = "btn1";
            btn1.Size = new Size(56, 51);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.None;
            btn2.BackColor = Color.Gray;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Verdana", 18F);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(79, 398);
            btn2.Name = "btn2";
            btn2.Size = new Size(56, 51);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.None;
            btn3.BackColor = Color.Gray;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Verdana", 18F);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(144, 398);
            btn3.Name = "btn3";
            btn3.Size = new Size(56, 51);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Anchor = AnchorStyles.None;
            btn0.BackColor = Color.Gray;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Verdana", 18F);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(79, 455);
            btn0.Name = "btn0";
            btn0.Size = new Size(56, 51);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Anchor = AnchorStyles.None;
            btnVirgula.BackColor = Color.Gray;
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Verdana", 18F);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(144, 455);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(56, 51);
            btnVirgula.TabIndex = 18;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(281, 539);
            Controls.Add(btnVirgula);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnIgual);
            Controls.Add(btnSomar);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDividir);
            Controls.Add(btnApagar);
            Controls.Add(btnLimpar);
            Controls.Add(txtResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnLimpar;
        private Button btnApagar;
        private Button btnDividir;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnSomar;
        private Button btnIgual;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnVirgula;
    }
}
