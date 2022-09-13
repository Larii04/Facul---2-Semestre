using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificaRG
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #region Verifica RG
        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            if (RG.clsRG.ValidaRG(TxtRG.Text)==true)
            {
                TxtResultado.Text = "RG Correto";
            }
            else
            {
                TxtResultado.Text = "RG Errado";
            }
        }
        #endregion
        #region Botão Limpar
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Limpar os dados",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TxtRG.Clear();
                TxtResultado.Clear();
                TxtRG.Focus();
            }
        }
        #endregion
        #region Ícone Fechar
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Encerando o Aplicativo",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion
    }
}
