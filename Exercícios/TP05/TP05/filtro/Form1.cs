using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace filtro
{
    public partial class FRMPrincipal : Form
    {
        #region variáveis globais
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        int contador, passo, tipo;
        Double a, c, f; //a=amplificador c=capacitor f=frequencia
        #endregion

        public FRMPrincipal()
        {
            InitializeComponent();
        }
      
        #region Valores de Start
        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            contador = 1;
            BTNCalcular.Enabled = false;
            BTNLimpar.Enabled = false;
        }
        #endregion
        #region Icone Fechar
        private void FRMPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            msg = "Tem certeza?";
            titulo = "Sair do programa...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;

            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.No)
            {
                e.Cancel=true;
            }
        }
        #endregion
        #region Botão Limpar
        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            msg = "Confirma";
            titulo = "Limpar dados...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Exclamation;
            definido = MessageBoxDefaultButton.Button1;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                contador = 1; passo = 0; a = 0; c = 0; f = 0;
                BTNCalcular.Enabled = false;
                BTNLimpar.Enabled = false;
                TXTAmplificacao.Clear();
                TXTCapacitador.Clear();
                TXTFrequencia.Clear();
                TXTPasso.Clear();
                LSTR1.Items.Clear();
                LSTR2.Items.Clear();
                LstR3.Items.Clear();
                LSTC2.Items.Clear();
                TXTAmplificacao.Focus();
            }

        }


        #endregion
        #region Exibi Data corrente
        private void timer2_Tick(object sender, EventArgs e)
        {
            Lbl_Msg.Text = DateTime.Now.ToString();
        }
        #endregion
        #region Rotina que trata valor numérico
        private void Verifica(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }       
        #endregion
        #region Caixas de Dialogos de Erro
        private void Onde(object sender, CancelEventArgs e)
        {
            if (tipo == 1)
            {
                MessageBox.Show("Amplificação Errada", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTAmplificacao.Clear();
                TXTAmplificacao.Focus();
            }
            else if (tipo == 2)
            {
                MessageBox.Show("Capacitor Errado", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTCapacitador.Clear();
                TXTCapacitador.Focus();
            }
            else if (tipo == 3)
            {
                MessageBox.Show("Frequência Errada", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTFrequencia.Clear();
                TXTFrequencia.Focus();
            }
            else
            {
                MessageBox.Show("Passo Errado", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTPasso.Clear();
                TXTPasso.Focus();
            }
        }
        #endregion
        #region Validando os dados de entrada
        private void TXTAmplificacao_Validating(object sender, CancelEventArgs e)
        {
            if (TXTAmplificacao.Text != "")
            {
                try
                {
                    tipo = 1;
                    a = Convert.ToDouble(TXTAmplificacao.Text);
                    if (a == 0)
                    {
                        Onde(sender, e);
                    }
                }
                catch
                {
                    Onde(sender, e);
                }
            }
        }

        
        private void TXTCapacitador_Validating(object sender, CancelEventArgs e)
        {
            if (TXTCapacitador.Text != "")
            {
                try
                {
                    tipo = 2;
                    c = Convert.ToDouble(TXTCapacitador.Text);
                    if (c == 0)
                    {
                        Onde(sender, e);
                    }
                }
                catch
                {
                    Onde(sender, e);
                }
            }
        }


        private void TXTFrequencia_Validating(object sender, CancelEventArgs e)
        {
            if (TXTFrequencia.Text != "")
            {
                try
                {
                    tipo = 3;
                    f = Convert.ToDouble(TXTFrequencia.Text);
                    if (f == 0)
                    {
                        Onde(sender, e);
                    }
                }
                catch
                {
                    Onde(sender, e);
                }
            }
        }

        private void TXTPasso_Validating(object sender, CancelEventArgs e)
        {
            if (TXTPasso.Text != "")
            {
                try
                {
                    tipo = 4;
                    if (TXTPasso.Text == "")
                    {
                        Onde(sender, e);
                    }
                    else
                    {
                        passo = Convert.ToInt16(TXTPasso.Text);
                    }
                }
                catch
                {
                    Onde(sender, e);
                }
            }
        }
        #endregion
        #region Gera a animação
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = contador % 9 + 1;
            PBXFiltro.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\res0" + Convert.ToString(contador)+ ".png");
        }
        #endregion
        # region Funcao Controle Conteudo para o PASSO
        Boolean TestaCampos()
        {
            if (TXTPasso.Text.Length>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Habilita ou desabilita os botões Calcular e Limpar
        private void TXTPasso_TextChanged(object sender, EventArgs e)
        {
            BTNCalcular.Enabled = TestaCampos();
            BTNLimpar.Enabled = TestaCampos();
        }
        #endregion
        #region Botão Calcular
        private void BTNCalcular_Click(object sender, EventArgs e)
        {
            Double r1,r2,r3,c2;
            int j;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    j = i + 1;
                    r1 = Math.Sqrt(2) / (2 * a * 2 * Math.PI * f * c);
                    r2 = a * r1;
                    r3 = r2 / (a + 1);
                    c2 = 2 * (a + 1) * c;
                    LSTR1.Items.Add(j.ToString("#0") + " -> " + r1.ToString("#0.0000"));
                    LSTR2.Items.Add(j.ToString("#0") + " -> " + r2.ToString("#0.0000"));
                    LstR3.Items.Add(j.ToString("#0") + " -> " + r3.ToString("#0.0000"));
                    LSTC2.Items.Add(j.ToString("#0") + " -> " + c2.ToString("#0.0000"));
                    a = a + passo;
                }
            }
            catch
            {
                MessageBox.Show("Erro no cálculo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

    }
}
