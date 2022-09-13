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
using System.Windows.Forms.VisualStyles;

namespace TPNotas

{
    public partial class Frm_ : Form
    {
        #region Variaveis Globais
        int tipo = 0;
        double a, b, c, d, media;
        #endregion

        public Frm_()
        {
            InitializeComponent();
        }

        #region Botão Adicionar
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Txt_Disc.Text.Length > 0 && Txt_Serie.Text.Length > 0 && Txt_Matricula.Text.Length > 0 && Txt_1bim.Text.Length > 0 && Txt_2bim.Text.Length > 0 && Txt_3bim.Text.Length > 0 && Txt_4bim.Text.Length > 0 && Txt_Media.Text.Length > 0 && Txt_Conc.Text.Length > 0)
            {
                Dgv_Notas.Enabled = true;
                DataRow novalinha = Dts_Notas.Tables["Notas"].NewRow();

                novalinha["Disciplina"] = Txt_Disc.Text.ToString();
                novalinha["Serie"] = Txt_Serie.Text.ToString();
                novalinha["Matricula"] = Txt_Matricula.Text.ToString();
                novalinha["NotaPriBi"] = Txt_1bim.Text.ToString();
                novalinha["NotaSegBi"] = Txt_2bim.Text.ToString();
                novalinha["NotaTerBi"] = Txt_3bim.Text.ToString();
                novalinha["NotaQuaBi"] = Txt_4bim.Text.ToString();
                novalinha["Media"] = Txt_Media.Text.ToString();
                novalinha["Conceito"] = Txt_Conc.Text.ToString();

                Dts_Notas.Tables[0].Rows.Add(novalinha);
                Txt_Disc.Clear();
                Txt_Matricula.Clear();
                Txt_Serie.Clear();
                Txt_1bim.Clear();
                Txt_2bim.Clear();
                Txt_3bim.Clear();
                Txt_4bim.Clear();
                Txt_Media.Clear();
                Txt_Conc.Clear();
                Txt_Media.Enabled = false;
                Txt_Conc.Enabled = false;
                Txt_Disc.Focus();

                Dgv_Notas.Enabled = false;
            }
            else
            {
                MessageBox.Show("Todos os campos tem de estar completos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Botão Sair
        private void Frm__FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Encerrando Programa...",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        #region Pesquisa
        private void Txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            switch (Cbx_Pesquisa.Text)
            {
                case "Disciplina":
                    Bsc_Notas.Filter = "Disciplina like '%" + Txt_Filtro.Text + "%'";
                    break;
                case "Série":
                    Bsc_Notas.Filter = "Serie like '%" + Txt_Filtro.Text + "%'";
                    break;
                case "Número de Matrícula":
                    Bsc_Notas.Filter = "Matricula like '%" + Txt_Filtro.Text + "%'";
                    break;

                default:
                    Txt_Filtro.Clear();
                    MessageBox.Show("Escolha uma opção", "Erro");
                    break;
            }
        }
        #endregion

        #region Verifica Numero
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

        #region Validando Notas
        private void Tipo(object sender, CancelEventArgs e)
        {
            switch (tipo)
            {
                case 1:
                    MessageBox.Show("Nota 1º Bimestre Errada", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_1bim.Clear();
                    Txt_1bim.Focus();
                    break;
                case 2:
                    MessageBox.Show("Nota 2º Bimestre Errada", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_2bim.Clear();
                    Txt_2bim.Focus();
                    break;
                case 3:
                    MessageBox.Show("Nota 3º Bimestre Errada", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_3bim.Clear();
                    Txt_3bim.Focus();
                    break;
                case 4:
                    MessageBox.Show("Nota 4º Bimestre Errada", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_4bim.Clear();
                    Txt_4bim.Focus();
                    break;
            }
        }

        #endregion

        #region Exportar Por Linha
        private void porLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < Dts_Notas.Tables["Notas"].Rows.Count; i++)
                {
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["Disciplina"]);
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["Serie"]);
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["Matricula"]);
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["NotaPriBi"]);
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["NotaSegBi"]);
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["NotaTerBi"]);
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["NotaQuaBi"]);
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["Media"]);
                    SW.WriteLine(Dts_Notas.Tables["Notas"].Rows[i]["Conceito"]);
                    SW.WriteLine(string.Empty);
                }
                SW.Dispose();
            }
        }
        #endregion

        #region Exportar Por Coluna
        private void Mnu_Txt_Coluna_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < Dts_Notas.Tables["Notas"].Rows.Count; i++)
                {
                    string Disciplina = Dgv_Notas.Rows[i].Cells[0].Value.ToString();
                    string Serie = Dgv_Notas.Rows[i].Cells[1].Value.ToString();
                    string Matricula = Dgv_Notas.Rows[i].Cells[2].Value.ToString();
                    string NotaPriBi = Dgv_Notas.Rows[i].Cells[3].Value.ToString();
                    string NotaSegBi = Dgv_Notas.Rows[i].Cells[4].Value.ToString();
                    string NotaTerBi = Dgv_Notas.Rows[i].Cells[5].Value.ToString();
                    string NotaQuaBi = Dgv_Notas.Rows[i].Cells[6].Value.ToString();
                    string Media = Dgv_Notas.Rows[i].Cells[7].Value.ToString();
                    string Conceito = Dgv_Notas.Rows[i].Cells[8].Value.ToString();
                    SW.WriteLine(Disciplina + "|" + Serie + "|" + Matricula + "|" + NotaPriBi + "|" + NotaSegBi + "|" + NotaTerBi + "|" + NotaQuaBi + "|" + Media + "|" + Conceito);
                }
                SW.Dispose();
            }
        }
        #endregion
        
        #region Cálculo Média e Conceito
        private void Txt_4bim_Validated(object sender, EventArgs e)
        {
            if (Txt_1bim.Text.Length > 0 && Txt_2bim.Text.Length > 0 && Txt_3bim.Text.Length > 0 && Txt_4bim.Text.Length > 0)
            {
                media = (a + b + c + d) / 4;
                Txt_Media.Enabled = true;
                Txt_Media.Text = media.ToString();
                Txt_Conc.Enabled = true;
                if (media >= 6)
                {
                    Txt_Conc.Text = "Aprovado";
                    Txt_Conc.ForeColor = Color.Blue;
                }
                else
                {
                    Txt_Conc.Text = "Reprovado";
                    Txt_Conc.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        #region Validação 1º Bim
        private void Txt_1bim_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_1bim.Text != "")
            {
                try
                {
                    tipo = 1;
                    a = Convert.ToDouble(Txt_1bim.Text);
                    if ((a > 10) || (a < 0))
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

        #region Validação 2ºBim
        private void Txt_2bim_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_2bim.Text != "")
            {
                try
                {
                    tipo = 2;
                    b = Convert.ToDouble(Txt_2bim.Text);
                    if ((b > 10) || (b < 0))
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

        #region Validação 3º Bim
        private void Txt_3bim_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_3bim.Text != "")
            {
                try
                {
                    tipo = 3;
                    c = Convert.ToDouble(Txt_3bim.Text);
                    if ((c > 10) || (c < 0))
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

        #region Validação 4º Bim
        private void Txt_4bim_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_4bim.Text != "")
            {
                try
                {
                    tipo = 4;
                    d = Convert.ToDouble(Txt_4bim.Text);
                    if ((d > 10) || (d < 0))
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

    }
}

