namespace SCV.Presentation.UI
{
    partial class UcSeletorCentroOperacao
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
            this.txtCentroOperacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCentroOperacao
            // 
            this.txtCentroOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCentroOperacao.Enabled = false;
            this.txtCentroOperacao.Location = new System.Drawing.Point(121, 19);
            this.txtCentroOperacao.Name = "txtCentroOperacao";
            this.txtCentroOperacao.Size = new System.Drawing.Size(217, 20);
            this.txtCentroOperacao.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Centro de Operacao";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 13);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // UcSeletorCentroOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCentroOperacao);
            this.Controls.Add(this.button1);
            this.Name = "UcSeletorCentroOperacao";
            this.Size = new System.Drawing.Size(341, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCentroOperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
    }
}
