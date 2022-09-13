using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp11
{
    public partial class Frm_CC : Form
    {
        public Frm_CC()
        {
            InitializeComponent();
        }
        #region Ícone Fechar
        private void Frm_CC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Encerrando o Aplicativo...",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion
        #region Botão Limpar
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer apagar os dados?", "Limpar os dados...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MTxt_Num.Clear();
                Lbl_Verif.Text = "";
                MTxt_Num.Focus();
            }
        }
        #endregion
        #region Botão Verificar Cartão
        private void Btn_Verif_Click(object sender, EventArgs e)
        {
            if (Validacoes.clsValidacoes.ValidaCartao(MTxt_Num.Text) == true)
            {
                Lbl_Verif.Text = "CARTÃO VERIFICADO";
                Lbl_Verif.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Lbl_Verif.Text = "CARTÃO INCORRETO";
                Lbl_Verif.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion
    }
}
