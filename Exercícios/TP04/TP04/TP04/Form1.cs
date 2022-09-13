using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP04
{
    public partial class Frm_TP04 : Form
    {
        
        #region Variáveis Globias
        byte jx, venceX = 0, venceO = 0;
        string letra;
        #endregion
        public Frm_TP04()
        {
            InitializeComponent();
        }

        #region Rotina para Inicio do Jogo
        void inicio()
        {
            Lbl_QuemJoga.Text = "Jogador X";
            Btn_11.Text = ""; Btn_12.Text = ""; Btn_13.Text = "";
            Btn_21.Text = ""; Btn_22.Text = ""; Btn_23.Text = "";
            Btn_31.Text = ""; Btn_32.Text = ""; Btn_33.Text = "";
            Btn_11.Enabled = true; Btn_12.Enabled = true; Btn_13.Enabled = true;
            Btn_21.Enabled = true; Btn_22.Enabled = true; Btn_23.Enabled = true;
            Btn_31.Enabled = true; Btn_32.Enabled = true; Btn_33.Enabled = true;

        }
        #endregion
        #region Start do Form
        private void Frm_TP04_Load(object sender, EventArgs e)
        {
            jx = 1;
        }
        #endregion
        #region Botão Reiniciar Jogo
        private void Btn_NovoJogo_Click(object sender, EventArgs e)
        {
            inicio();
            Lbl_Jx.Text = "Jogador X = 0";
            Lbl_Jo.Text = "Jogador O = 0";
            jx = 1; venceO = 0; venceX = 0;
        }
        #endregion
        #region Controle dos botões do Jogo da Velha
        private void Btn_11_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_11.Text = "X"; jx = 0;
                Btn_11.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_11.Text = "O"; jx = 1;
                Btn_11.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }

        private void Btn_12_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_12.Text = "X"; jx = 0;
                Btn_12.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_12.Text = "O"; jx = 1;
                Btn_12.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }

        private void Btn_13_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_13.Text = "X"; jx = 0;
                Btn_13.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_13.Text = "O"; jx = 1;
                Btn_13.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }

        private void Btn_21_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_21.Text = "X"; jx = 0;
                Btn_21.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_21.Text = "O"; jx = 1;
                Btn_21.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }

        private void Btn_22_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_22.Text = "X"; jx = 0;
                Btn_22.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_22.Text = "O"; jx = 1;
                Btn_22.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }

        private void Btn_23_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_23.Text = "X"; jx = 0;
                Btn_23.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_23.Text = "O"; jx = 1;
                Btn_23.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }

        private void Btn_31_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_31.Text = "X"; jx = 0;
                Btn_31.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_31.Text = "O"; jx = 1;
                Btn_31.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }

        private void Btn_32_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_32.Text = "X"; jx = 0;
                Btn_32.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_32.Text = "O"; jx = 1;
                Btn_32.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }

        private void Btn_33_Click(object sender, EventArgs e)
        {
            if (jx == 1)
            {
                Btn_33.Text = "X"; jx = 0;
                Btn_33.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador O";
            }
            else
            {
                Btn_33.Text = "O"; jx = 1;
                Btn_33.Enabled = false;
                Lbl_QuemJoga.Text = "Jogador X";
            }
            confere();
        }
        #endregion
        #region Confere as jogadas possíveis
        void confere()
        {
            if (Btn_11.Text == Btn_12.Text && Btn_12.Text == Btn_13.Text)
            {
                letra = Btn_11.Text; ponto();
            }
            if (Btn_21.Text == Btn_22.Text && Btn_22.Text == Btn_23.Text)
            {
                letra = Btn_21.Text; ponto();
            }
            if (Btn_31.Text == Btn_32.Text && Btn_32.Text == Btn_33.Text )
            {
                letra = Btn_31.Text; ponto();
            }
            if (Btn_11.Text == Btn_21.Text && Btn_21.Text == Btn_31.Text )
            {
                letra = Btn_11.Text; ponto();
            }
            if (Btn_12.Text == Btn_22.Text && Btn_22.Text == Btn_32.Text)
            {
                letra = Btn_12.Text; ponto();
            }
            if (Btn_13.Text == Btn_23.Text && Btn_23.Text == Btn_33.Text )
            {
                letra = Btn_13.Text; ponto();
            }
            if (Btn_11.Text == Btn_22.Text && Btn_22.Text == Btn_33.Text )
            {
                letra = Btn_11.Text; ponto();
            }
            if (Btn_13.Text == Btn_22.Text && Btn_22.Text == Btn_31.Text )
            {
                letra = Btn_13.Text; ponto();
            }
            if (Btn_11.Enabled == false && Btn_12.Enabled == false && Btn_13.Enabled == false && Btn_21.Enabled == false && Btn_22.Enabled == false && Btn_23.Enabled == false && Btn_31.Enabled == false && Btn_32.Enabled == false && Btn_33.Enabled == false)
            {
                MessageBox.Show("O Jogo EMPATOU");
                inicio();
            }
        }
        #endregion
        #region Placar da jogada
        void ponto()
        {
            if (letra == "X")
            {
                venceX++;
                Lbl_Jx.Text = "Jogador X = " + venceX.ToString();
                MessageBox.Show("Jogador X venceu");
                inicio();
            }
            else if (letra == "O")
            {
                venceO++;
                Lbl_Jo.Text = "Jogador O = " + venceO.ToString();
                MessageBox.Show("Jogador O venceu");
                inicio();
            }
        }
        #endregion

    }
}
