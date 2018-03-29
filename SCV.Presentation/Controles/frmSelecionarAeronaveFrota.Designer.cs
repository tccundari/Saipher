namespace SCV.Presentation.Controles
{
    partial class frmSelecionarAeronaveFrota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionarAeronaveFrota));
            this.dgvSelecaoFrota = new System.Windows.Forms.DataGridView();
            this.lblCompanhia = new System.Windows.Forms.Label();
            this.vWSCVFROTAAERONAVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSCVFROTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSCVAERONAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSCVCOMPANHIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMMODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMMATRICULADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTFABRICACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecaoFrota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSCVFROTAAERONAVEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelecaoFrota
            // 
            this.dgvSelecaoFrota.AllowUserToAddRows = false;
            this.dgvSelecaoFrota.AllowUserToDeleteRows = false;
            this.dgvSelecaoFrota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelecaoFrota.AutoGenerateColumns = false;
            this.dgvSelecaoFrota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelecaoFrota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSelecaoFrota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecaoFrota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSCVFROTADataGridViewTextBoxColumn,
            this.iDSCVAERONAVEDataGridViewTextBoxColumn,
            this.fKSCVCOMPANHIADataGridViewTextBoxColumn,
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn,
            this.nMMODELODataGridViewTextBoxColumn,
            this.nMMATRICULADataGridViewTextBoxColumn,
            this.nRSERIEDataGridViewTextBoxColumn,
            this.dTFABRICACAODataGridViewTextBoxColumn,
            this.dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn,
            this.Selecionar});
            this.dgvSelecaoFrota.DataSource = this.vWSCVFROTAAERONAVEBindingSource;
            this.dgvSelecaoFrota.Location = new System.Drawing.Point(12, 35);
            this.dgvSelecaoFrota.Name = "dgvSelecaoFrota";
            this.dgvSelecaoFrota.ReadOnly = true;
            this.dgvSelecaoFrota.RowHeadersVisible = false;
            this.dgvSelecaoFrota.Size = new System.Drawing.Size(770, 237);
            this.dgvSelecaoFrota.TabIndex = 0;
            this.dgvSelecaoFrota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelecaoFrota_CellContentClick);
            // 
            // lblCompanhia
            // 
            this.lblCompanhia.AutoSize = true;
            this.lblCompanhia.Location = new System.Drawing.Point(13, 13);
            this.lblCompanhia.Name = "lblCompanhia";
            this.lblCompanhia.Size = new System.Drawing.Size(35, 13);
            this.lblCompanhia.TabIndex = 1;
            this.lblCompanhia.Text = "label1";
            // 
            // vWSCVFROTAAERONAVEBindingSource
            // 
            this.vWSCVFROTAAERONAVEBindingSource.DataSource = typeof(SCV.Entity.VW_SCV_FROTA_AERONAVE);
            // 
            // iDSCVFROTADataGridViewTextBoxColumn
            // 
            this.iDSCVFROTADataGridViewTextBoxColumn.DataPropertyName = "ID_SCV_FROTA";
            this.iDSCVFROTADataGridViewTextBoxColumn.HeaderText = "ID_SCV_FROTA";
            this.iDSCVFROTADataGridViewTextBoxColumn.Name = "iDSCVFROTADataGridViewTextBoxColumn";
            this.iDSCVFROTADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCVFROTADataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSCVAERONAVEDataGridViewTextBoxColumn
            // 
            this.iDSCVAERONAVEDataGridViewTextBoxColumn.DataPropertyName = "ID_SCV_AERONAVE";
            this.iDSCVAERONAVEDataGridViewTextBoxColumn.HeaderText = "ID_SCV_AERONAVE";
            this.iDSCVAERONAVEDataGridViewTextBoxColumn.Name = "iDSCVAERONAVEDataGridViewTextBoxColumn";
            this.iDSCVAERONAVEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCVAERONAVEDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKSCVCOMPANHIADataGridViewTextBoxColumn
            // 
            this.fKSCVCOMPANHIADataGridViewTextBoxColumn.DataPropertyName = "FK_SCV_COMPANHIA";
            this.fKSCVCOMPANHIADataGridViewTextBoxColumn.HeaderText = "FK_SCV_COMPANHIA";
            this.fKSCVCOMPANHIADataGridViewTextBoxColumn.Name = "fKSCVCOMPANHIADataGridViewTextBoxColumn";
            this.fKSCVCOMPANHIADataGridViewTextBoxColumn.ReadOnly = true;
            this.fKSCVCOMPANHIADataGridViewTextBoxColumn.Visible = false;
            // 
            // nMNOMEAERONAVEDataGridViewTextBoxColumn
            // 
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn.DataPropertyName = "NM_NOME_AERONAVE";
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn.HeaderText = "AERONAVE";
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn.Name = "nMNOMEAERONAVEDataGridViewTextBoxColumn";
            this.nMNOMEAERONAVEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMMODELODataGridViewTextBoxColumn
            // 
            this.nMMODELODataGridViewTextBoxColumn.DataPropertyName = "NM_MODELO";
            this.nMMODELODataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.nMMODELODataGridViewTextBoxColumn.Name = "nMMODELODataGridViewTextBoxColumn";
            this.nMMODELODataGridViewTextBoxColumn.ReadOnly = true;
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
            this.nRSERIEDataGridViewTextBoxColumn.HeaderText = "NUMERO DE SERIE";
            this.nRSERIEDataGridViewTextBoxColumn.Name = "nRSERIEDataGridViewTextBoxColumn";
            this.nRSERIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTFABRICACAODataGridViewTextBoxColumn
            // 
            this.dTFABRICACAODataGridViewTextBoxColumn.DataPropertyName = "DT_FABRICACAO";
            this.dTFABRICACAODataGridViewTextBoxColumn.HeaderText = "DATA DE FABRICACAO";
            this.dTFABRICACAODataGridViewTextBoxColumn.Name = "dTFABRICACAODataGridViewTextBoxColumn";
            this.dTFABRICACAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn
            // 
            this.dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn.DataPropertyName = "DT_COMPRA_TRANSFERENCIA";
            this.dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn.HeaderText = "DATA COMPRA/TRANSFERENCIA";
            this.dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn.Name = "dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn";
            this.dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn.ReadOnly = true;
            this.dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn.Visible = false;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Text = "Selecionar";
            this.Selecionar.UseColumnTextForButtonValue = true;
            // 
            // frmSelecionarAeronaveFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 284);
            this.Controls.Add(this.lblCompanhia);
            this.Controls.Add(this.dgvSelecaoFrota);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelecionarAeronaveFrota";
            this.Text = "Selecionar Aeronave da Frota";
            this.Load += new System.EventHandler(this.frmSelecionarAeronaveFrota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecaoFrota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWSCVFROTAAERONAVEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelecaoFrota;
        private System.Windows.Forms.Label lblCompanhia;
        private System.Windows.Forms.BindingSource vWSCVFROTAAERONAVEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCVFROTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCVAERONAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKSCVCOMPANHIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMNOMEAERONAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMMODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMMATRICULADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTFABRICACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTCOMPRATRANSFERENCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
    }
}