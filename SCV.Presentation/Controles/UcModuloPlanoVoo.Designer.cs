namespace SCV.Presentation.Controles
{
    partial class UcModuloPlanoVoo
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPlanosVoo = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.NUMERO_VOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.ckbCentroOperacaoOri = new System.Windows.Forms.CheckBox();
            this.ckbCentroOperacaoDes = new System.Windows.Forms.CheckBox();
            this.txtFiltroNumeroVoo = new SCV.Presentation.UI.UcLabelTextBox();
            this.iDSCVPLANOVOODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSCVCOMPANHIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSCVFROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTVOODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMCOMPANHIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANHIAICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMMATRICULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENTROOPERACAOORIGEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENTROOPERACAODESTINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTCADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTATUALIZACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWSCVPLANOVOOINFORMACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seletorCentroOperacaoDes = new SCV.Presentation.UI.UcSeletorCentroOperacao();
            this.sltCompanhia = new SCV.Presentation.UI.UcSeletor();
            this.seletorFrota = new SCV.Presentation.UI.UcSeletorFrota();
            this.seletorCentroOperacaoOri = new SCV.Presentation.UI.UcSeletorCentroOperacao();
            this.dtVoo = new SCV.Presentation.UI.UcLabelDateTimePicker();
            this.txtNumeroVoo = new SCV.Presentation.UI.UcLabelTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanosVoo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWSCVPLANOVOOINFORMACAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(947, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Móduulo de Plano de Voo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(782, 108);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(156, 36);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.seletorCentroOperacaoDes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.sltCompanhia, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.seletorFrota, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.seletorCentroOperacaoOri, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtVoo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumeroVoo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 145);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvPlanosVoo);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 381);
            this.panel1.TabIndex = 9;
            // 
            // dgvPlanosVoo
            // 
            this.dgvPlanosVoo.AllowUserToAddRows = false;
            this.dgvPlanosVoo.AllowUserToDeleteRows = false;
            this.dgvPlanosVoo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanosVoo.AutoGenerateColumns = false;
            this.dgvPlanosVoo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanosVoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanosVoo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSCVPLANOVOODataGridViewTextBoxColumn,
            this.iDSCVCOMPANHIADataGridViewTextBoxColumn,
            this.iDSCVFROTADataGridViewTextBoxColumn,
            this.iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn,
            this.iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn,
            this.dTVOODataGridViewTextBoxColumn,
            this.NUMERO_VOO,
            this.nMCOMPANHIADataGridViewTextBoxColumn,
            this.cOMPANHIAICAODataGridViewTextBoxColumn,
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn,
            this.nMMATRICULADataGridViewTextBoxColumn,
            this.nRSERIEDataGridViewTextBoxColumn,
            this.cENTROOPERACAOORIGEMDataGridViewTextBoxColumn,
            this.cENTROOPERACAODESTINODataGridViewTextBoxColumn,
            this.dTCADASTRODataGridViewTextBoxColumn,
            this.dTATUALIZACAODataGridViewTextBoxColumn,
            this.Editar,
            this.Excluir});
            this.dgvPlanosVoo.DataSource = this.vWSCVPLANOVOOINFORMACAOBindingSource;
            this.dgvPlanosVoo.Location = new System.Drawing.Point(3, 197);
            this.dgvPlanosVoo.Name = "dgvPlanosVoo";
            this.dgvPlanosVoo.ReadOnly = true;
            this.dgvPlanosVoo.RowHeadersVisible = false;
            this.dgvPlanosVoo.Size = new System.Drawing.Size(935, 181);
            this.dgvPlanosVoo.TabIndex = 9;
            this.dgvPlanosVoo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanosVoo_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(3, 108);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 36);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // NUMERO_VOO
            // 
            this.NUMERO_VOO.DataPropertyName = "NUMERO_VOO";
            this.NUMERO_VOO.HeaderText = "NUMERO VOO";
            this.NUMERO_VOO.Name = "NUMERO_VOO";
            this.NUMERO_VOO.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckbCentroOperacaoDes);
            this.groupBox1.Controls.Add(this.txtFiltroNumeroVoo);
            this.groupBox1.Controls.Add(this.ckbCentroOperacaoOri);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Location = new System.Drawing.Point(6, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 41);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Planos de Voo";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(854, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ckbCentroOperacaoOri
            // 
            this.ckbCentroOperacaoOri.AutoSize = true;
            this.ckbCentroOperacaoOri.Location = new System.Drawing.Point(236, 16);
            this.ckbCentroOperacaoOri.Name = "ckbCentroOperacaoOri";
            this.ckbCentroOperacaoOri.Size = new System.Drawing.Size(59, 17);
            this.ckbCentroOperacaoOri.TabIndex = 1;
            this.ckbCentroOperacaoOri.Text = "Origem";
            this.ckbCentroOperacaoOri.UseVisualStyleBackColor = true;
            // 
            // ckbCentroOperacaoDes
            // 
            this.ckbCentroOperacaoDes.AutoSize = true;
            this.ckbCentroOperacaoDes.Location = new System.Drawing.Point(301, 16);
            this.ckbCentroOperacaoDes.Name = "ckbCentroOperacaoDes";
            this.ckbCentroOperacaoDes.Size = new System.Drawing.Size(62, 17);
            this.ckbCentroOperacaoDes.TabIndex = 8;
            this.ckbCentroOperacaoDes.Text = "Destino";
            this.ckbCentroOperacaoDes.UseVisualStyleBackColor = true;
            // 
            // txtFiltroNumeroVoo
            // 
            this.txtFiltroNumeroVoo.BackColor = System.Drawing.Color.Transparent;
            this.txtFiltroNumeroVoo.EnableTextBox = true;
            this.txtFiltroNumeroVoo.Label = "Número do Voo";
            this.txtFiltroNumeroVoo.Location = new System.Drawing.Point(6, 13);
            this.txtFiltroNumeroVoo.Name = "txtFiltroNumeroVoo";
            this.txtFiltroNumeroVoo.Size = new System.Drawing.Size(224, 22);
            this.txtFiltroNumeroVoo.TabIndex = 7;
            this.txtFiltroNumeroVoo.TextBox = "";
            // 
            // iDSCVPLANOVOODataGridViewTextBoxColumn
            // 
            this.iDSCVPLANOVOODataGridViewTextBoxColumn.DataPropertyName = "ID_SCV_PLANO_VOO";
            this.iDSCVPLANOVOODataGridViewTextBoxColumn.HeaderText = "ID_SCV_PLANO_VOO";
            this.iDSCVPLANOVOODataGridViewTextBoxColumn.Name = "iDSCVPLANOVOODataGridViewTextBoxColumn";
            this.iDSCVPLANOVOODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCVPLANOVOODataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSCVCOMPANHIADataGridViewTextBoxColumn
            // 
            this.iDSCVCOMPANHIADataGridViewTextBoxColumn.DataPropertyName = "ID_SCV_COMPANHIA";
            this.iDSCVCOMPANHIADataGridViewTextBoxColumn.HeaderText = "ID_SCV_COMPANHIA";
            this.iDSCVCOMPANHIADataGridViewTextBoxColumn.Name = "iDSCVCOMPANHIADataGridViewTextBoxColumn";
            this.iDSCVCOMPANHIADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCVCOMPANHIADataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSCVFROTADataGridViewTextBoxColumn
            // 
            this.iDSCVFROTADataGridViewTextBoxColumn.DataPropertyName = "ID_SCV_FROTA";
            this.iDSCVFROTADataGridViewTextBoxColumn.HeaderText = "ID_SCV_FROTA";
            this.iDSCVFROTADataGridViewTextBoxColumn.Name = "iDSCVFROTADataGridViewTextBoxColumn";
            this.iDSCVFROTADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCVFROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn
            // 
            this.iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn.DataPropertyName = "ID_SCV_CENTRO_OPERACAO_ORIGEM";
            this.iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn.HeaderText = "ID_SCV_CENTRO_OPERACAO_ORIGEM";
            this.iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn.Name = "iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn";
            this.iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn
            // 
            this.iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn.DataPropertyName = "ID_SCV_CENTRO_OPERACAO_DESTINO";
            this.iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn.HeaderText = "ID_SCV_CENTRO_OPERACAO_DESTINO";
            this.iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn.Name = "iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn";
            this.iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn.Visible = false;
            // 
            // dTVOODataGridViewTextBoxColumn
            // 
            this.dTVOODataGridViewTextBoxColumn.DataPropertyName = "DT_VOO";
            this.dTVOODataGridViewTextBoxColumn.HeaderText = "DATA VOO";
            this.dTVOODataGridViewTextBoxColumn.Name = "dTVOODataGridViewTextBoxColumn";
            this.dTVOODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMCOMPANHIADataGridViewTextBoxColumn
            // 
            this.nMCOMPANHIADataGridViewTextBoxColumn.DataPropertyName = "NM_COMPANHIA";
            this.nMCOMPANHIADataGridViewTextBoxColumn.HeaderText = "COMPANHIA";
            this.nMCOMPANHIADataGridViewTextBoxColumn.Name = "nMCOMPANHIADataGridViewTextBoxColumn";
            this.nMCOMPANHIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPANHIAICAODataGridViewTextBoxColumn
            // 
            this.cOMPANHIAICAODataGridViewTextBoxColumn.DataPropertyName = "COMPANHIA_ICAO";
            this.cOMPANHIAICAODataGridViewTextBoxColumn.HeaderText = "COMPANHIA ICAO";
            this.cOMPANHIAICAODataGridViewTextBoxColumn.Name = "cOMPANHIAICAODataGridViewTextBoxColumn";
            this.cOMPANHIAICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPANHIAICAODataGridViewTextBoxColumn.Visible = false;
            // 
            // nMNOMEAERONAVEDataGridViewTextBoxColumn
            // 
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn.DataPropertyName = "NM_NOME_AERONAVE";
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn.HeaderText = "AERONAVE";
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn.Name = "nMNOMEAERONAVEDataGridViewTextBoxColumn";
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMMATRICULADataGridViewTextBoxColumn
            // 
            this.nMMATRICULADataGridViewTextBoxColumn.DataPropertyName = "NM_MATRICULA";
            this.nMMATRICULADataGridViewTextBoxColumn.HeaderText = "MATRICULA";
            this.nMMATRICULADataGridViewTextBoxColumn.Name = "nMMATRICULADataGridViewTextBoxColumn";
            this.nMMATRICULADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nRSERIEDataGridViewTextBoxColumn
            // 
            this.nRSERIEDataGridViewTextBoxColumn.DataPropertyName = "NR_SERIE";
            this.nRSERIEDataGridViewTextBoxColumn.HeaderText = "SERIE";
            this.nRSERIEDataGridViewTextBoxColumn.Name = "nRSERIEDataGridViewTextBoxColumn";
            this.nRSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cENTROOPERACAOORIGEMDataGridViewTextBoxColumn
            // 
            this.cENTROOPERACAOORIGEMDataGridViewTextBoxColumn.DataPropertyName = "CENTRO_OPERACAO_ORIGEM";
            this.cENTROOPERACAOORIGEMDataGridViewTextBoxColumn.HeaderText = "ORIGEM";
            this.cENTROOPERACAOORIGEMDataGridViewTextBoxColumn.Name = "cENTROOPERACAOORIGEMDataGridViewTextBoxColumn";
            this.cENTROOPERACAOORIGEMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cENTROOPERACAODESTINODataGridViewTextBoxColumn
            // 
            this.cENTROOPERACAODESTINODataGridViewTextBoxColumn.DataPropertyName = "CENTRO_OPERACAO_DESTINO";
            this.cENTROOPERACAODESTINODataGridViewTextBoxColumn.HeaderText = "DESTINO";
            this.cENTROOPERACAODESTINODataGridViewTextBoxColumn.Name = "cENTROOPERACAODESTINODataGridViewTextBoxColumn";
            this.cENTROOPERACAODESTINODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTCADASTRODataGridViewTextBoxColumn
            // 
            this.dTCADASTRODataGridViewTextBoxColumn.DataPropertyName = "DT_CADASTRO";
            this.dTCADASTRODataGridViewTextBoxColumn.HeaderText = "CADASTRO";
            this.dTCADASTRODataGridViewTextBoxColumn.Name = "dTCADASTRODataGridViewTextBoxColumn";
            this.dTCADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTATUALIZACAODataGridViewTextBoxColumn
            // 
            this.dTATUALIZACAODataGridViewTextBoxColumn.DataPropertyName = "DT_ATUALIZACAO";
            this.dTATUALIZACAODataGridViewTextBoxColumn.HeaderText = "ATUALIZACAO";
            this.dTATUALIZACAODataGridViewTextBoxColumn.Name = "dTATUALIZACAODataGridViewTextBoxColumn";
            this.dTATUALIZACAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWSCVPLANOVOOINFORMACAOBindingSource
            // 
            this.vWSCVPLANOVOOINFORMACAOBindingSource.DataSource = typeof(SCV.Entity.VW_SCV_PLANO_VOO_INFORMACAO);
            // 
            // seletorCentroOperacaoDes
            // 
            this.seletorCentroOperacaoDes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seletorCentroOperacaoDes.BackColor = System.Drawing.Color.Transparent;
            this.seletorCentroOperacaoDes.CentroOperacaoSelecionado = null;
            this.seletorCentroOperacaoDes.Location = new System.Drawing.Point(473, 60);
            this.seletorCentroOperacaoDes.Name = "seletorCentroOperacaoDes";
            this.seletorCentroOperacaoDes.Size = new System.Drawing.Size(465, 42);
            this.seletorCentroOperacaoDes.TabIndex = 9;
            this.seletorCentroOperacaoDes.Titulo = "Centro de Operação Destino";
            // 
            // sltCompanhia
            // 
            this.sltCompanhia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sltCompanhia.BackColor = System.Drawing.Color.Transparent;
            this.sltCompanhia.Label = "Companhia";
            this.sltCompanhia.Location = new System.Drawing.Point(3, 31);
            this.sltCompanhia.Name = "sltCompanhia";
            this.sltCompanhia.Size = new System.Drawing.Size(464, 23);
            this.sltCompanhia.TabIndex = 2;
            this.sltCompanhia.SelectedIndexChanged += new System.EventHandler(this.sltCompanhia_SelectedIndexChanged);
            this.sltCompanhia.Load += new System.EventHandler(this.sltCompanhia_Load);
            // 
            // seletorFrota
            // 
            this.seletorFrota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seletorFrota.BackColor = System.Drawing.Color.Transparent;
            this.seletorFrota.Companhia = null;
            this.seletorFrota.FrotaSelecionada = null;
            this.seletorFrota.Location = new System.Drawing.Point(473, 31);
            this.seletorFrota.Name = "seletorFrota";
            this.seletorFrota.Size = new System.Drawing.Size(465, 23);
            this.seletorFrota.TabIndex = 7;
            // 
            // seletorCentroOperacaoOri
            // 
            this.seletorCentroOperacaoOri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seletorCentroOperacaoOri.BackColor = System.Drawing.Color.Transparent;
            this.seletorCentroOperacaoOri.CentroOperacaoSelecionado = null;
            this.seletorCentroOperacaoOri.Location = new System.Drawing.Point(3, 60);
            this.seletorCentroOperacaoOri.Name = "seletorCentroOperacaoOri";
            this.seletorCentroOperacaoOri.Size = new System.Drawing.Size(464, 42);
            this.seletorCentroOperacaoOri.TabIndex = 8;
            this.seletorCentroOperacaoOri.Titulo = "Centro de Operação ORIGEM";
            // 
            // dtVoo
            // 
            this.dtVoo.BackColor = System.Drawing.Color.Transparent;
            this.dtVoo.DateTimePicker = new System.DateTime(2018, 3, 27, 0, 0, 0, 0);
            this.dtVoo.Label = "Data do Voo";
            this.dtVoo.Location = new System.Drawing.Point(3, 3);
            this.dtVoo.Name = "dtVoo";
            this.dtVoo.Size = new System.Drawing.Size(245, 22);
            this.dtVoo.TabIndex = 3;
            // 
            // txtNumeroVoo
            // 
            this.txtNumeroVoo.BackColor = System.Drawing.Color.Transparent;
            this.txtNumeroVoo.EnableTextBox = false;
            this.txtNumeroVoo.Label = "Número do Voo";
            this.txtNumeroVoo.Location = new System.Drawing.Point(473, 3);
            this.txtNumeroVoo.Name = "txtNumeroVoo";
            this.txtNumeroVoo.Size = new System.Drawing.Size(224, 22);
            this.txtNumeroVoo.TabIndex = 6;
            this.txtNumeroVoo.TextBox = "";
            this.txtNumeroVoo.Visible = false;
            // 
            // UcModuloPlanoVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UcModuloPlanoVoo";
            this.Size = new System.Drawing.Size(947, 447);
            this.Load += new System.EventHandler(this.ucPlanoVooCadastro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanosVoo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vWSCVPLANOVOOINFORMACAOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private UI.UcSeletor sltCompanhia;
        private UI.UcLabelDateTimePicker dtVoo;
        private System.Windows.Forms.Button btnCadastrar;
        private UI.UcLabelTextBox txtNumeroVoo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private UI.UcSeletorFrota seletorFrota;
        private UI.UcSeletorCentroOperacao seletorCentroOperacaoOri;
        private UI.UcSeletorCentroOperacao seletorCentroOperacaoDes;
        private System.Windows.Forms.DataGridView dgvPlanosVoo;
        private System.Windows.Forms.BindingSource vWSCVPLANOVOOINFORMACAOBindingSource;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCVPLANOVOODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCVCOMPANHIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCVFROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCVCENTROOPERACAOORIGEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCVCENTROOPERACAODESTINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTVOODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_VOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMCOMPANHIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANHIAICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMNOMEAERONAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMMATRICULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENTROOPERACAOORIGEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENTROOPERACAODESTINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTCADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTATUALIZACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbCentroOperacaoDes;
        private UI.UcLabelTextBox txtFiltroNumeroVoo;
        private System.Windows.Forms.CheckBox ckbCentroOperacaoOri;
        private System.Windows.Forms.Button btnConsultar;
    }
}
