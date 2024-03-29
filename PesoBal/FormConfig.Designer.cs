namespace PesoBal
{
    partial class FormConfig
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
            LblPasta = new Label();
            TxtCaminhoPasta = new TextBox();
            GBoxTipo = new GroupBox();
            rbTipoPeso = new RadioButton();
            rbTipoValor = new RadioButton();
            BtnBuscaPasta = new Button();
            BtnSalvar = new Button();
            GBoxTipo.SuspendLayout();
            SuspendLayout();
            // 
            // LblPasta
            // 
            LblPasta.AutoSize = true;
            LblPasta.Location = new Point(12, 84);
            LblPasta.Name = "LblPasta";
            LblPasta.Size = new Size(116, 15);
            LblPasta.TabIndex = 10;
            LblPasta.Text = "Pasta Saída Arquivos";
            // 
            // TxtCaminhoPasta
            // 
            TxtCaminhoPasta.Location = new Point(12, 102);
            TxtCaminhoPasta.Name = "TxtCaminhoPasta";
            TxtCaminhoPasta.Size = new Size(210, 23);
            TxtCaminhoPasta.TabIndex = 11;
            // 
            // GBoxTipo
            // 
            GBoxTipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GBoxTipo.Controls.Add(rbTipoPeso);
            GBoxTipo.Controls.Add(rbTipoValor);
            GBoxTipo.Location = new Point(12, 12);
            GBoxTipo.Name = "GBoxTipo";
            GBoxTipo.Size = new Size(210, 67);
            GBoxTipo.TabIndex = 14;
            GBoxTipo.TabStop = false;
            GBoxTipo.Text = "Tipo Etiqueta";
            // 
            // rbTipoPeso
            // 
            rbTipoPeso.AutoSize = true;
            rbTipoPeso.Dock = DockStyle.Top;
            rbTipoPeso.Location = new Point(3, 38);
            rbTipoPeso.Name = "rbTipoPeso";
            rbTipoPeso.Size = new Size(204, 19);
            rbTipoPeso.TabIndex = 1;
            rbTipoPeso.TabStop = true;
            rbTipoPeso.Text = "Peso";
            rbTipoPeso.UseVisualStyleBackColor = true;
            // 
            // rbTipoValor
            // 
            rbTipoValor.AutoSize = true;
            rbTipoValor.Dock = DockStyle.Top;
            rbTipoValor.Location = new Point(3, 19);
            rbTipoValor.Name = "rbTipoValor";
            rbTipoValor.Size = new Size(204, 19);
            rbTipoValor.TabIndex = 0;
            rbTipoValor.TabStop = true;
            rbTipoValor.Text = "Valor";
            rbTipoValor.UseVisualStyleBackColor = true;
            // 
            // BtnBuscaPasta
            // 
            BtnBuscaPasta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnBuscaPasta.Location = new Point(12, 131);
            BtnBuscaPasta.Name = "BtnBuscaPasta";
            BtnBuscaPasta.Size = new Size(210, 23);
            BtnBuscaPasta.TabIndex = 15;
            BtnBuscaPasta.Text = "Procurar Pasta";
            BtnBuscaPasta.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSalvar.Location = new Point(12, 217);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(211, 35);
            BtnSalvar.TabIndex = 16;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 264);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnBuscaPasta);
            Controls.Add(GBoxTipo);
            Controls.Add(TxtCaminhoPasta);
            Controls.Add(LblPasta);
            Name = "FormConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração";
            GBoxTipo.ResumeLayout(false);
            GBoxTipo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblPasta;
        private TextBox TxtCaminhoPasta;
        private GroupBox GBoxTipo;
        private RadioButton rbTipoPeso;
        private RadioButton rbTipoValor;
        private Button BtnBuscaPasta;
        private Button BtnSalvar;
    }
}