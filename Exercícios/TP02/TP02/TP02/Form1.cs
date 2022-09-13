using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP02
{
    public partial class Frm_TP02 : Form
    {
        #region Variáveis Globais
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion
        public Frm_TP02()
        {
            InitializeComponent();
        }
        #region Botão Sair
        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            msg = "Tem certeza?";
            titulo = "Sair do programa...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        #region Botão Limpar
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            msg = "Confirma?";
            titulo = "Limpar os dados...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Information;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                Txt_Massa.Clear();
                Txt_coef.Clear();
                Txt_Forca.Clear();
                Txt_Angulo.Clear();
                Txt_Deslocamento.Clear();
                Txt_FAtrito.Clear();
            }
        }

       
        #endregion

        #region Botão Calcular
        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            double m, c, f, agr, ard, d, fa;
            const double g = 9.8;

            m = double.Parse(Txt_Massa.Text);
            c = double.Parse(Txt_coef.Text);
            f = double.Parse(Txt_Forca.Text);
            agr = double.Parse(Txt_Angulo.Text);
            ard = agr * Math.PI / 180;
            d = double.Parse(Txt_Deslocamento.Text);
            fa = c * (m * g - f * Math.Sin(ard)) * d * Math.Cos(ard);
            Txt_FAtrito.Text = Convert.ToString(fa);
        }
        #endregion
        #region LIXO
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
