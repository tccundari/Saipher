namespace SCV.Presentation.Controles
{
    partial class frmSelecionarCentroOperacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionarCentroOperacoes));
            this.dgvSelecaoCentroOperacao = new System.Windows.Forms.DataGridView();
            this.tBSCVCENTROOPERACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSCVCENTROOPERACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMCENTROOPERACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMIATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMLOCALIZACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTATIVODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dTCADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTATUALIZACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecaoCentroOperacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSCVCENTROOPERACAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelecaoCentroOperacao
            // 
            this.dgvSelecaoCentroOperacao.AllowUserToAddRows = false;
            this.dgvSelecaoCentroOperacao.AllowUserToDeleteRows = false;
            this.dgvSelecaoCentroOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelecaoCentroOperacao.AutoGenerateColumns = false;
            this.dgvSelecaoCentroOperacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelecaoCentroOperacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSelecaoCentroOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecaoCentroOperacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSCVCENTROOPERACAODataGridViewTextBoxColumn,
            this.nMCENTROOPERACAODataGridViewTextBoxColumn,
            this.nMIATADataGridViewTextBoxColumn,
            this.nMICAODataGridViewTextBoxColumn,
            this.nMLOCALIZACAODataGridViewTextBoxColumn,
            this.bTATIVODataGridViewCheckBoxColumn,
            this.dTCADASTRODataGridViewTextBoxColumn,
            this.dTATUALIZACAODataGridViewTextBoxColumn,
            this.Selecionar});
            this.dgvSelecaoCentroOperacao.DataSource = this.tBSCVCENTROOPERACAOBindingSource;
            this.dgvSelecaoCentroOperacao.Location = new System.Drawing.Point(12, 12);
            this.dgvSelecaoCentroOperacao.Name = "dgvSelecaoCentroOperacao";
            this.dgvSelecaoCentroOperacao.ReadOnly = true;
            this.dgvSelecaoCentroOperacao.RowHeadersVisible = false;
            this.dgvSelecaoCentroOperacao.Size = new System.Drawing.Size(770, 260);
            this.dgvSelecaoCentroOperacao.TabIndex = 0;
            this.dgvSelecaoCentroOperacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelecaoFrota_CellContentClick);
            // 
            // tBSCVCENTROOPERACAOBindingSource
            // 
            this.tBSCVCENTROOPERACAOBindingSource.DataSource = typeof(SCV.Entity.TB_SCV_CENTRO_OPERACAO);
            // 
            // iDSCVCENTROOPERACAODataGridViewTextBoxColumn
            // 
            this.iDSCVCENTROOPERACAODataGridViewTextBoxColumn.DataPropertyName = "ID_SCV_CENTRO_OPERACAO";
            this.iDSCVCENTROOPERACAODataGridViewTextBoxColumn.HeaderText = "ID_SCV_CENTRO_OPERACAO";
            this.iDSCVCENTROOPERACAODataGridViewTextBoxColumn.Name = "iDSCVCENTROOPERACAODataGridViewTextBoxColumn";
            this.iDSCVCENTROOPERACAODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCVCENTROOPERACAODataGridViewTextBoxColumn.Visible = false;
            // 
            // nMCENTROOPERACAODataGridViewTextBoxColumn
            // 
            this.nMCENTROOPERACAODataGridViewTextBoxColumn.DataPropertyName = "NM_CENTRO_OPERACAO";
            this.nMCENTROOPERACAODataGridViewTextBoxColumn.HeaderText = "CENTRO OPERACAO";
            this.nMCENTROOPERACAODataGridViewTextBoxColumn.Name = "nMCENTROOPERACAODataGridViewTextBoxColumn";
            this.nMCENTROOPERACAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMIATADataGridViewTextBoxColumn
            // 
            this.nMIATADataGridViewTextBoxColumn.DataPropertyName = "NM_IATA";
            this.nMIATADataGridViewTextBoxColumn.HeaderText = "IATA";
            this.nMIATADataGridViewTextBoxColumn.Name = "nMIATADataGridViewTextBoxColumn";
            this.nMIATADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMICAODataGridViewTextBoxColumn
            // 
            this.nMICAODataGridViewTextBoxColumn.DataPropertyName = "NM_ICAO";
            this.nMICAODataGridViewTextBoxColumn.HeaderText = "ICAO";
            this.nMICAODataGridViewTextBoxColumn.Name = "nMICAODataGridViewTextBoxColumn";
            this.nMICAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMLOCALIZACAODataGridViewTextBoxColumn
            // 
            this.nMLOCALIZACAODataGridViewTextBoxColumn.DataPropertyName = "NM_LOCALIZACAO";
            this.nMLOCALIZACAODataGridViewTextBoxColumn.HeaderText = "LOCALIZACAO";
            this.nMLOCALIZACAODataGridViewTextBoxColumn.Name = "nMLOCALIZACAODataGridViewTextBoxColumn";
            this.nMLOCALIZACAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bTATIVODataGridViewCheckBoxColumn
            // 
            this.bTATIVODataGridViewCheckBoxColumn.DataPropertyName = "BT_ATIVO";
            this.bTATIVODataGridViewCheckBoxColumn.HeaderText = "BT_ATIVO";
            this.bTATIVODataGridViewCheckBoxColumn.Name = "bTATIVODataGridViewCheckBoxColumn";
            this.bTATIVODataGridViewCheckBoxColumn.ReadOnly = true;
            this.bTATIVODataGridViewCheckBoxColumn.Visible = false;
            // 
            // dTCADASTRODataGridViewTextBoxColumn
            // 
            this.dTCADASTRODataGridViewTextBoxColumn.DataPropertyName = "DT_CADASTRO";
            this.dTCADASTRODataGridViewTextBoxColumn.HeaderText = "DT_CADASTRO";
            this.dTCADASTRODataGridViewTextBoxColumn.Name = "dTCADASTRODataGridViewTextBoxColumn";
            this.dTCADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            this.dTCADASTRODataGridViewTextBoxColumn.Visible = false;
            // 
            // dTATUALIZACAODataGridViewTextBoxColumn
            // 
            this.dTATUALIZACAODataGridViewTextBoxColumn.DataPropertyName = "DT_ATUALIZACAO";
            this.dTATUALIZACAODataGridViewTextBoxColumn.HeaderText = "DT_ATUALIZACAO";
            this.dTATUALIZACAODataGridViewTextBoxColumn.Name = "dTATUALIZACAODataGridViewTextBoxColumn";
            this.dTATUALIZACAODataGridViewTextBoxColumn.ReadOnly = true;
            this.dTATUALIZACAODataGridViewTextBoxColumn.Visible = false;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseColumnTextForButtonValue = true;
            // 
            // frmSelecionarCentroOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 284);
            this.Controls.Add(this.dgvSelecaoCentroOperacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelecionarCentroOperacoes";
            this.Text = "Selecionar Aeronave da Frota";
            this.Load += new System.EventHandler(this.frmSelecionarAeronaveFrota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecaoCentroOperacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSCVCENTROOPERACAOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelecaoCentroOperacao;
        private System.Windows.Forms.BindingSource tBSCVCENTROOPERACAOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCVCENTROOPERACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMCENTROOPERACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMIATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMLOCALIZACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bTATIVODataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTCADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTATUALIZACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}