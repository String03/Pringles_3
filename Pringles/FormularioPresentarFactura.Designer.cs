namespace Pringles
{
    partial class FormularioPresentarFactura
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
            this.grillaPresentarFactura = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPresentarFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaPresentarFactura
            // 
            this.grillaPresentarFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPresentarFactura.Location = new System.Drawing.Point(125, 84);
            this.grillaPresentarFactura.MultiSelect = false;
            this.grillaPresentarFactura.Name = "grillaPresentarFactura";
            this.grillaPresentarFactura.ReadOnly = true;
            this.grillaPresentarFactura.RowTemplate.Height = 24;
            this.grillaPresentarFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaPresentarFactura.Size = new System.Drawing.Size(785, 227);
            this.grillaPresentarFactura.TabIndex = 0;
            // 
            // FormularioPresentarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.grillaPresentarFactura);
            this.Name = "FormularioPresentarFactura";
            this.Text = "FormularioPresentarFactura";
            this.Load += new System.EventHandler(this.FormularioPresentarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPresentarFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaPresentarFactura;
    }
}