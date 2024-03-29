namespace PesoBal
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlRodape = new Panel();
            label1 = new Label();
            LblDev = new Label();
            BtnEtiquetaPeso = new Button();
            BtnConfig = new Button();
            BtnSair = new Button();
            BtnEtiquetaValor = new Button();
            BtnProdutos = new Button();
            PnlRodape.SuspendLayout();
            SuspendLayout();
            // 
            // PnlRodape
            // 
            PnlRodape.BackColor = Color.FromArgb(224, 224, 224);
            PnlRodape.Controls.Add(label1);
            PnlRodape.Controls.Add(LblDev);
            PnlRodape.Dock = DockStyle.Bottom;
            PnlRodape.Location = new Point(0, 236);
            PnlRodape.Name = "PnlRodape";
            PnlRodape.Size = new Size(234, 28);
            PnlRodape.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 7);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 1;
            label1.Text = "2024 v1.0";
            // 
            // LblDev
            // 
            LblDev.AutoSize = true;
            LblDev.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDev.ForeColor = Color.FromArgb(255, 128, 0);
            LblDev.Location = new Point(5, 3);
            LblDev.Name = "LblDev";
            LblDev.Size = new Size(56, 23);
            LblDev.TabIndex = 0;
            LblDev.Text = "Willian";
            // 
            // BtnEtiquetaPeso
            // 
            BtnEtiquetaPeso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnEtiquetaPeso.Location = new Point(12, 8);
            BtnEtiquetaPeso.Name = "BtnEtiquetaPeso";
            BtnEtiquetaPeso.Size = new Size(210, 40);
            BtnEtiquetaPeso.TabIndex = 2;
            BtnEtiquetaPeso.Text = "Etiqueta com Peso";
            BtnEtiquetaPeso.UseVisualStyleBackColor = true;
            BtnEtiquetaPeso.Click += BtnIniciarContagem_Click;
            // 
            // BtnConfig
            // 
            BtnConfig.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnConfig.Location = new Point(12, 146);
            BtnConfig.Name = "BtnConfig";
            BtnConfig.Size = new Size(210, 40);
            BtnConfig.TabIndex = 4;
            BtnConfig.Text = "Configuração";
            BtnConfig.UseVisualStyleBackColor = true;
            BtnConfig.Click += BtnConfig_Click;
            // 
            // BtnSair
            // 
            BtnSair.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnSair.Location = new Point(12, 192);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(210, 40);
            BtnSair.TabIndex = 5;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // BtnEtiquetaValor
            // 
            BtnEtiquetaValor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnEtiquetaValor.Location = new Point(12, 54);
            BtnEtiquetaValor.Name = "BtnEtiquetaValor";
            BtnEtiquetaValor.Size = new Size(210, 40);
            BtnEtiquetaValor.TabIndex = 6;
            BtnEtiquetaValor.Text = "Etiqueta com Valor";
            BtnEtiquetaValor.UseVisualStyleBackColor = true;
            BtnEtiquetaValor.Click += BtnEtiquetaValor_Click;
            // 
            // BtnProdutos
            // 
            BtnProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnProdutos.Location = new Point(12, 100);
            BtnProdutos.Name = "BtnProdutos";
            BtnProdutos.Size = new Size(210, 40);
            BtnProdutos.TabIndex = 7;
            BtnProdutos.Text = "Produto";
            BtnProdutos.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 264);
            Controls.Add(BtnProdutos);
            Controls.Add(BtnEtiquetaValor);
            Controls.Add(BtnSair);
            Controls.Add(BtnConfig);
            Controls.Add(BtnEtiquetaPeso);
            Controls.Add(PnlRodape);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PesoBal";
            PnlRodape.ResumeLayout(false);
            PnlRodape.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlRodape;
        private Label LblDev;
        private Button BtnEtiquetaPeso;
        private Button BtnConfig;
        private Button BtnSair;
        private Label label1;
        private Button BtnEtiquetaValor;
        private Button BtnProdutos;
    }
}