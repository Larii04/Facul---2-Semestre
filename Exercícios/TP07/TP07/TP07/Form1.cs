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


namespace TP07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variáveis Globais
        static string[,] labirinto = new string[23, 30]
        {
            {"1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1",},
            {"1","1","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1",},
            {"1","1","1","0","1","1","1","0","1","1","1","1","1","1","1","0","1","1","1","1","0","1","1","1","1","1","1","1","0","1",},
            {"1","1","1","0","1","0","1","0","1","0","0","0","0","0","1","0","1","0","0","1","0","1","0","0","0","0","0","1","0","1",},
            {"1","1","1","0","1","0","1","0","1","0","1","1","1","0","1","0","1","1","0","1","0","1","0","1","1","1","1","1","0","1",},
            {"1","0","1","0","1","0","1","0","1","0","1","0","1","0","1","0","0","0","0","1","0","1","0","0","0","0","0","0","0","1",},
            {"1","0","1","0","1","0","1","0","1","0","1","0","1","0","1","1","1","1","1","1","0","1","1","1","1","1","1","1","1","1",},
            {"1","0","1","0","1","0","1","0","1","0","1","0","0","0","0","0","1","0","0","0","0","1","0","0","0","0","0","0","0","1",},
            {"1","0","1","1","1","0","1","0","1","0","1","0","1","1","1","0","1","1","1","1","1","1","0","1","1","1","1","1","1","1",},
            {"1","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0",},
            {"1","1","1","1","1","1","1","0","1","0","1","1","1","0","1","1","1","1","1","1","1","1","0","1","1","1","1","1","1","1",},
            {"0","0","0","0","0","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","0","0","0","0","1",},
            {"1","1","1","1","1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","0","1","0","1","0","1","1","1","0","1",},
            {"1","0","0","0","1","0","1","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","1","0","1","0","1",},
            {"1","1","1","0","1","0","1","0","1","1","1","1","1","1","1","1","1","1","0","1","0","1","0","1","0","1","0","1","0","1",},
            {"1","0","1","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","1","0","1",},
            {"1","0","1","0","1","0","1","1","1","1","1","1","1","1","1","1","0","1","1","1","0","1","0","1","0","1","0","1","0","1",},
            {"1","0","1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","1","0","0","0","1",},
            {"1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","0","1","0","1","0","1","0","1","1","1",},
            {"1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","0","1","0","1","0","1","1","1",},
            {"1","0","1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1","0","1","0","1","0","1","1","1",},
            {"1","0","1","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","0","1","0","1","1","1",},
            {"1","0","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","1","0","1","1","1",},

        };
        int posLinha, posColuna, tempo, vit, x, y;
        string controle;
        #endregion

        //rotinas conhecidas
        #region Valida técla
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToUpper() == "A" || e.KeyChar.ToString().ToUpper() == "D" ||
                e.KeyChar.ToString().ToUpper() == "W" || e.KeyChar.ToString().ToUpper() == "S")
            {
                controle = e.KeyChar.ToString().ToUpper();
                timer1.Start();
            }

            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion
        #region Icone Fechar
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sair do Jogo??", "Encerrando...",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        //rotinas do jogo
        #region Início
        void Inicio()
        {

            tempo = 50;
            vit = 0;
            posColuna = 0;
            posLinha = 0;
            timer2.Start();
            PbxGameOver.Visible = false;
            PbxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\direita.png");
            PbxAvatar.Parent = PbxMaze;
            PbxAvatar.Location = new Point(35, 6);
            Pbx1.Visible = true;
            Pbx2.Visible = true;
            Pbx3.Visible = true;
            Pbx4.Visible = true;
            Pbx5.Visible = true;

        }
        #endregion
        #region Valores de Start
        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio();
        }
        #endregion
        #region movimento do AVATAR
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = PbxAvatar.Location.X;
            y = PbxAvatar.Location.Y;

            if ((x == 615) && (y == 446 || y == 426))
            {
                timer1.Stop();
                if (MessageBox.Show("Jogar Novamente?", "Chegou na saída!!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Inicio();
                }
                else
                {
                    this.Close();
                }
            }
            else if (controle == "A")
            {
                PbxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\esquerda.png");
                if (posColuna == 0) return;

                if (labirinto[posLinha, posColuna - 1] == "1")
                {
                    PbxAvatar.Location = new Point(x - 20, y);
                    posColuna--;
                }
            }
            else if (controle == "D")
            {
                PbxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\direita.png");
                if (posColuna == 29) return;

                if (labirinto[posLinha, posColuna + 1] == "1")
                {
                    PbxAvatar.Location = new Point(x + 20, y);
                    posColuna++;
                }
            }
            else if (controle == "W")
            {
                PbxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\sobe.png");
                if (posLinha == 0) return;

                if (labirinto[posLinha - 1, posColuna] == "1")
                {
                    PbxAvatar.Location = new Point(x, y - 20);
                    posLinha--;
                }
            }
            else if (controle == "S")
            {
                PbxAvatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\desce.png");
                if (posLinha == 22) return;

                if (labirinto[posLinha + 1, posColuna] == "1")
                {
                    PbxAvatar.Location = new Point(x, y + 20);
                    posLinha++;
                }
            }
            if ((x == 115) && (y == 6))
            {
                vit = 2;
                Pbx1.Visible = false;
            }
            if ((x == 535) && (y == 126)) 
            {
                vit = 2;
                Pbx2.Visible = false;
            }
            if ((x == 195) && (y == 186))
            {
                vit = 2;
                Pbx3.Visible = false;
            }
            if ((x == 115) && (y == 366))
            {
                vit = 2;
                Pbx4.Visible = false;
            }

            if ((x == 495) && (y == 426))
            {
                vit = 2;
                Pbx5.Visible = false;
            }

            timer1.Stop();
        }
        #endregion
        #region Controle do Tempo
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (posColuna == 4 && posLinha == 0)
            {
                tempo++;
            }
            tempo = tempo + vit;
            Lbl_Seg.Text = "Tempo: " + tempo + "s";

            tempo--;
            vit = 0;
            if (tempo == 0)
            {
                timer1.Stop();
                timer2.Stop();
                PbxGameOver.Visible = true;
                if (MessageBox.Show("Jogar Novamente?", "GAME OVER!",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Inicio();
                }
                else
                {
                    this.Close();
                }
            }
        }
        #endregion
    }
}
