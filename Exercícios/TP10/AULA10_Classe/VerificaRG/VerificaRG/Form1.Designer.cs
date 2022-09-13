namespace VerificaRG
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
            this.TxtRG = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnVerifica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtRG
            // 
            this.TxtRG.Location = new System.Drawing.Point(125, 38);
            this.TxtRG.MaxLength = 12;
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(108, 26);
            this.TxtRG.TabIndex = 1;
            this.TxtRG.Text = "91.122.534-1";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Image = global::VerificaRG.Properties.Resources.apagar;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLimpar.Location = new System.Drawing.Point(586, 305);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(108, 98);
            this.BtnLimpar.TabIndex = 3;
            this.BtnLimpar.Text = "&Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnVerifica
            // 
            this.BtnVerifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerifica.Image = global::VerificaRG.Properties.Resources.verifica;
            this.BtnVerifica.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVerifica.Location = new System.Drawing.Point(587, 12);
            this.BtnVerifica.Name = "BtnVerifica";
            this.BtnVerifica.Size = new System.Drawing.Size(108, 88);
            this.BtnVerifica.TabIndex = 2;
            this.BtnVerifica.Text = "&Verifica";
            this.BtnVerifica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVerifica.UseVisualStyleBackColor = true;
            this.BtnVerifica.Click += new System.EventHandler(this.BtnVerifica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VerificaRG.Properties.Resources.rg;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TxtResultado);
            this.panel1.Location = new System.Drawing.Point(589, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 184);
            this.panel1.TabIndex = 4;
            // 
            // TxtResultado
            // 
            this.TxtResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultado.ForeColor = System.Drawing.Color.Red;
            this.TxtResultado.Location = new System.Drawing.Point(3, 97);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.Size = new System.Drawing.Size(93, 53);
            this.TxtResultado.TabIndex = 0;
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(9, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(87, 66);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Resposta da Consulta";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(698, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnVerifica);
            this.Controls.Add(this.TxtRG);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação do RG - Estado de SÃO PAULO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtRG;
        private System.Windows.Forms.Button BtnVerifica;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtResultado;
    }
}

