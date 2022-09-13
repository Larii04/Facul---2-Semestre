namespace Prova_P2
{
    partial class Frm_Manutencao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Str_Menu = new System.Windows.Forms.MenuStrip();
            this.Str_Exportar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Linha = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Txt_Situacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MTxt_Data = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Equipamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Busca = new System.Windows.Forms.TextBox();
            this.Cbx_Busca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtsEquipamentos = new System.Data.DataSet();
            this.BscLaboratorio = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dgv_Cadastro = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Dtb_Cadastro = new System.Data.DataTable();
            this.Dtc_Nome = new System.Data.DataColumn();
            this.Dtc_Equipamento = new System.Data.DataColumn();
            this.Dtc_Data = new System.Data.DataColumn();
            this.Dtc_Motivo = new System.Data.DataColumn();
            this.Dtc_Situação = new System.Data.DataColumn();
            this.nomeDoMonitoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Str_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtsEquipamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BscLaboratorio)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtb_Cadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // Str_Menu
            // 
            this.Str_Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Str_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Str_Exportar});
            this.Str_Menu.Location = new System.Drawing.Point(0, 0);
            this.Str_Menu.Name = "Str_Menu";
            this.Str_Menu.Size = new System.Drawing.Size(870, 24);
            this.Str_Menu.TabIndex = 0;
            this.Str_Menu.Text = "menuStrip1";
            // 
            // Str_Exportar
            // 
            this.Str_Exportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Linha});
            this.Str_Exportar.Name = "Str_Exportar";
            this.Str_Exportar.Size = new System.Drawing.Size(63, 20);
            this.Str_Exportar.Text = "Exportar";
            // 
            // Mnu_Linha
            // 
            this.Mnu_Linha.Name = "Mnu_Linha";
            this.Mnu_Linha.Size = new System.Drawing.Size(180, 22);
            this.Mnu_Linha.Text = "TXT Por Linha";
            this.Mnu_Linha.Click += new System.EventHandler(this.Mnu_Linha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Monitor(a)";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(18, 31);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(124, 22);
            this.Txt_Nome.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_Salvar);
            this.panel1.Controls.Add(this.Txt_Situacao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Txt_Motivo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MTxt_Data);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Equipamento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_Nome);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 72);
            this.panel1.TabIndex = 3;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.Location = new System.Drawing.Point(770, 31);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(56, 23);
            this.Btn_Salvar.TabIndex = 11;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Txt_Situacao
            // 
            this.Txt_Situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Situacao.Location = new System.Drawing.Point(631, 31);
            this.Txt_Situacao.Name = "Txt_Situacao";
            this.Txt_Situacao.Size = new System.Drawing.Size(124, 22);
            this.Txt_Situacao.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Situação";
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Motivo.Location = new System.Drawing.Point(478, 31);
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.Size = new System.Drawing.Size(124, 22);
            this.Txt_Motivo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Motivo";
            // 
            // MTxt_Data
            // 
            this.MTxt_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxt_Data.Location = new System.Drawing.Point(328, 31);
            this.MTxt_Data.Mask = "00/00/0000";
            this.MTxt_Data.Name = "MTxt_Data";
            this.MTxt_Data.Size = new System.Drawing.Size(100, 22);
            this.MTxt_Data.TabIndex = 6;
            this.MTxt_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTxt_Data.ValidatingType = typeof(System.DateTime);
            this.MTxt_Data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificaData);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data da Manutenção";
            // 
            // Txt_Equipamento
            // 
            this.Txt_Equipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Equipamento.Location = new System.Drawing.Point(174, 31);
            this.Txt_Equipamento.Name = "Txt_Equipamento";
            this.Txt_Equipamento.Size = new System.Drawing.Size(124, 22);
            this.Txt_Equipamento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipamento";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Txt_Busca);
            this.panel2.Controls.Add(this.Cbx_Busca);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 46);
            this.panel2.TabIndex = 4;
            // 
            // Txt_Busca
            // 
            this.Txt_Busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Busca.Location = new System.Drawing.Point(507, 14);
            this.Txt_Busca.Name = "Txt_Busca";
            this.Txt_Busca.Size = new System.Drawing.Size(124, 22);
            this.Txt_Busca.TabIndex = 11;
            this.Txt_Busca.TextChanged += new System.EventHandler(this.Txt_Busca_TextChanged);
            // 
            // Cbx_Busca
            // 
            this.Cbx_Busca.FormattingEnabled = true;
            this.Cbx_Busca.Items.AddRange(new object[] {
            "Equipamento",
            "Data",
            "Situação"});
            this.Cbx_Busca.Location = new System.Drawing.Point(96, 17);
            this.Cbx_Busca.Name = "Cbx_Busca";
            this.Cbx_Busca.Size = new System.Drawing.Size(188, 21);
            this.Cbx_Busca.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Informe o dado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Busca por:";
            // 
            // DtsEquipamentos
            // 
            this.DtsEquipamentos.DataSetName = "Equipamentos";
            this.DtsEquipamentos.Tables.AddRange(new System.Data.DataTable[] {
            this.Dtb_Cadastro});
            // 
            // BscLaboratorio
            // 
            this.BscLaboratorio.DataMember = "Cadastro";
            this.BscLaboratorio.DataSource = this.DtsEquipamentos;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Dgv_Cadastro);
            this.panel3.Location = new System.Drawing.Point(13, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 160);
            this.panel3.TabIndex = 5;
            // 
            // Dgv_Cadastro
            // 
            this.Dgv_Cadastro.AllowUserToDeleteRows = false;
            this.Dgv_Cadastro.AutoGenerateColumns = false;
            this.Dgv_Cadastro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv_Cadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDoMonitoraDataGridViewTextBoxColumn,
            this.equipamentoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.motivoDataGridViewTextBoxColumn,
            this.situaçãoDataGridViewTextBoxColumn});
            this.Dgv_Cadastro.DataSource = this.BscLaboratorio;
            this.Dgv_Cadastro.Location = new System.Drawing.Point(3, 3);
            this.Dgv_Cadastro.Name = "Dgv_Cadastro";
            this.Dgv_Cadastro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Dgv_Cadastro.Size = new System.Drawing.Size(825, 150);
            this.Dgv_Cadastro.StandardTab = true;
            this.Dgv_Cadastro.TabIndex = 2;
            // 
            // Dtb_Cadastro
            // 
            this.Dtb_Cadastro.Columns.AddRange(new System.Data.DataColumn[] {
            this.Dtc_Nome,
            this.Dtc_Equipamento,
            this.Dtc_Data,
            this.Dtc_Motivo,
            this.Dtc_Situação});
            this.Dtb_Cadastro.TableName = "Cadastro";
            // 
            // Dtc_Nome
            // 
            this.Dtc_Nome.Caption = "Nome";
            this.Dtc_Nome.ColumnName = "Nome do Monitor(a)";
            // 
            // Dtc_Equipamento
            // 
            this.Dtc_Equipamento.Caption = "Equipamento";
            this.Dtc_Equipamento.ColumnName = "Equipamento";
            // 
            // Dtc_Data
            // 
            this.Dtc_Data.Caption = "Data";
            this.Dtc_Data.ColumnName = "Data";
            // 
            // Dtc_Motivo
            // 
            this.Dtc_Motivo.Caption = "Motivo";
            this.Dtc_Motivo.ColumnName = "Motivo";
            // 
            // Dtc_Situação
            // 
            this.Dtc_Situação.Caption = "Situação";
            this.Dtc_Situação.ColumnName = "Situação";
            // 
            // nomeDoMonitoraDataGridViewTextBoxColumn
            // 
            this.nomeDoMonitoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nomeDoMonitoraDataGridViewTextBoxColumn.DataPropertyName = "Nome do Monitor(a)";
            this.nomeDoMonitoraDataGridViewTextBoxColumn.HeaderText = "Nome do Monitor(a)";
            this.nomeDoMonitoraDataGridViewTextBoxColumn.Name = "nomeDoMonitoraDataGridViewTextBoxColumn";
            this.nomeDoMonitoraDataGridViewTextBoxColumn.Width = 114;
            // 
            // equipamentoDataGridViewTextBoxColumn
            // 
            this.equipamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.equipamentoDataGridViewTextBoxColumn.DataPropertyName = "Equipamento";
            this.equipamentoDataGridViewTextBoxColumn.HeaderText = "Equipamento";
            this.equipamentoDataGridViewTextBoxColumn.Name = "equipamentoDataGridViewTextBoxColumn";
            this.equipamentoDataGridViewTextBoxColumn.Width = 94;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 55;
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            this.motivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.motivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo";
            this.motivoDataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            this.motivoDataGridViewTextBoxColumn.Width = 64;
            // 
            // situaçãoDataGridViewTextBoxColumn
            // 
            this.situaçãoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.situaçãoDataGridViewTextBoxColumn.DataPropertyName = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situaçãoDataGridViewTextBoxColumn.Name = "situaçãoDataGridViewTextBoxColumn";
            this.situaçãoDataGridViewTextBoxColumn.Width = 74;
            // 
            // Frm_Manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 331);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Str_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Str_Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Manutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Manutenção";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Manutencao_FormClosing);
            this.Str_Menu.ResumeLayout(false);
            this.Str_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtsEquipamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BscLaboratorio)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtb_Cadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Str_Menu;
        private System.Windows.Forms.ToolStripMenuItem Str_Exportar;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Linha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Situacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MTxt_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Equipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Busca;
        private System.Windows.Forms.ComboBox Cbx_Busca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Data.DataSet DtsEquipamentos;
        private System.Windows.Forms.BindingSource BscLaboratorio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Dgv_Cadastro;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Data.DataTable Dtb_Cadastro;
        private System.Data.DataColumn Dtc_Nome;
        private System.Data.DataColumn Dtc_Equipamento;
        private System.Data.DataColumn Dtc_Data;
        private System.Data.DataColumn Dtc_Motivo;
        private System.Data.DataColumn Dtc_Situação;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDoMonitoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situaçãoDataGridViewTextBoxColumn;
    }
}

