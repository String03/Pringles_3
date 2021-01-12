namespace Pringles
{
    partial class GrillaGenerica
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
            this.grv_generico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grv_generico)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_generico
            // 
            this.grv_generico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_generico.Location = new System.Drawing.Point(16, 15);
            this.grv_generico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grv_generico.MultiSelect = false;
            this.grv_generico.Name = "grv_generico";
            this.grv_generico.ReadOnly = true;
            this.grv_generico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_generico.Size = new System.Drawing.Size(683, 373);
            this.grv_generico.TabIndex = 0;
            this.grv_generico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_generico_CellDoubleClick);
            // 
            // GrillaGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 394);
            this.Controls.Add(this.grv_generico);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(737, 441);
            this.MinimumSize = new System.Drawing.Size(737, 441);
            this.Name = "GrillaGenerica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GrillaGenerica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_generico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_generico;
    }
}