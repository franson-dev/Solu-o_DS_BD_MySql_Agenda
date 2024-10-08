
namespace DS_BD_MySql_Agenda
{
    partial class Consultorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultorio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.lbValor2 = new System.Windows.Forms.Label();
            this.lbValor1 = new System.Windows.Forms.Label();
            this.lbProcurar = new System.Windows.Forms.Label();
            this.lbColuna = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.cmbCondicao = new System.Windows.Forms.ComboBox();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.dataSet_Agenda = new DS_BD_MySql_Agenda.DataSet_Agenda();
            this.dataSetAgendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new DS_BD_MySql_Agenda.DataSet_AgendaTableAdapters.PessoaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbParametros.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAgendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.btnConsultar);
            this.gbParametros.Controls.Add(this.lbValor2);
            this.gbParametros.Controls.Add(this.lbValor1);
            this.gbParametros.Controls.Add(this.lbProcurar);
            this.gbParametros.Controls.Add(this.lbColuna);
            this.gbParametros.Controls.Add(this.txtValor2);
            this.gbParametros.Controls.Add(this.txtValor1);
            this.gbParametros.Controls.Add(this.cmbCondicao);
            this.gbParametros.Controls.Add(this.cmbColuna);
            this.gbParametros.Location = new System.Drawing.Point(0, 0);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(974, 100);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parâmetros para Consulta";
            // 
            // lbValor2
            // 
            this.lbValor2.AutoSize = true;
            this.lbValor2.Location = new System.Drawing.Point(653, 31);
            this.lbValor2.Name = "lbValor2";
            this.lbValor2.Size = new System.Drawing.Size(65, 20);
            this.lbValor2.TabIndex = 15;
            this.lbValor2.Text = "2º Valor";
            // 
            // lbValor1
            // 
            this.lbValor1.AutoSize = true;
            this.lbValor1.Location = new System.Drawing.Point(445, 31);
            this.lbValor1.Name = "lbValor1";
            this.lbValor1.Size = new System.Drawing.Size(65, 20);
            this.lbValor1.TabIndex = 14;
            this.lbValor1.Text = "1º Valor";
            // 
            // lbProcurar
            // 
            this.lbProcurar.AutoSize = true;
            this.lbProcurar.Location = new System.Drawing.Point(219, 28);
            this.lbProcurar.Name = "lbProcurar";
            this.lbProcurar.Size = new System.Drawing.Size(73, 20);
            this.lbProcurar.TabIndex = 13;
            this.lbProcurar.Text = "Procurar:";
            // 
            // lbColuna
            // 
            this.lbColuna.AutoSize = true;
            this.lbColuna.Location = new System.Drawing.Point(19, 28);
            this.lbColuna.Name = "lbColuna";
            this.lbColuna.Size = new System.Drawing.Size(63, 20);
            this.lbColuna.TabIndex = 12;
            this.lbColuna.Text = "Coluna:";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(657, 54);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(146, 26);
            this.txtValor2.TabIndex = 11;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(445, 54);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(168, 26);
            this.txtValor1.TabIndex = 10;
            // 
            // cmbCondicao
            // 
            this.cmbCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicao.FormattingEnabled = true;
            this.cmbCondicao.Items.AddRange(new object[] {
            "Todos",
            "Igual a",
            "Começa",
            "Contém",
            "Termina",
            "Esteja entre"});
            this.cmbCondicao.Location = new System.Drawing.Point(223, 54);
            this.cmbCondicao.Name = "cmbCondicao";
            this.cmbCondicao.Size = new System.Drawing.Size(184, 28);
            this.cmbCondicao.TabIndex = 9;
            // 
            // cmbColuna
            // 
            this.cmbColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Endereco",
            "Cidade",
            "Email"});
            this.cmbColuna.Location = new System.Drawing.Point(23, 54);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(171, 28);
            this.cmbColuna.TabIndex = 8;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(821, 44);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 46);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.dgvInfo);
            this.gbFiltro.Location = new System.Drawing.Point(0, 106);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(974, 332);
            this.gbFiltro.TabIndex = 17;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Dados Filtrados";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn});
            this.dgvInfo.DataSource = this.pessoaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfo.Location = new System.Drawing.Point(12, 42);
            this.dgvInfo.Name = "dgvInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfo.RowHeadersWidth = 62;
            this.dgvInfo.RowTemplate.Height = 28;
            this.dgvInfo.Size = new System.Drawing.Size(945, 268);
            this.dgvInfo.TabIndex = 0;
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAgendaBindingSource
            // 
            this.dataSetAgendaBindingSource.DataSource = this.dataSet_Agenda;
            this.dataSetAgendaBindingSource.Position = 0;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.dataSetAgendaBindingSource;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.Width = 150;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "Data_Nasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.dataNascDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            this.dataNascDataGridViewTextBoxColumn.Width = 150;
            // 
            // Consultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.gbParametros);
            this.Name = "Consultorio";
            this.Text = "Consultorio";
            this.Load += new System.EventHandler(this.Consultorio_Load);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAgendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lbValor2;
        private System.Windows.Forms.Label lbValor1;
        private System.Windows.Forms.Label lbProcurar;
        private System.Windows.Forms.Label lbColuna;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.ComboBox cmbCondicao;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.BindingSource dataSetAgendaBindingSource;
        private DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DataSet_AgendaTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
    }
}