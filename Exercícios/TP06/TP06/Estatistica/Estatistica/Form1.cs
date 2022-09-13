using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estatistica
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

            #region variaveis globais
               int[] x = new int[51];
               int i, j;
               Boolean muda;
            #endregion
            #region valor de partida
            private void FrmPrincipal_Load(object sender, EventArgs e)
            {
                i = 1;
                muda = true;
            }
            #endregion
            #region consistencia numérica
            private void TxtAltura_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 8 || (e.KeyChar > 47 && e.KeyChar < 58))
                {
                    e.KeyChar = e.KeyChar;
                }
                else
                {
                    e.KeyChar = Convert.ToChar(0);
                }
            }
            #endregion
            #region Alerta Label Entrada
            private void timer1_Tick(object sender, EventArgs e)
            {
                if (muda == true)
                {
                    LblMsg.ForeColor = Color.Red;
                    muda = false;
                }
                else
                {
                    LblMsg.ForeColor = Color.Black;
                    muda = true;
                }
            }
            #endregion       
            #region Recebe as Alturas e Valida Informação
            private void TxtAltura_Validated(object sender, EventArgs e)
            {
                if (TxtAltura.Text != "")
                {
                    if (int.Parse(TxtAltura.Text) < 140 || int.Parse(TxtAltura.Text) > 230)
                    {
                        MessageBox.Show("Altura fora \nda faixa válida!!!", "Atenção");
                    }
                    else
                    {
                        if (i < 50)
                        {
                            x[i] = int.Parse(TxtAltura.Text);
                            i++;
                        }
                        else
                        {
                            x[i] = int.Parse(TxtAltura.Text);

                            for (i = 1; i <= 50; i++)
                            {
                                LstFornecida.Items.Add(Convert.ToString(x[i]));
                            }
                            LblOrdinal.Enabled = false;
                            TxtAltura.Enabled = false;
                            MnuRol.Enabled = true;
                        }
                    }
                    if (i <= 50)
                    {
                        LblOrdinal.Text = i.ToString("#00");
                    }
                    else
                    {
                        LblOrdinal.Text = "50";
                        i = 50;
                    }
                    TxtAltura.Clear();
                    TxtAltura.Focus();
                }
                else
                {
                    return;
                }
            }
            #endregion
            #region opção ROL - ordena de forma crescente os números
            private void MnuRol_Click(object sender, EventArgs e)
            {
                int trocou, aux;
                for (i = 50; i >= 2; i--)
                {
                    trocou = 0;
                    for (j = 1; j <= i - 1; j++)
                    {
                        if (x[j] > x[j + 1])
                        {
                            aux = x[j];
                            x[j] = x[j + 1];
                            x[j + 1] = aux;
                            trocou = 1;
                        }
                    }
                    if (trocou == 0)
                    {
                        for (i = 1; i <= 50; i++)
                        {
                            LstRol.ColumnWidth = 40;
                            LstRol.Items.Add(Convert.ToString(x[i]));
                        }
                        MnuMedia.Enabled = true;
                        return;
                    }
                }
            }
            #endregion
            #region opção MÉDIA - efetua o calculo
            private void MnuMedia_Click(object sender, EventArgs e)
            {
                double soma = 0;
                for (i = 1; i <= 50; i++)
                {
                    soma = soma + x[i];
                }
                soma = soma / 50;
                LblMedia.Text = soma.ToString("##0.00");
            }
            #endregion
            #region Icone Fechar do Form
            private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (MessageBox.Show("Deseja Sair", "Encerando o Aplicativo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
            }
            #endregion
            #region opção LIMPAR
            private void MnuLimpar_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Confirma", "Limpar dados...",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MnuRol.Enabled = false;
                    MnuMedia.Enabled = false;
                    LblOrdinal.Enabled = true;
                    TxtAltura.Enabled = true;
                    i = 1;
                    LblOrdinal.Text = "1";
                    TxtAltura.Clear();
                    LblMedia.Text = "";
                    LstFornecida.Items.Clear();
                    LstRol.Items.Clear();
                }
            }
            #endregion
            #region opção Sobre
            private void MnuSobre_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Nome do aluno \nNumero Matricula \nDisciplina: TEC.PROG.II",
                            "Elaborador");
            }
            #endregion

    }
}
