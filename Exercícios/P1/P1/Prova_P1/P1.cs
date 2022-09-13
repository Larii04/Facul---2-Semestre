using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prova_P1
{
    public partial class Frm_P1 : Form
    {
        //-------------------------------------------------------------------------------
        // PREENCHA o cabeçalho da PROVA - P1 com as informações solicitadas abaixo:
        // NOME DO ALUNO: Larissa A. G. Ferreira
        // R.A. DO ALUNO: 203284
        // DATA: 22/09/2021
        //-------------------------------------------------------------------------------

        #region Variáveis globais
        Double temperatura, pressao, volume;
        int cont = 1, tipo = 0;
        #endregion

        public Frm_P1()
        {
            InitializeComponent();
        }

        #region Ícone fechar
        private void Frm_P1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Encerando o Aplicativo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        #endregion

        #region Botão limpar
        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma", "Limpar dados...", MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Txt_Pressao.Clear(); Txt_Temperatura.Clear(); Lbx_Resultado.Items.Clear();
                Btn_Calcular.Enabled = false; Btn_Limpar.Enabled = false;
                Txt_Temperatura.Focus();
            }
        }
        #endregion

        #region Valores no começo
        private void Frm_P1_Load(object sender, EventArgs e)
        {
            cont = 1; tipo = 0;
            Btn_Calcular.Enabled = false; Btn_Limpar.Enabled = false;
            Txt_Temperatura.Focus();
        }
        #endregion

        #region Verifica os valores permitidos
        private void Verifica(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44 || e.KeyChar == 45 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Caixa de Erro - Pressão
        private void Tipo(object sender, CancelEventArgs e)
        {
            if (tipo == 1)
            {
                    MessageBox.Show("Pressão Errada", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_Pressao.Clear();
                    Txt_Pressao.Focus();
            }
        }
        #endregion
        
        #region Validando a pressão
        private void Txt_Pressao_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_Pressao.Text != "")
            {
                try
                {
                    tipo = 1;
                    pressao = Convert.ToDouble(Txt_Pressao.Text);
                    if (pressao < 0)
                    {
                        Tipo(sender, e);
                    }
                }
                catch
                {
                    Tipo(sender, e);
                }
            }
        }
        #endregion

        #region Método Booleano para Controlar Conteúdo para o Temperatura e Pressao
        Boolean TestaCampos()
        {
            if (Txt_Temperatura.Text.Length > 0  && Txt_Pressao.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Habilitando os botões (Temperatura)
        private void Txt_Temperatura_TextChanged(object sender, EventArgs e)
        {
            Btn_Calcular.Enabled = TestaCampos();
            Btn_Limpar.Enabled = TestaCampos();
        }
        #endregion

        #region Habilitando os botões (Pressão)
        private void Txt_Pressao_TextChanged(object sender, EventArgs e)
        {
            Btn_Calcular.Enabled = TestaCampos();
            Btn_Limpar.Enabled = TestaCampos();
        }
        #endregion

        #region Botão calcular
        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                temperatura = Convert.ToDouble(Txt_Temperatura.Text);
                pressao = Convert.ToDouble(Txt_Pressao.Text);

                for (int i = 1; i < 6; i++)
                {
                    volume = (82 * Math.Pow(10, -3) / pressao) * (temperatura + 273);

                    Lbx_Resultado.Items.Add("Temperatura: " + temperatura + " | Volume: " + volume.ToString("#0.0000"));

                    temperatura += 2;
                }
            }
            catch
            {
                MessageBox.Show("Erro no cálculo", "Erro", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        #region DataHora
        private void Tmr_DataHora_Tick(object sender, EventArgs e)
        {
            Lbl_DataHora.Text = DateTime.Now.ToString();
        }

        #endregion

        #region Animação
        private void TmrFluido_Tick(object sender, EventArgs e)
        {
            cont = cont % 6 + 1;
            Ptb_Animacao.Image = Image.FromFile(Directory.GetCurrentDirectory() +
            "\\fluido" + Convert.ToString(cont) + ".png");
        }
        #endregion


    }
}
