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

namespace Prova_P2
{
    public partial class Frm_Manutencao : Form
    {
        public Frm_Manutencao()
        {
            InitializeComponent();
        }
        // NOME: Larissa Andrade G. Ferreira     RA: 203284

        #region ícone fechar
        private void Frm_Manutencao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Encerando a P2",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        #region Botão salvar
        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (Txt_Nome.Text.Length > 0 && Txt_Equipamento.Text.Length > 0 && MTxt_Data.Text.Length > 0 &&
                Txt_Motivo.Text.Length > 0 && Txt_Situacao.Text.Length > 0)
            {
                Dgv_Cadastro.Enabled = true;
                DataRow novaLinha = DtsEquipamentos.Tables["Cadastro"].NewRow();
                novaLinha["Nome do Monitor(a)"] = Txt_Nome.Text.ToString();
                novaLinha["Equipamento"] = Txt_Equipamento.Text.ToString();
                novaLinha["Data"] = MTxt_Data.Text.ToString();
                novaLinha["Motivo"] = Txt_Motivo.Text.ToString();
                novaLinha["Situação"] = Txt_Situacao.Text.ToString();
                DtsEquipamentos.Tables[0].Rows.Add(novaLinha);

                Txt_Nome.Clear(); Txt_Equipamento.Clear(); MTxt_Data.Clear();
                Txt_Motivo.Clear(); Txt_Situacao.Clear();

                Dgv_Cadastro.Enabled = false;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Filtro de Busca
        private void Txt_Busca_TextChanged(object sender, EventArgs e)
        {
            switch (Cbx_Busca.Text)
            {
                case "Equipamento":
                    BscLaboratorio.Filter = "Equipamento like '%" + Txt_Busca.Text + "%'";
                    break;
                case "Data":
                    BscLaboratorio.Filter = "Data like '%" + Txt_Busca.Text + "%'";
                    break;
                case "Situação":
                    BscLaboratorio.Filter = "Situação like '%" + Txt_Busca.Text + "%'";
                    break;
                default:
                    Txt_Busca.Clear();
                    MessageBox.Show("Escolha uma opção", "Erro");
                    break;
            }
        }
        #endregion

        #region Gravar por linha
        private void Mnu_Linha_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < DtsEquipamentos.Tables["Cadastro"].Rows.Count; i++)
                {
                    SW.Write("Nome do Monitor(a): ");
                    SW.WriteLine(DtsEquipamentos.Tables["Cadastro"].Rows[i]["Nome do Monitor(a)"]);
                    SW.Write("Equipamento: ");
                    SW.WriteLine(DtsEquipamentos.Tables["Cadastro"].Rows[i]["Equipamento"]);
                    SW.Write("Data: ");
                    SW.WriteLine(DtsEquipamentos.Tables["Cadastro"].Rows[i]["Data"]);
                    SW.Write("Motivo: ");
                    SW.WriteLine(DtsEquipamentos.Tables["Cadastro"].Rows[i]["Motivo"]);
                    SW.Write("Situação: ");
                    SW.WriteLine(DtsEquipamentos.Tables["Cadastro"].Rows[i]["Situação"]);
                    SW.WriteLine("--------------------------------");
                    SW.WriteLine(String.Empty);
                }
                SW.Dispose();
            }
        }
        #endregion

        #region Verificando valores da Data
        private void VerificaData(object sender, KeyPressEventArgs e)
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
    }
}
