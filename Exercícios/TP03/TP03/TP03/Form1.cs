using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03
{
    public partial class Frm_TP03 : Form
    {
        #region Variáveis Globais
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion
       

        public Frm_TP03()
        {
            InitializeComponent();
        }

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

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            msg = "Confirma";
            titulo = "Limpar dados...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Exclamation;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg,titulo,botoes,icone,definido)==DialogResult.Yes)
            {
                Txt_EspacoInicial.Clear();
                Txt_VelocidadeInicial.Clear();
                Txt_Tempo.Clear();
                Txt_Aceleracao.Clear();
                Txt_EspacoPercorrido.Clear();
                Txt_Velocidade.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_DataHora.Text = DateTime.Now.ToString();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            Double s0, v0, a, t, s, v;
            try
            {
                s0 = Convert.ToDouble(Txt_EspacoInicial.Text);
                v0 = Convert.ToDouble(Txt_VelocidadeInicial.Text);
                a = Convert.ToDouble(Txt_Aceleracao.Text);
                t = Convert.ToDouble(Txt_Tempo.Text);
                if (s0<0)
                {
                    MessageBox.Show("Erro no Espaço Inicial");
                    s0 = 0;
                    Txt_EspacoInicial.Clear();
                    Txt_EspacoInicial.Focus();
                }
                else
                {
                    if(v0<0)
                    {
                        MessageBox.Show("Erro na Velocidade Inicial");
                        v0 = 0;
                        Txt_VelocidadeInicial.Clear();
                        Txt_VelocidadeInicial.Focus();
                    }
                    else
                    {
                        if (t<=0)
                        {
                            MessageBox.Show("Erro no Tempo");
                            t = 0;
                            Txt_Tempo.Clear();
                            Txt_Tempo.Focus();
                        }
                        else
                        {
                            if (a==0)
                            {
                                s = s0 + v0 * t;
                                v = v0;
                            }
                            else
                            {
                                s = s0 + v0 * t + (a * Math.Pow(t, 2)) / 2;
                                v = v0 + a * t;
                            }
                            Txt_EspacoPercorrido.Text = s.ToString();
                            Txt_Velocidade.Text = v.ToString();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("erro nos cálculos");
                return;
            }
        }

    }
}
