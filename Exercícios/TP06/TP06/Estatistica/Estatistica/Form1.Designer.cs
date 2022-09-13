namespace Estatistica
{
    partial class FrmPrincipal
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblMedia = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LstRol = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LstFornecida = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblOrdinal = new System.Windows.Forms.Label();
            this.LblMsg = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuDetalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLimpar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEstatistica = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRol = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.LblMedia);
            this.groupBox3.Location = new System.Drawing.Point(269, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 64);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Média das Alturas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "( cm )";
            // 
            // LblMedia
            // 
            this.LblMedia.AutoSize = true;
            this.LblMedia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedia.ForeColor = System.Drawing.Color.Red;
            this.LblMedia.Location = new System.Drawing.Point(77, 37);
            this.LblMedia.Name = "LblMedia";
            this.LblMedia.Size = new System.Drawing.Size(0, 16);
            this.LblMedia.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LstRol);
            this.groupBox2.Location = new System.Drawing.Point(10, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 201);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alturas em ROL";
            // 
            // LstRol
            // 
            this.LstRol.ColumnWidth = 40;
            this.LstRol.FormattingEnabled = true;
            this.LstRol.Location = new System.Drawing.Point(13, 24);
            this.LstRol.MultiColumn = true;
            this.LstRol.Name = "LstRol";
            this.LstRol.Size = new System.Drawing.Size(231, 160);
            this.LstRol.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LstFornecida);
            this.groupBox1.Location = new System.Drawing.Point(10, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 201);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alturas fornecidas";
            // 
            // LstFornecida
            // 
            this.LstFornecida.ColumnWidth = 40;
            this.LstFornecida.FormattingEnabled = true;
            this.LstFornecida.Location = new System.Drawing.Point(13, 24);
            this.LstFornecida.MultiColumn = true;
            this.LstFornecida.Name = "LstFornecida";
            this.LstFornecida.Size = new System.Drawing.Size(231, 160);
            this.LstFornecida.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtAltura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblOrdinal);
            this.panel1.Location = new System.Drawing.Point(335, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 38);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "( cm )";
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(98, 8);
            this.TxtAltura.MaxLength = 3;
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(39, 20);
            this.TxtAltura.TabIndex = 2;
            this.TxtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAltura_KeyPress);
            this.TxtAltura.Validated += new System.EventHandler(this.TxtAltura_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "º Altura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblOrdinal
            // 
            this.LblOrdinal.AutoSize = true;
            this.LblOrdinal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdinal.Location = new System.Drawing.Point(9, 10);
            this.LblOrdinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOrdinal.Name = "LblOrdinal";
            this.LblOrdinal.Size = new System.Drawing.Size(16, 16);
            this.LblOrdinal.TabIndex = 0;
            this.LblOrdinal.Text = "1";
            this.LblOrdinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsg.Location = new System.Drawing.Point(7, 44);
            this.LblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(324, 16);
            this.LblMsg.TabIndex = 7;
            this.LblMsg.Text = "Dê 50 alturas de uma determinada amostra";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDetalhes,
            this.MnuEstatistica});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuDetalhes
            // 
            this.MnuDetalhes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLimpar,
            this.toolStripMenuItem1,
            this.MnuSobre});
            this.MnuDetalhes.Name = "MnuDetalhes";
            this.MnuDetalhes.Size = new System.Drawing.Size(64, 20);
            this.MnuDetalhes.Text = "Detalhes";
            // 
            // MnuLimpar
            // 
            this.MnuLimpar.Name = "MnuLimpar";
            this.MnuLimpar.Size = new System.Drawing.Size(111, 22);
            this.MnuLimpar.Text = "&Limpar";
            this.MnuLimpar.Click += new System.EventHandler(this.MnuLimpar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 6);
            // 
            // MnuSobre
            // 
            this.MnuSobre.Name = "MnuSobre";
            this.MnuSobre.Size = new System.Drawing.Size(111, 22);
            this.MnuSobre.Text = "S&obre";
            this.MnuSobre.Click += new System.EventHandler(this.MnuSobre_Click);
            // 
            // MnuEstatistica
            // 
            this.MnuEstatistica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRol,
            this.MnuMedia});
            this.MnuEstatistica.Name = "MnuEstatistica";
            this.MnuEstatistica.Size = new System.Drawing.Size(71, 20);
            this.MnuEstatistica.Text = "Estatistica";
            // 
            // MnuRol
            // 
            this.MnuRol.Enabled = false;
            this.MnuRol.Name = "MnuRol";
            this.MnuRol.Size = new System.Drawing.Size(107, 22);
            this.MnuRol.Text = "&Rol";
            this.MnuRol.Click += new System.EventHandler(this.MnuRol_Click);
            // 
            // MnuMedia
            // 
            this.MnuMedia.Enabled = false;
            this.MnuMedia.Name = "MnuMedia";
            this.MnuMedia.Size = new System.Drawing.Size(107, 22);
            this.MnuMedia.Text = "&Média";
            this.MnuMedia.Click += new System.EventHandler(this.MnuMedia_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estatistica.Properties.Resources.Altura;
            this.pictureBox1.Location = new System.Drawing.Point(269, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 533);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol e Média";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblMedia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LstRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LstFornecida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblOrdinal;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuDetalhes;
        private System.Windows.Forms.ToolStripMenuItem MnuLimpar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuSobre;
        private System.Windows.Forms.ToolStripMenuItem MnuEstatistica;
        private System.Windows.Forms.ToolStripMenuItem MnuRol;
        private System.Windows.Forms.ToolStripMenuItem MnuMedia;
        private System.Windows.Forms.Timer timer1;
    }
}

