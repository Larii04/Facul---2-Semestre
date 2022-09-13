namespace TP07
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PbxMaze = new System.Windows.Forms.PictureBox();
            this.PbxAvatar = new System.Windows.Forms.PictureBox();
            this.Pbx1 = new System.Windows.Forms.PictureBox();
            this.Pbx3 = new System.Windows.Forms.PictureBox();
            this.Pbx2 = new System.Windows.Forms.PictureBox();
            this.Pbx4 = new System.Windows.Forms.PictureBox();
            this.Pbx5 = new System.Windows.Forms.PictureBox();
            this.PbxGameOver = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Seg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbxMaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbxMaze
            // 
            this.PbxMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxMaze.BackColor = System.Drawing.Color.Transparent;
            this.PbxMaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbxMaze.Image = ((System.Drawing.Image)(resources.GetObject("PbxMaze.Image")));
            this.PbxMaze.Location = new System.Drawing.Point(3, 3);
            this.PbxMaze.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PbxMaze.Name = "PbxMaze";
            this.PbxMaze.Size = new System.Drawing.Size(1025, 785);
            this.PbxMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxMaze.TabIndex = 1;
            this.PbxMaze.TabStop = false;
            // 
            // PbxAvatar
            // 
            this.PbxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.PbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("PbxAvatar.Image")));
            this.PbxAvatar.Location = new System.Drawing.Point(53, 9);
            this.PbxAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.PbxAvatar.Name = "PbxAvatar";
            this.PbxAvatar.Size = new System.Drawing.Size(40, 60);
            this.PbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxAvatar.TabIndex = 2;
            this.PbxAvatar.TabStop = false;
            // 
            // Pbx1
            // 
            this.Pbx1.BackColor = System.Drawing.Color.White;
            this.Pbx1.Image = ((System.Drawing.Image)(resources.GetObject("Pbx1.Image")));
            this.Pbx1.Location = new System.Drawing.Point(174, 31);
            this.Pbx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pbx1.Name = "Pbx1";
            this.Pbx1.Size = new System.Drawing.Size(47, 52);
            this.Pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx1.TabIndex = 7;
            this.Pbx1.TabStop = false;
            // 
            // Pbx3
            // 
            this.Pbx3.BackColor = System.Drawing.Color.White;
            this.Pbx3.Image = ((System.Drawing.Image)(resources.GetObject("Pbx3.Image")));
            this.Pbx3.Location = new System.Drawing.Point(278, 279);
            this.Pbx3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pbx3.Name = "Pbx3";
            this.Pbx3.Size = new System.Drawing.Size(47, 52);
            this.Pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx3.TabIndex = 8;
            this.Pbx3.TabStop = false;
            // 
            // Pbx2
            // 
            this.Pbx2.BackColor = System.Drawing.Color.White;
            this.Pbx2.Image = ((System.Drawing.Image)(resources.GetObject("Pbx2.Image")));
            this.Pbx2.Location = new System.Drawing.Point(739, 211);
            this.Pbx2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pbx2.Name = "Pbx2";
            this.Pbx2.Size = new System.Drawing.Size(47, 52);
            this.Pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx2.TabIndex = 9;
            this.Pbx2.TabStop = false;
            // 
            // Pbx4
            // 
            this.Pbx4.BackColor = System.Drawing.Color.White;
            this.Pbx4.Image = ((System.Drawing.Image)(resources.GetObject("Pbx4.Image")));
            this.Pbx4.Location = new System.Drawing.Point(174, 590);
            this.Pbx4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pbx4.Name = "Pbx4";
            this.Pbx4.Size = new System.Drawing.Size(47, 52);
            this.Pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx4.TabIndex = 10;
            this.Pbx4.TabStop = false;
            // 
            // Pbx5
            // 
            this.Pbx5.BackColor = System.Drawing.Color.White;
            this.Pbx5.Image = ((System.Drawing.Image)(resources.GetObject("Pbx5.Image")));
            this.Pbx5.Location = new System.Drawing.Point(749, 658);
            this.Pbx5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pbx5.Name = "Pbx5";
            this.Pbx5.Size = new System.Drawing.Size(47, 52);
            this.Pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx5.TabIndex = 11;
            this.Pbx5.TabStop = false;
            // 
            // PbxGameOver
            // 
            this.PbxGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxGameOver.BackColor = System.Drawing.Color.Transparent;
            this.PbxGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbxGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxGameOver.Image = ((System.Drawing.Image)(resources.GetObject("PbxGameOver.Image")));
            this.PbxGameOver.Location = new System.Drawing.Point(174, 106);
            this.PbxGameOver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PbxGameOver.Name = "PbxGameOver";
            this.PbxGameOver.Size = new System.Drawing.Size(683, 604);
            this.PbxGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxGameOver.TabIndex = 12;
            this.PbxGameOver.TabStop = false;
            this.PbxGameOver.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1063, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tempo Restante: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Seg
            // 
            this.Lbl_Seg.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Seg.ForeColor = System.Drawing.Color.Purple;
            this.Lbl_Seg.Location = new System.Drawing.Point(1069, 101);
            this.Lbl_Seg.Name = "Lbl_Seg";
            this.Lbl_Seg.Size = new System.Drawing.Size(232, 36);
            this.Lbl_Seg.TabIndex = 15;
            this.Lbl_Seg.Text = "label1";
            this.Lbl_Seg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 171);
            this.label2.TabIndex = 13;
            this.label2.Text = "Para andar utilizar  as teclas WASD do teclado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 216);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1063, 419);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 369);
            this.panel1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1329, 822);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Seg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PbxGameOver);
            this.Controls.Add(this.Pbx5);
            this.Controls.Add(this.Pbx4);
            this.Controls.Add(this.Pbx2);
            this.Controls.Add(this.Pbx3);
            this.Controls.Add(this.Pbx1);
            this.Controls.Add(this.PbxAvatar);
            this.Controls.Add(this.PbxMaze);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirinto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PbxMaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxMaze;
        public System.Windows.Forms.PictureBox PbxAvatar;
        private System.Windows.Forms.PictureBox Pbx1;
        private System.Windows.Forms.PictureBox Pbx3;
        private System.Windows.Forms.PictureBox Pbx2;
        private System.Windows.Forms.PictureBox Pbx4;
        private System.Windows.Forms.PictureBox Pbx5;
        private System.Windows.Forms.PictureBox PbxGameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Seg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

