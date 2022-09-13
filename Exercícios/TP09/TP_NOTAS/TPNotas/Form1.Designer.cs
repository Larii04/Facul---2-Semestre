namespace TPNotas
{
    partial class Frm_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Disc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Serie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Matricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_1bim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_2bim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_3bim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_4bim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Media = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Conc = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Dts_Notas = new System.Data.DataSet();
            this.Dtb_Notas = new System.Data.DataTable();
            this.Dtc_Id = new System.Data.DataColumn();
            this.Dtc_Serie = new System.Data.DataColumn();
            this.Dtc_Matricula = new System.Data.DataColumn();
            this.Dtc_NotaPriBi = new System.Data.DataColumn();
            this.Dtc_SegBi = new System.Data.DataColumn();
            this.Dtc_NotaTerBi = new System.Data.DataColumn();
            this.Dtc_NotaQuaBi = new System.Data.DataColumn();
            this.Dtc_Media = new System.Data.DataColumn();
            this.Dtc_Conceito = new System.Data.DataColumn();
            this.Dtc_Disc = new System.Data.DataColumn();
            this.Bsc_Notas = new System.Windows.Forms.BindingSource(this.components);
            this.Dgv_Notas = new System.Windows.Forms.DataGridView();
            this.Disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaPriBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaSegBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaTerBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaQuaBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cbx_Pesquisa = new System.Windows.Forms.ComboBox();
            this.Txt_Filtro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Txt_Linha = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Txt_Coluna = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Dts_Notas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtb_Notas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bsc_Notas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Notas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Disciplina: ";
            // 
            // Txt_Disc
            // 
            this.Txt_Disc.Location = new System.Drawing.Point(166, 26);
            this.Txt_Disc.Name = "Txt_Disc";
            this.Txt_Disc.Size = new System.Drawing.Size(245, 22);
            this.Txt_Disc.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Série: ";
            // 
            // Txt_Serie
            // 
            this.Txt_Serie.Location = new System.Drawing.Point(610, 26);
            this.Txt_Serie.Name = "Txt_Serie";
            this.Txt_Serie.Size = new System.Drawing.Size(91, 22);
            this.Txt_Serie.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de Matricula do Aluno:";
            // 
            // Txt_Matricula
            // 
            this.Txt_Matricula.Location = new System.Drawing.Point(232, 66);
            this.Txt_Matricula.Name = "Txt_Matricula";
            this.Txt_Matricula.Size = new System.Drawing.Size(179, 22);
            this.Txt_Matricula.TabIndex = 4;
            this.Txt_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "1º Bimestre: ";
            // 
            // Txt_1bim
            // 
            this.Txt_1bim.Location = new System.Drawing.Point(96, 28);
            this.Txt_1bim.MaxLength = 4;
            this.Txt_1bim.Name = "Txt_1bim";
            this.Txt_1bim.Size = new System.Drawing.Size(69, 22);
            this.Txt_1bim.TabIndex = 6;
            this.Txt_1bim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.Txt_1bim.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_1bim_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "2º Bimestre: ";
            // 
            // Txt_2bim
            // 
            this.Txt_2bim.Location = new System.Drawing.Point(269, 28);
            this.Txt_2bim.MaxLength = 4;
            this.Txt_2bim.Name = "Txt_2bim";
            this.Txt_2bim.Size = new System.Drawing.Size(69, 22);
            this.Txt_2bim.TabIndex = 8;
            this.Txt_2bim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.Txt_2bim.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_2bim_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "3º Bimestre: ";
            // 
            // Txt_3bim
            // 
            this.Txt_3bim.Location = new System.Drawing.Point(442, 28);
            this.Txt_3bim.MaxLength = 4;
            this.Txt_3bim.Name = "Txt_3bim";
            this.Txt_3bim.Size = new System.Drawing.Size(69, 22);
            this.Txt_3bim.TabIndex = 10;
            this.Txt_3bim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.Txt_3bim.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_3bim_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "4º Bimestre: ";
            // 
            // Txt_4bim
            // 
            this.Txt_4bim.Location = new System.Drawing.Point(615, 28);
            this.Txt_4bim.MaxLength = 4;
            this.Txt_4bim.Name = "Txt_4bim";
            this.Txt_4bim.Size = new System.Drawing.Size(69, 22);
            this.Txt_4bim.TabIndex = 12;
            this.Txt_4bim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.Txt_4bim.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_4bim_Validating);
            this.Txt_4bim.Validated += new System.EventHandler(this.Txt_4bim_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Média Final: ";
            // 
            // Txt_Media
            // 
            this.Txt_Media.Enabled = false;
            this.Txt_Media.Location = new System.Drawing.Point(181, 34);
            this.Txt_Media.MaxLength = 4;
            this.Txt_Media.Name = "Txt_Media";
            this.Txt_Media.Size = new System.Drawing.Size(161, 22);
            this.Txt_Media.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Conceito: ";
            // 
            // Txt_Conc
            // 
            this.Txt_Conc.Enabled = false;
            this.Txt_Conc.Location = new System.Drawing.Point(181, 74);
            this.Txt_Conc.Name = "Txt_Conc";
            this.Txt_Conc.Size = new System.Drawing.Size(161, 22);
            this.Txt_Conc.TabIndex = 16;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(116, 132);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(156, 45);
            this.Btn_Add.TabIndex = 18;
            this.Btn_Add.Text = "&Adicionar Cadastro";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Dts_Notas
            // 
            this.Dts_Notas.DataSetName = "DataSetNotas";
            this.Dts_Notas.Tables.AddRange(new System.Data.DataTable[] {
            this.Dtb_Notas});
            // 
            // Dtb_Notas
            // 
            this.Dtb_Notas.Columns.AddRange(new System.Data.DataColumn[] {
            this.Dtc_Id,
            this.Dtc_Serie,
            this.Dtc_Matricula,
            this.Dtc_NotaPriBi,
            this.Dtc_SegBi,
            this.Dtc_NotaTerBi,
            this.Dtc_NotaQuaBi,
            this.Dtc_Media,
            this.Dtc_Conceito,
            this.Dtc_Disc});
            this.Dtb_Notas.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Indice"}, false)});
            this.Dtb_Notas.TableName = "Notas";
            // 
            // Dtc_Id
            // 
            this.Dtc_Id.AutoIncrement = true;
            this.Dtc_Id.ColumnName = "Indice";
            this.Dtc_Id.DataType = typeof(int);
            this.Dtc_Id.ReadOnly = true;
            // 
            // Dtc_Serie
            // 
            this.Dtc_Serie.Caption = "Série";
            this.Dtc_Serie.ColumnName = "Serie";
            // 
            // Dtc_Matricula
            // 
            this.Dtc_Matricula.Caption = "Matrícula";
            this.Dtc_Matricula.ColumnName = "Matricula";
            // 
            // Dtc_NotaPriBi
            // 
            this.Dtc_NotaPriBi.Caption = "Nota Primeiro Bimestre";
            this.Dtc_NotaPriBi.ColumnName = "NotaPriBi";
            // 
            // Dtc_SegBi
            // 
            this.Dtc_SegBi.ColumnName = "NotaSegBi";
            // 
            // Dtc_NotaTerBi
            // 
            this.Dtc_NotaTerBi.ColumnName = "NotaTerBi";
            // 
            // Dtc_NotaQuaBi
            // 
            this.Dtc_NotaQuaBi.ColumnName = "NotaQuaBi";
            // 
            // Dtc_Media
            // 
            this.Dtc_Media.ColumnName = "Media";
            // 
            // Dtc_Conceito
            // 
            this.Dtc_Conceito.ColumnName = "Conceito";
            // 
            // Dtc_Disc
            // 
            this.Dtc_Disc.ColumnName = "Disciplina";
            // 
            // Bsc_Notas
            // 
            this.Bsc_Notas.DataMember = "Notas";
            this.Bsc_Notas.DataSource = this.Dts_Notas;
            // 
            // Dgv_Notas
            // 
            this.Dgv_Notas.AllowUserToAddRows = false;
            this.Dgv_Notas.AllowUserToResizeColumns = false;
            this.Dgv_Notas.AutoGenerateColumns = false;
            this.Dgv_Notas.BackgroundColor = System.Drawing.Color.Thistle;
            this.Dgv_Notas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Notas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Notas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Disciplina,
            this.serieDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.notaPriBiDataGridViewTextBoxColumn,
            this.notaSegBiDataGridViewTextBoxColumn,
            this.notaTerBiDataGridViewTextBoxColumn,
            this.notaQuaBiDataGridViewTextBoxColumn,
            this.mediaDataGridViewTextBoxColumn,
            this.conceitoDataGridViewTextBoxColumn});
            this.Dgv_Notas.DataSource = this.Bsc_Notas;
            this.Dgv_Notas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dgv_Notas.Location = new System.Drawing.Point(14, 337);
            this.Dgv_Notas.Name = "Dgv_Notas";
            this.Dgv_Notas.RowHeadersWidth = 51;
            this.Dgv_Notas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_Notas.RowTemplate.Height = 24;
            this.Dgv_Notas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Notas.Size = new System.Drawing.Size(1155, 197);
            this.Dgv_Notas.TabIndex = 19;
            // 
            // Disciplina
            // 
            this.Disciplina.DataPropertyName = "Disciplina";
            this.Disciplina.HeaderText = "Nome da Disciplina";
            this.Disciplina.MinimumWidth = 6;
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.Width = 125;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Série";
            this.serieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.Width = 125;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matrícula";
            this.matriculaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.Width = 125;
            // 
            // notaPriBiDataGridViewTextBoxColumn
            // 
            this.notaPriBiDataGridViewTextBoxColumn.DataPropertyName = "NotaPriBi";
            this.notaPriBiDataGridViewTextBoxColumn.HeaderText = "Nota 1º Bim.";
            this.notaPriBiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notaPriBiDataGridViewTextBoxColumn.Name = "notaPriBiDataGridViewTextBoxColumn";
            this.notaPriBiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.notaPriBiDataGridViewTextBoxColumn.Width = 68;
            // 
            // notaSegBiDataGridViewTextBoxColumn
            // 
            this.notaSegBiDataGridViewTextBoxColumn.DataPropertyName = "NotaSegBi";
            this.notaSegBiDataGridViewTextBoxColumn.HeaderText = "Nota 2º Bim.";
            this.notaSegBiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notaSegBiDataGridViewTextBoxColumn.Name = "notaSegBiDataGridViewTextBoxColumn";
            this.notaSegBiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.notaSegBiDataGridViewTextBoxColumn.Width = 68;
            // 
            // notaTerBiDataGridViewTextBoxColumn
            // 
            this.notaTerBiDataGridViewTextBoxColumn.DataPropertyName = "NotaTerBi";
            this.notaTerBiDataGridViewTextBoxColumn.HeaderText = "Nota 3º Bim.";
            this.notaTerBiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notaTerBiDataGridViewTextBoxColumn.Name = "notaTerBiDataGridViewTextBoxColumn";
            this.notaTerBiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.notaTerBiDataGridViewTextBoxColumn.Width = 68;
            // 
            // notaQuaBiDataGridViewTextBoxColumn
            // 
            this.notaQuaBiDataGridViewTextBoxColumn.DataPropertyName = "NotaQuaBi";
            this.notaQuaBiDataGridViewTextBoxColumn.HeaderText = "Nota 4º Bim.";
            this.notaQuaBiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notaQuaBiDataGridViewTextBoxColumn.Name = "notaQuaBiDataGridViewTextBoxColumn";
            this.notaQuaBiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.notaQuaBiDataGridViewTextBoxColumn.Width = 68;
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "Media";
            this.mediaDataGridViewTextBoxColumn.HeaderText = "Média";
            this.mediaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            this.mediaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mediaDataGridViewTextBoxColumn.Width = 70;
            // 
            // conceitoDataGridViewTextBoxColumn
            // 
            this.conceitoDataGridViewTextBoxColumn.DataPropertyName = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.HeaderText = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conceitoDataGridViewTextBoxColumn.Name = "conceitoDataGridViewTextBoxColumn";
            this.conceitoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Cbx_Pesquisa
            // 
            this.Cbx_Pesquisa.FormattingEnabled = true;
            this.Cbx_Pesquisa.Items.AddRange(new object[] {
            "Disciplina",
            "Série",
            "Número de Matrícula"});
            this.Cbx_Pesquisa.Location = new System.Drawing.Point(735, 293);
            this.Cbx_Pesquisa.Name = "Cbx_Pesquisa";
            this.Cbx_Pesquisa.Size = new System.Drawing.Size(178, 24);
            this.Cbx_Pesquisa.TabIndex = 20;
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.Location = new System.Drawing.Point(982, 294);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(187, 22);
            this.Txt_Filtro.TabIndex = 22;
            this.Txt_Filtro.TextChanged += new System.EventHandler(this.Txt_Filtro_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(628, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Procurar por:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(929, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Filtro: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_1bim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_2bim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_3bim);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txt_4bim);
            this.groupBox1.Location = new System.Drawing.Point(17, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 72);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_Disc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_Serie);
            this.panel1.Controls.Add(this.Txt_Matricula);
            this.panel1.Location = new System.Drawing.Point(20, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 204);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Txt_Media);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Txt_Conc);
            this.panel2.Location = new System.Drawing.Point(784, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 204);
            this.panel2.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.exportarToolStripMenuItem.Text = "&Exportar";
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Txt_Linha,
            this.Mnu_Txt_Coluna});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.textoToolStripMenuItem.Text = "&Texto";
            // 
            // Mnu_Txt_Linha
            // 
            this.Mnu_Txt_Linha.Name = "Mnu_Txt_Linha";
            this.Mnu_Txt_Linha.Size = new System.Drawing.Size(163, 26);
            this.Mnu_Txt_Linha.Text = "Por &Linha";
            this.Mnu_Txt_Linha.Click += new System.EventHandler(this.porLinhaToolStripMenuItem_Click);
            // 
            // Mnu_Txt_Coluna
            // 
            this.Mnu_Txt_Coluna.Name = "Mnu_Txt_Coluna";
            this.Mnu_Txt_Coluna.Size = new System.Drawing.Size(163, 26);
            this.Mnu_Txt_Coluna.Text = "Por &Coluna";
            this.Mnu_Txt_Coluna.Click += new System.EventHandler(this.Mnu_Txt_Coluna_Click);
            // 
            // Frm_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1190, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Filtro);
            this.Controls.Add(this.Cbx_Pesquisa);
            this.Controls.Add(this.Dgv_Notas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Notas de Alunos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm__FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Dts_Notas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtb_Notas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bsc_Notas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Notas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Disc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Serie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Matricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_1bim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_2bim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_3bim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_4bim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Media;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Conc;
        private System.Windows.Forms.Button Btn_Add;
        private System.Data.DataSet Dts_Notas;
        private System.Data.DataTable Dtb_Notas;
        private System.Data.DataColumn Dtc_Id;
        private System.Data.DataColumn Dtc_Serie;
        private System.Data.DataColumn Dtc_Matricula;
        private System.Data.DataColumn Dtc_NotaPriBi;
        private System.Data.DataColumn Dtc_SegBi;
        private System.Data.DataColumn Dtc_NotaTerBi;
        private System.Data.DataColumn Dtc_NotaQuaBi;
        private System.Data.DataColumn Dtc_Media;
        private System.Data.DataColumn Dtc_Conceito;
        private System.Windows.Forms.BindingSource Bsc_Notas;
        private System.Windows.Forms.DataGridView Dgv_Notas;
        private System.Data.DataColumn Dtc_Disc;
        private System.Windows.Forms.ComboBox Cbx_Pesquisa;
        private System.Windows.Forms.TextBox Txt_Filtro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaPriBiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaSegBiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaTerBiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaQuaBiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Txt_Linha;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Txt_Coluna;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

