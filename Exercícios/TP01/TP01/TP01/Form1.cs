using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bttn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_R1.Clear();
            Txt_R2.Clear();
            Txt_R3.Clear();
            Txt_R4.Clear();
            Txt_R5.Clear();
            Txt_R6.Clear();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, r5, r6, aux;
            r1 = double.Parse(Txt_R1.Text);
            r2 = double.Parse(Txt_R2.Text);
            r3 = double.Parse(Txt_R3.Text);
            aux = r1 + r2 + r3;
            r4 = (r1 * r2) / aux;
            r5 = (r2 * r3) / aux;
            r6 = (r3 * r1) / aux;
            Txt_R4.Text = Convert.ToString(r4);
            Txt_R5.Text = Convert.ToString(r5);
            Txt_R6.Text = Convert.ToString(r6);
        }
    }
}
