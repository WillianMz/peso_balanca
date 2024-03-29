namespace PesoBal
{
    partial class FormPrincipal
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
            TxtCodigoBarras = new TextBox();
            LblCodigoBarras = new Label();
            BtnAdicionar = new Button();
            TxtItens = new TextBox();
            BtnFinalizar = new Button();
            SuspendLayout();
            // 
            // TxtCodigoBarras
            // 
            TxtCodigoBarras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtCodigoBarras.Location = new Point(12, 27);
            TxtCodigoBarras.Name = "TxtCodigoBarras";
            TxtCodigoBarras.PlaceholderText = "200110066459";
            TxtCodigoBarras.Size = new Size(133, 23);
            TxtCodigoBarras.TabIndex = 1;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(12, 9);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(75, 15);
            LblCodigoBarras.TabIndex = 2;
            LblCodigoBarras.Text = "Cód.Etiqueta";
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAdicionar.Location = new Point(151, 12);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(72, 38);
            BtnAdicionar.TabIndex = 6;
            BtnAdicionar.Text = "Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // TxtItens
            // 
            TxtItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtItens.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtItens.Location = new Point(12, 56);
            TxtItens.Multiline = true;
            TxtItens.Name = "TxtItens";
            TxtItens.ReadOnly = true;
            TxtItens.ScrollBars = ScrollBars.Vertical;
            TxtItens.Size = new Size(211, 160);
            TxtItens.TabIndex = 7;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnFinalizar.Location = new Point(12, 222);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(211, 30);
            BtnFinalizar.TabIndex = 8;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 264);
            Controls.Add(BtnFinalizar);
            Controls.Add(TxtItens);
            Controls.Add(BtnAdicionar);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxtCodigoBarras);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PesoBal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtCodigoBarras;
        private Label LblCodigoBarras;
        private Button BtnAdicionar;
        private TextBox TxtItens;
        private Button BtnFinalizar;
    }
}
