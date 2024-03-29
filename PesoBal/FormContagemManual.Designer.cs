namespace PesoBal
{
    partial class FormContagemManual
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
            LblCodigoBarras = new Label();
            TxtCodigoBarras = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            BtnFinalizar = new Button();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(12, 9);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(92, 15);
            LblCodigoBarras.TabIndex = 4;
            LblCodigoBarras.Text = "Código Produto";
            // 
            // TxtCodigoBarras
            // 
            TxtCodigoBarras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtCodigoBarras.Location = new Point(12, 27);
            TxtCodigoBarras.Name = "TxtCodigoBarras";
            TxtCodigoBarras.PlaceholderText = "200110066459";
            TxtCodigoBarras.Size = new Size(120, 23);
            TxtCodigoBarras.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 6;
            label1.Text = "Preço do KG";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(138, 27);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "200110066459";
            textBox1.Size = new Size(85, 23);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 8;
            label2.Text = "Peso do Produto";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(12, 99);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "200110066459";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 7;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnFinalizar.Location = new Point(12, 222);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(211, 30);
            BtnFinalizar.TabIndex = 9;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(12, 186);
            button1.Name = "button1";
            button1.Size = new Size(211, 30);
            button1.TabIndex = 10;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 11;
            label3.Text = "</NOME DO PRODUTO>";
            // 
            // FormContagemManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 264);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(BtnFinalizar);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxtCodigoBarras);
            Name = "FormContagemManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manual";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCodigoBarras;
        private TextBox TxtCodigoBarras;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button BtnFinalizar;
        private Button button1;
        private Label label3;
    }
}