using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoBal
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIniciarContagem_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new();
            formPrincipal.ShowDialog(this);
            formPrincipal.Dispose();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new();
            formConfig.ShowDialog();
            formConfig.Dispose();
        }

        private void BtnEtiquetaValor_Click(object sender, EventArgs e)
        {
            FormContagemManual formContagemManual = new();
            formContagemManual.ShowDialog();
            formContagemManual.Dispose();
        }
    }
}
