namespace filtro
{
    partial class FRMPrincipal
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNCalcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LSTC2 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LstR3 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LSTR2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LSTR1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTPasso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTFrequencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTCapacitador = new System.Windows.Forms.TextBox();
            this.TXTAmplificacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Lbl_Msg = new System.Windows.Forms.Label();
            this.PBXFiltro = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BTNLimpar);
            this.groupBox4.Controls.Add(this.BTNCalcular);
            this.groupBox4.Location = new System.Drawing.Point(484, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(178, 243);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controles";
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BTNLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLimpar.Image = global::filtro.Properties.Resources.BLimpar;
            this.BTNLimpar.Location = new System.Drawing.Point(4, 140);
            this.BTNLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(169, 92);
            this.BTNLimpar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.BTNLimpar, "Limpar");
            this.BTNLimpar.UseVisualStyleBackColor = true;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            // 
            // BTNCalcular
            // 
            this.BTNCalcular.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BTNCalcular.Image = global::filtro.Properties.Resources.Calcular1;
            this.BTNCalcular.Location = new System.Drawing.Point(4, 28);
            this.BTNCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.BTNCalcular.Name = "BTNCalcular";
            this.BTNCalcular.Size = new System.Drawing.Size(169, 106);
            this.BTNCalcular.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BTNCalcular, "Calcular");
            this.BTNCalcular.UseVisualStyleBackColor = false;
            this.BTNCalcular.Click += new System.EventHandler(this.BTNCalcular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LSTC2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.LstR3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.LSTR2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.LSTR1);
            this.groupBox3.Location = new System.Drawing.Point(2, 181);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(468, 191);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabela de Resultados";
            this.groupBox3.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Capacitor 2";
            this.label9.UseWaitCursor = true;
            // 
            // LSTC2
            // 
            this.LSTC2.FormattingEnabled = true;
            this.LSTC2.ItemHeight = 20;
            this.LSTC2.Location = new System.Drawing.Point(366, 64);
            this.LSTC2.Margin = new System.Windows.Forms.Padding(2);
            this.LSTC2.Name = "LSTC2";
            this.LSTC2.Size = new System.Drawing.Size(88, 104);
            this.LSTC2.TabIndex = 6;
            this.LSTC2.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Resistência 3";
            this.label8.UseWaitCursor = true;
            // 
            // LstR3
            // 
            this.LstR3.FormattingEnabled = true;
            this.LstR3.ItemHeight = 20;
            this.LstR3.Location = new System.Drawing.Point(252, 64);
            this.LstR3.Margin = new System.Windows.Forms.Padding(2);
            this.LstR3.Name = "LstR3";
            this.LstR3.Size = new System.Drawing.Size(88, 104);
            this.LstR3.TabIndex = 4;
            this.LstR3.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(133, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Resistência 2";
            this.label7.UseWaitCursor = true;
            // 
            // LSTR2
            // 
            this.LSTR2.FormattingEnabled = true;
            this.LSTR2.ItemHeight = 20;
            this.LSTR2.Location = new System.Drawing.Point(133, 64);
            this.LSTR2.Margin = new System.Windows.Forms.Padding(2);
            this.LSTR2.Name = "LSTR2";
            this.LSTR2.Size = new System.Drawing.Size(88, 104);
            this.LSTR2.TabIndex = 2;
            this.LSTR2.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Resistência 1";
            this.label6.UseWaitCursor = true;
            // 
            // LSTR1
            // 
            this.LSTR1.FormattingEnabled = true;
            this.LSTR1.ItemHeight = 20;
            this.LSTR1.Location = new System.Drawing.Point(17, 64);
            this.LSTR1.Margin = new System.Windows.Forms.Padding(2);
            this.LSTR1.Name = "LSTR1";
            this.LSTR1.Size = new System.Drawing.Size(88, 104);
            this.LSTR1.TabIndex = 0;
            this.LSTR1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTPasso);
            this.groupBox2.Location = new System.Drawing.Point(374, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(101, 150);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variação do Passo";
            this.groupBox2.UseWaitCursor = true;
            // 
            // TXTPasso
            // 
            this.TXTPasso.Location = new System.Drawing.Point(22, 68);
            this.TXTPasso.Margin = new System.Windows.Forms.Padding(2);
            this.TXTPasso.MaxLength = 3;
            this.TXTPasso.Name = "TXTPasso";
            this.TXTPasso.Size = new System.Drawing.Size(48, 26);
            this.TXTPasso.TabIndex = 0;
            this.TXTPasso.UseWaitCursor = true;
            this.TXTPasso.TextChanged += new System.EventHandler(this.TXTPasso_TextChanged);
            this.TXTPasso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TXTPasso.Validating += new System.ComponentModel.CancelEventHandler(this.TXTPasso_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXTFrequencia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXTCapacitador);
            this.groupBox1.Controls.Add(this.TXTAmplificacao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(362, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada de Dados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "( Hz )";
            this.label5.UseWaitCursor = true;
            // 
            // TXTFrequencia
            // 
            this.TXTFrequencia.Location = new System.Drawing.Point(201, 119);
            this.TXTFrequencia.Margin = new System.Windows.Forms.Padding(2);
            this.TXTFrequencia.MaxLength = 4;
            this.TXTFrequencia.Name = "TXTFrequencia";
            this.TXTFrequencia.Size = new System.Drawing.Size(51, 26);
            this.TXTFrequencia.TabIndex = 6;
            this.TXTFrequencia.UseWaitCursor = true;
            this.TXTFrequencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TXTFrequencia.Validating += new System.ComponentModel.CancelEventHandler(this.TXTFrequencia_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "( µF )";
            this.label4.UseWaitCursor = true;
            // 
            // TXTCapacitador
            // 
            this.TXTCapacitador.Location = new System.Drawing.Point(201, 74);
            this.TXTCapacitador.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCapacitador.MaxLength = 3;
            this.TXTCapacitador.Name = "TXTCapacitador";
            this.TXTCapacitador.Size = new System.Drawing.Size(102, 26);
            this.TXTCapacitador.TabIndex = 4;
            this.TXTCapacitador.UseWaitCursor = true;
            this.TXTCapacitador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TXTCapacitador.Validating += new System.ComponentModel.CancelEventHandler(this.TXTCapacitador_Validating);
            // 
            // TXTAmplificacao
            // 
            this.TXTAmplificacao.Location = new System.Drawing.Point(201, 35);
            this.TXTAmplificacao.Margin = new System.Windows.Forms.Padding(2);
            this.TXTAmplificacao.MaxLength = 3;
            this.TXTAmplificacao.Name = "TXTAmplificacao";
            this.TXTAmplificacao.Size = new System.Drawing.Size(44, 26);
            this.TXTAmplificacao.TabIndex = 3;
            this.TXTAmplificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TXTAmplificacao.Validating += new System.ComponentModel.CancelEventHandler(this.TXTAmplificacao_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frequência";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacitador";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amplificação";
            this.label1.UseWaitCursor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolTip1.IsBalloon = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Lbl_Msg);
            this.panel1.Location = new System.Drawing.Point(488, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 95);
            this.panel1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Data Atual";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Msg
            // 
            this.Lbl_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Msg.Location = new System.Drawing.Point(12, 51);
            this.Lbl_Msg.Name = "Lbl_Msg";
            this.Lbl_Msg.Size = new System.Drawing.Size(144, 30);
            this.Lbl_Msg.TabIndex = 0;
            this.Lbl_Msg.Text = "label10";
            this.Lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBXFiltro
            // 
            this.PBXFiltro.Location = new System.Drawing.Point(4, 379);
            this.PBXFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.PBXFiltro.Name = "PBXFiltro";
            this.PBXFiltro.Size = new System.Drawing.Size(658, 212);
            this.PBXFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXFiltro.TabIndex = 9;
            this.PBXFiltro.TabStop = false;
            this.PBXFiltro.UseWaitCursor = true;
            // 
            // FRMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(670, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBXFiltro);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro Passa Baixa Ativo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FRMPrincipal_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBXFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBXFiltro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNCalcular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox LSTC2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LstR3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LSTR2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LSTR1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTPasso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTFrequencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTCapacitador;
        private System.Windows.Forms.TextBox TXTAmplificacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Msg;
        private System.Windows.Forms.Label label10;
    }
}

