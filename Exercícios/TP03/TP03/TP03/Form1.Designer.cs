namespace TP03
{
    partial class Frm_TP03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_DataHora = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Tempo = new System.Windows.Forms.TextBox();
            this.Txt_Aceleracao = new System.Windows.Forms.TextBox();
            this.Txt_VelocidadeInicial = new System.Windows.Forms.TextBox();
            this.Txt_EspacoInicial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Velocidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_EspacoPercorrido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_DataHora);
            this.groupBox1.Location = new System.Drawing.Point(7, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Lbl_DataHora
            // 
            this.Lbl_DataHora.AutoSize = true;
            this.Lbl_DataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DataHora.ForeColor = System.Drawing.Color.Red;
            this.Lbl_DataHora.Location = new System.Drawing.Point(249, 26);
            this.Lbl_DataHora.Name = "Lbl_DataHora";
            this.Lbl_DataHora.Size = new System.Drawing.Size(212, 25);
            this.Lbl_DataHora.TabIndex = 0;
            this.Lbl_DataHora.Text = "Data e Hora corrente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Tempo);
            this.groupBox2.Controls.Add(this.Txt_Aceleracao);
            this.groupBox2.Controls.Add(this.Txt_VelocidadeInicial);
            this.groupBox2.Controls.Add(this.Txt_EspacoInicial);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(339, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações Iniciais";
            // 
            // Txt_Tempo
            // 
            this.Txt_Tempo.Location = new System.Drawing.Point(178, 154);
            this.Txt_Tempo.MaxLength = 6;
            this.Txt_Tempo.Name = "Txt_Tempo";
            this.Txt_Tempo.Size = new System.Drawing.Size(82, 30);
            this.Txt_Tempo.TabIndex = 11;
            // 
            // Txt_Aceleracao
            // 
            this.Txt_Aceleracao.Location = new System.Drawing.Point(178, 115);
            this.Txt_Aceleracao.MaxLength = 6;
            this.Txt_Aceleracao.Name = "Txt_Aceleracao";
            this.Txt_Aceleracao.Size = new System.Drawing.Size(82, 30);
            this.Txt_Aceleracao.TabIndex = 10;
            // 
            // Txt_VelocidadeInicial
            // 
            this.Txt_VelocidadeInicial.Location = new System.Drawing.Point(178, 79);
            this.Txt_VelocidadeInicial.MaxLength = 6;
            this.Txt_VelocidadeInicial.Name = "Txt_VelocidadeInicial";
            this.Txt_VelocidadeInicial.Size = new System.Drawing.Size(82, 30);
            this.Txt_VelocidadeInicial.TabIndex = 9;
            // 
            // Txt_EspacoInicial
            // 
            this.Txt_EspacoInicial.Location = new System.Drawing.Point(178, 37);
            this.Txt_EspacoInicial.MaxLength = 6;
            this.Txt_EspacoInicial.Name = "Txt_EspacoInicial";
            this.Txt_EspacoInicial.Size = new System.Drawing.Size(82, 30);
            this.Txt_EspacoInicial.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "(m/s²)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aceleração";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "(m/s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velociade Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "(m)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Espaço Inicial";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_Velocidade);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Txt_EspacoPercorrido);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(7, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados do Processamento";
            // 
            // Txt_Velocidade
            // 
            this.Txt_Velocidade.Location = new System.Drawing.Point(464, 33);
            this.Txt_Velocidade.MaxLength = 6;
            this.Txt_Velocidade.Name = "Txt_Velocidade";
            this.Txt_Velocidade.Size = new System.Drawing.Size(82, 30);
            this.Txt_Velocidade.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(549, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "(m/s)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Velociade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "(m)";
            // 
            // Txt_EspacoPercorrido
            // 
            this.Txt_EspacoPercorrido.Location = new System.Drawing.Point(203, 35);
            this.Txt_EspacoPercorrido.MaxLength = 6;
            this.Txt_EspacoPercorrido.Name = "Txt_EspacoPercorrido";
            this.Txt_EspacoPercorrido.Size = new System.Drawing.Size(82, 30);
            this.Txt_EspacoPercorrido.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Espaço Percorrido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Sair);
            this.panel1.Controls.Add(this.Btn_Limpar);
            this.panel1.Controls.Add(this.Btn_Calcular);
            this.panel1.Location = new System.Drawing.Point(7, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 73);
            this.panel1.TabIndex = 4;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.Image = global::TP03.Properties.Resources.Sair;
            this.Btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Sair.Location = new System.Drawing.Point(464, 9);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(165, 61);
            this.Btn_Sair.TabIndex = 2;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpar.Image = global::TP03.Properties.Resources.Limpar;
            this.Btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpar.Location = new System.Drawing.Point(254, 6);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(165, 61);
            this.Btn_Limpar.TabIndex = 1;
            this.Btn_Limpar.Text = "&Limpar";
            this.Btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calcular.Image = global::TP03.Properties.Resources.Calcular1;
            this.Btn_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Calcular.Location = new System.Drawing.Point(30, 6);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(165, 61);
            this.Btn_Calcular.TabIndex = 0;
            this.Btn_Calcular.Text = "&Calcular";
            this.Btn_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::TP03.Properties.Resources.Movel;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_TP03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(682, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TP03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudo de um Móvel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Tempo;
        private System.Windows.Forms.TextBox Txt_Aceleracao;
        private System.Windows.Forms.TextBox Txt_VelocidadeInicial;
        private System.Windows.Forms.TextBox Txt_EspacoInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_Velocidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_EspacoPercorrido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Label Lbl_DataHora;
        private System.Windows.Forms.Timer timer1;
    }
}

