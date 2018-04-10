namespace Prova
{
    partial class SelectTudo
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
            this.dataLivros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLivros
            // 
            this.dataLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLivros.Location = new System.Drawing.Point(25, 47);
            this.dataLivros.Name = "dataLivros";
            this.dataLivros.Size = new System.Drawing.Size(661, 223);
            this.dataLivros.TabIndex = 0;
            // 
            // SelectTudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 315);
            this.Controls.Add(this.dataLivros);
            this.Name = "SelectTudo";
            this.Text = "SelectTudo";
            this.Load += new System.EventHandler(this.SelectTudo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataLivros;
    }
}