namespace SCV.Presentation.UI
{
    partial class UcLabelTextBox
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
            this.ltTextBox = new System.Windows.Forms.TextBox();
            this.ltLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltTextBox
            // 
            this.ltTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ltTextBox.Location = new System.Drawing.Point(55, 1);
            this.ltTextBox.Name = "ltTextBox";
            this.ltTextBox.Size = new System.Drawing.Size(130, 20);
            this.ltTextBox.TabIndex = 3;
            this.ltTextBox.TextChanged += new System.EventHandler(this.ltTextBox_TextChanged_1);
            // 
            // ltLabel
            // 
            this.ltLabel.AutoSize = true;
            this.ltLabel.Location = new System.Drawing.Point(3, 4);
            this.ltLabel.Name = "ltLabel";
            this.ltLabel.Size = new System.Drawing.Size(35, 13);
            this.ltLabel.TabIndex = 2;
            this.ltLabel.Text = "label1";
            this.ltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ltLabel.Click += new System.EventHandler(this.ltLabel_Click_1);
            // 
            // UcLabelTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ltTextBox);
            this.Controls.Add(this.ltLabel);
            this.Name = "UcLabelTextBox";
            this.Size = new System.Drawing.Size(188, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ltTextBox;
        private System.Windows.Forms.Label ltLabel;
    }
}
