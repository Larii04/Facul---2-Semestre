namespace tp11
{
    partial class Frm_CC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CC));
            this.Btn_Verif = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MTxt_Num = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Verif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Verif
            // 
            this.Btn_Verif.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Verif.Image")));
            this.Btn_Verif.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Verif.Location = new System.Drawing.Point(731, 380);
            this.Btn_Verif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Verif.Name = "Btn_Verif";
            this.Btn_Verif.Size = new System.Drawing.Size(325, 91);
            this.Btn_Verif.TabIndex = 5;
            this.Btn_Verif.Text = "&Verificar";
            this.Btn_Verif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Verif.UseVisualStyleBackColor = true;
            this.Btn_Verif.Click += new System.EventHandler(this.Btn_Verif_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpar.Image")));
            this.Btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpar.Location = new System.Drawing.Point(743, 36);
            this.Btn_Limpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(313, 100);
            this.Btn_Limpar.TabIndex = 6;
            this.Btn_Limpar.Text = "&Limpar";
            this.Btn_Limpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MTxt_Num
            // 
            this.MTxt_Num.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxt_Num.Location = new System.Drawing.Point(49, 246);
            this.MTxt_Num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MTxt_Num.Mask = "0000 0000 0000 0000";
            this.MTxt_Num.Name = "MTxt_Num";
            this.MTxt_Num.Size = new System.Drawing.Size(610, 68);
            this.MTxt_Num.TabIndex = 7;
            this.MTxt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Verif
            // 
            this.Lbl_Verif.AutoSize = true;
            this.Lbl_Verif.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Verif.Location = new System.Drawing.Point(737, 246);
            this.Lbl_Verif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Verif.Name = "Lbl_Verif";
            this.Lbl_Verif.Size = new System.Drawing.Size(319, 34);
            this.Lbl_Verif.TabIndex = 8;
            this.Lbl_Verif.Text = "CARTÃO VERIFICADO";
            // 
            // Frm_CC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 485);
            this.Controls.Add(this.Lbl_Verif);
            this.Controls.Add(this.MTxt_Num);
            this.Controls.Add(this.Btn_Verif);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Cartão de Crédito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_CC_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Verif;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox MTxt_Num;
        private System.Windows.Forms.Label Lbl_Verif;
    }
}

