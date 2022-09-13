namespace Prova_P1
{
    partial class Frm_P1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_P1));
            this.TmrFluido = new System.Windows.Forms.Timer(this.components);
            this.Tmr_DataHora = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Pressao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Temperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Lbx_Resultado = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_DataHora = new System.Windows.Forms.Label();
            this.Ptb_Animacao = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Animacao)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrFluido
            // 
            this.TmrFluido.Enabled = true;
            this.TmrFluido.Interval = 150;
            this.TmrFluido.Tick += new System.EventHandler(this.TmrFluido_Tick);
            // 
            // Tmr_DataHora
            // 
            this.Tmr_DataHora.Enabled = true;
            this.Tmr_DataHora.Tick += new System.EventHandler(this.Tmr_DataHora_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Pressao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Temperatura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(74, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(182, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "atm";
            // 
            // Txt_Pressao
            // 
            this.Txt_Pressao.Location = new System.Drawing.Point(87, 47);
            this.Txt_Pressao.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Pressao.MaxLength = 2;
            this.Txt_Pressao.Name = "Txt_Pressao";
            this.Txt_Pressao.Size = new System.Drawing.Size(27, 20);
            this.Txt_Pressao.TabIndex = 4;
            this.Txt_Pressao.TextChanged += new System.EventHandler(this.Txt_Pressao_TextChanged);
            this.Txt_Pressao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.Txt_Pressao.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Pressao_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pressão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "° Celsius";
            // 
            // Txt_Temperatura
            // 
            this.Txt_Temperatura.Location = new System.Drawing.Point(87, 21);
            this.Txt_Temperatura.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Temperatura.MaxLength = 3;
            this.Txt_Temperatura.Name = "Txt_Temperatura";
            this.Txt_Temperatura.Size = new System.Drawing.Size(27, 20);
            this.Txt_Temperatura.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Txt_Temperatura, "Clique aqui para c=limpar");
            this.Txt_Temperatura.TextChanged += new System.EventHandler(this.Txt_Temperatura_TextChanged);
            this.Txt_Temperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btn_Calcular);
            this.panel1.Controls.Add(this.Btn_Limpar);
            this.panel1.Location = new System.Drawing.Point(260, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 114);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Image = global::Prova_P1.Properties.Resources.Calcular;
            this.Btn_Calcular.Location = new System.Drawing.Point(3, 57);
            this.Btn_Calcular.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(53, 52);
            this.Btn_Calcular.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Btn_Calcular, "Clique aqui para calcular");
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Image = global::Prova_P1.Properties.Resources.Limpar;
            this.Btn_Limpar.Location = new System.Drawing.Point(4, 4);
            this.Btn_Limpar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(53, 52);
            this.Btn_Limpar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Btn_Limpar, "Clique aqui para limpar");
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Lbx_Resultado
            // 
            this.Lbx_Resultado.FormattingEnabled = true;
            this.Lbx_Resultado.Location = new System.Drawing.Point(74, 118);
            this.Lbx_Resultado.Margin = new System.Windows.Forms.Padding(2);
            this.Lbx_Resultado.Name = "Lbx_Resultado";
            this.Lbx_Resultado.Size = new System.Drawing.Size(249, 69);
            this.Lbx_Resultado.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Lbl_DataHora);
            this.panel2.Location = new System.Drawing.Point(8, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 35);
            this.panel2.TabIndex = 4;
            // 
            // Lbl_DataHora
            // 
            this.Lbl_DataHora.AutoSize = true;
            this.Lbl_DataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DataHora.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_DataHora.Location = new System.Drawing.Point(45, 6);
            this.Lbl_DataHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_DataHora.Name = "Lbl_DataHora";
            this.Lbl_DataHora.Size = new System.Drawing.Size(103, 20);
            this.Lbl_DataHora.TabIndex = 0;
            this.Lbl_DataHora.Text = "Data - Hora";
            // 
            // Ptb_Animacao
            // 
            this.Ptb_Animacao.Image = global::Prova_P1.Properties.Resources.fluido1;
            this.Ptb_Animacao.Location = new System.Drawing.Point(8, 38);
            this.Ptb_Animacao.Margin = new System.Windows.Forms.Padding(2);
            this.Ptb_Animacao.Name = "Ptb_Animacao";
            this.Ptb_Animacao.Size = new System.Drawing.Size(63, 148);
            this.Ptb_Animacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_Animacao.TabIndex = 0;
            this.Ptb_Animacao.TabStop = false;
            // 
            // Frm_P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 191);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lbx_Resultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ptb_Animacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_P1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudo de um Fluído";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_P1_FormClosing);
            this.Load += new System.EventHandler(this.Frm_P1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Animacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmrFluido;
        private System.Windows.Forms.Timer Tmr_DataHora;
        private System.Windows.Forms.PictureBox Ptb_Animacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Pressao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Temperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.ListBox Lbx_Resultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_DataHora;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

