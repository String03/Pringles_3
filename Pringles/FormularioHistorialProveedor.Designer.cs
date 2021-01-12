namespace Pringles
{
    partial class FormularioHistorialProveedor
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
            this.grillaHistorialProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_autor_mas_comprado_proveedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_genero_mas_comprado_proveedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaHistorialProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaHistorialProveedor
            // 
            this.grillaHistorialProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaHistorialProveedor.Location = new System.Drawing.Point(142, 44);
            this.grillaHistorialProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaHistorialProveedor.MultiSelect = false;
            this.grillaHistorialProveedor.Name = "grillaHistorialProveedor";
            this.grillaHistorialProveedor.ReadOnly = true;
            this.grillaHistorialProveedor.RowTemplate.Height = 24;
            this.grillaHistorialProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaHistorialProveedor.Size = new System.Drawing.Size(504, 150);
            this.grillaHistorialProveedor.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sugerencia por Autor";
            // 
            // lbl_autor_mas_comprado_proveedor
            // 
            this.lbl_autor_mas_comprado_proveedor.AutoSize = true;
            this.lbl_autor_mas_comprado_proveedor.Location = new System.Drawing.Point(268, 244);
            this.lbl_autor_mas_comprado_proveedor.Name = "lbl_autor_mas_comprado_proveedor";
            this.lbl_autor_mas_comprado_proveedor.Size = new System.Drawing.Size(46, 17);
            this.lbl_autor_mas_comprado_proveedor.TabIndex = 29;
            this.lbl_autor_mas_comprado_proveedor.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sugerencia por Género";
            // 
            // lbl_genero_mas_comprado_proveedor
            // 
            this.lbl_genero_mas_comprado_proveedor.AutoSize = true;
            this.lbl_genero_mas_comprado_proveedor.Location = new System.Drawing.Point(634, 244);
            this.lbl_genero_mas_comprado_proveedor.Name = "lbl_genero_mas_comprado_proveedor";
            this.lbl_genero_mas_comprado_proveedor.Size = new System.Drawing.Size(46, 17);
            this.lbl_genero_mas_comprado_proveedor.TabIndex = 31;
            this.lbl_genero_mas_comprado_proveedor.Text = "label4";
            // 
            // FormularioHistorialProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.lbl_genero_mas_comprado_proveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_autor_mas_comprado_proveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaHistorialProveedor);
            this.Name = "FormularioHistorialProveedor";
            this.Text = "FormularioHistorialProveedor";
            this.Load += new System.EventHandler(this.FormularioHistorialProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaHistorialProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaHistorialProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_autor_mas_comprado_proveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_genero_mas_comprado_proveedor;
    }
}