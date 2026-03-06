namespace Termostado
{
    partial class frmTermostado
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
            colorDialog1 = new ColorDialog();
            lblTemperatura = new Label();
            lblTempPadrao = new Label();
            btnAumentar = new Button();
            btnDiminuir = new Button();
            btnReset = new Button();
            pbTemperatura = new ProgressBar();
            updTemperaturaPadrao = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)updTemperaturaPadrao).BeginInit();
            SuspendLayout();
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemperatura.ForeColor = Color.Black;
            lblTemperatura.Location = new Point(215, 120);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(335, 47);
            lblTemperatura.TabIndex = 0;
            lblTemperatura.Text = "Temperatura: 23 °C";
            // 
            // lblTempPadrao
            // 
            lblTempPadrao.AutoSize = true;
            lblTempPadrao.Font = new Font("Segoe UI", 14F);
            lblTempPadrao.Location = new Point(52, 346);
            lblTempPadrao.Name = "lblTempPadrao";
            lblTempPadrao.Size = new Size(125, 25);
            lblTempPadrao.TabIndex = 1;
            lblTempPadrao.Text = "Temp. Padrão";
            // 
            // btnAumentar
            // 
            btnAumentar.Font = new Font("Segoe UI", 16F);
            btnAumentar.Location = new Point(547, 224);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.Size = new Size(110, 39);
            btnAumentar.TabIndex = 2;
            btnAumentar.Text = "+";
            btnAumentar.UseVisualStyleBackColor = true;
            btnAumentar.Click += btnAumentar_Click;
            // 
            // btnDiminuir
            // 
            btnDiminuir.Font = new Font("Segoe UI", 16F);
            btnDiminuir.Location = new Point(431, 224);
            btnDiminuir.Name = "btnDiminuir";
            btnDiminuir.Size = new Size(110, 39);
            btnDiminuir.TabIndex = 3;
            btnDiminuir.Text = "-";
            btnDiminuir.UseVisualStyleBackColor = true;
            btnDiminuir.Click += btnDiminuir_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 13F);
            btnReset.Location = new Point(139, 224);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 39);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // pbTemperatura
            // 
            pbTemperatura.Location = new Point(139, 182);
            pbTemperatura.Maximum = 40;
            pbTemperatura.Name = "pbTemperatura";
            pbTemperatura.Size = new Size(518, 36);
            pbTemperatura.TabIndex = 5;
            pbTemperatura.Value = 23;
            // 
            // updTemperaturaPadrao
            // 
            updTemperaturaPadrao.Location = new Point(52, 377);
            updTemperaturaPadrao.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            updTemperaturaPadrao.Name = "updTemperaturaPadrao";
            updTemperaturaPadrao.Size = new Size(129, 23);
            updTemperaturaPadrao.TabIndex = 6;
            updTemperaturaPadrao.Value = new decimal(new int[] { 23, 0, 0, 0 });
            // 
            // frmTermostado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1adce85c51bff21f16b524d8bc7d4ef0;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(updTemperaturaPadrao);
            Controls.Add(pbTemperatura);
            Controls.Add(btnReset);
            Controls.Add(btnDiminuir);
            Controls.Add(btnAumentar);
            Controls.Add(lblTempPadrao);
            Controls.Add(lblTemperatura);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTermostado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Termostado";
            ((System.ComponentModel.ISupportInitialize)updTemperaturaPadrao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Label lblTemperatura;
        private Label lblTempPadrao;
        private Button btnAumentar;
        private Button btnDiminuir;
        private Button btnReset;
        private ProgressBar pbTemperatura;
        private NumericUpDown updTemperaturaPadrao;
    }
}
