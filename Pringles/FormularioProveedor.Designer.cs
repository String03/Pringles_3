namespace Pringles
{
    partial class FormularioProveedor
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
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.btn_alta_proveedor = new System.Windows.Forms.Button();
            this.btn_baja_proveedor = new System.Windows.Forms.Button();
            this.btn_modificacion_proveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_razon_social_proveedor = new System.Windows.Forms.TextBox();
            this.btn_historial_proveedor = new System.Windows.Forms.Button();
            this.btn_mayor_compra = new System.Windows.Forms.Button();
            this.btn_compra_mas_comun = new System.Windows.Forms.Button();
            this.btn_mayor_rapidez = new System.Windows.Forms.Button();
            this.btn_menor_precio = new System.Windows.Forms.Button();
            this.txt_cuil_proveedor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProveedores
            // 
            this.grillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProveedores.Location = new System.Drawing.Point(124, 38);
            this.grillaProveedores.MultiSelect = false;
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.ReadOnly = true;
            this.grillaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProveedores.Size = new System.Drawing.Size(510, 150);
            this.grillaProveedores.TabIndex = 0;
            // 
            // btn_alta_proveedor
            // 
            this.btn_alta_proveedor.Location = new System.Drawing.Point(124, 229);
            this.btn_alta_proveedor.Name = "btn_alta_proveedor";
            this.btn_alta_proveedor.Size = new System.Drawing.Size(75, 31);
            this.btn_alta_proveedor.TabIndex = 1;
            this.btn_alta_proveedor.Text = "Alta";
            this.btn_alta_proveedor.UseVisualStyleBackColor = true;
            this.btn_alta_proveedor.Click += new System.EventHandler(this.btn_alta_proveedor_Click);
            // 
            // btn_baja_proveedor
            // 
            this.btn_baja_proveedor.Location = new System.Drawing.Point(317, 229);
            this.btn_baja_proveedor.Name = "btn_baja_proveedor";
            this.btn_baja_proveedor.Size = new System.Drawing.Size(75, 31);
            this.btn_baja_proveedor.TabIndex = 2;
            this.btn_baja_proveedor.Text = "Baja";
            this.btn_baja_proveedor.UseVisualStyleBackColor = true;
            this.btn_baja_proveedor.Click += new System.EventHandler(this.btn_baja_proveedor_Click);
            // 
            // btn_modificacion_proveedor
            // 
            this.btn_modificacion_proveedor.Location = new System.Drawing.Point(534, 229);
            this.btn_modificacion_proveedor.Name = "btn_modificacion_proveedor";
            this.btn_modificacion_proveedor.Size = new System.Drawing.Size(100, 31);
            this.btn_modificacion_proveedor.TabIndex = 3;
            this.btn_modificacion_proveedor.Text = "Modificación";
            this.btn_modificacion_proveedor.UseVisualStyleBackColor = true;
            this.btn_modificacion_proveedor.Click += new System.EventHandler(this.btn_modificacion_proveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Razón Social";
            // 
            // txt_razon_social_proveedor
            // 
            this.txt_razon_social_proveedor.Location = new System.Drawing.Point(534, 308);
            this.txt_razon_social_proveedor.Name = "txt_razon_social_proveedor";
            this.txt_razon_social_proveedor.Size = new System.Drawing.Size(100, 22);
            this.txt_razon_social_proveedor.TabIndex = 7;
            // 
            // btn_historial_proveedor
            // 
            this.btn_historial_proveedor.Location = new System.Drawing.Point(678, 67);
            this.btn_historial_proveedor.Name = "btn_historial_proveedor";
            this.btn_historial_proveedor.Size = new System.Drawing.Size(94, 78);
            this.btn_historial_proveedor.TabIndex = 8;
            this.btn_historial_proveedor.Text = "Historial del Proveedor";
            this.btn_historial_proveedor.UseVisualStyleBackColor = true;
            this.btn_historial_proveedor.Click += new System.EventHandler(this.btn_historial_proveedor_Click);
            // 
            // btn_mayor_compra
            // 
            this.btn_mayor_compra.Location = new System.Drawing.Point(124, 378);
            this.btn_mayor_compra.Name = "btn_mayor_compra";
            this.btn_mayor_compra.Size = new System.Drawing.Size(115, 30);
            this.btn_mayor_compra.TabIndex = 9;
            this.btn_mayor_compra.Text = "Mayor Compra";
            this.btn_mayor_compra.UseVisualStyleBackColor = true;
            this.btn_mayor_compra.Click += new System.EventHandler(this.btn_mayor_compra_Click);
            // 
            // btn_compra_mas_comun
            // 
            this.btn_compra_mas_comun.Location = new System.Drawing.Point(482, 378);
            this.btn_compra_mas_comun.Name = "btn_compra_mas_comun";
            this.btn_compra_mas_comun.Size = new System.Drawing.Size(152, 30);
            this.btn_compra_mas_comun.TabIndex = 10;
            this.btn_compra_mas_comun.Text = "Compra más Común";
            this.btn_compra_mas_comun.UseVisualStyleBackColor = true;
            this.btn_compra_mas_comun.Click += new System.EventHandler(this.btn_compra_mas_comun_Click);
            // 
            // btn_mayor_rapidez
            // 
            this.btn_mayor_rapidez.Location = new System.Drawing.Point(124, 449);
            this.btn_mayor_rapidez.Name = "btn_mayor_rapidez";
            this.btn_mayor_rapidez.Size = new System.Drawing.Size(115, 30);
            this.btn_mayor_rapidez.TabIndex = 11;
            this.btn_mayor_rapidez.Text = "Mayor Rapidez";
            this.btn_mayor_rapidez.UseVisualStyleBackColor = true;
            this.btn_mayor_rapidez.Click += new System.EventHandler(this.btn_mayor_rapidez_Click);
            // 
            // btn_menor_precio
            // 
            this.btn_menor_precio.Location = new System.Drawing.Point(482, 449);
            this.btn_menor_precio.Name = "btn_menor_precio";
            this.btn_menor_precio.Size = new System.Drawing.Size(115, 30);
            this.btn_menor_precio.TabIndex = 12;
            this.btn_menor_precio.Text = "Menor Precio";
            this.btn_menor_precio.UseVisualStyleBackColor = true;
            this.btn_menor_precio.Click += new System.EventHandler(this.btn_menor_precio_Click);
            // 
            // txt_cuil_proveedor
            // 
            this.txt_cuil_proveedor.Location = new System.Drawing.Point(215, 308);
            this.txt_cuil_proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cuil_proveedor.Mask = "00.000.000";
            this.txt_cuil_proveedor.Name = "txt_cuil_proveedor";
            this.txt_cuil_proveedor.Size = new System.Drawing.Size(96, 22);
            this.txt_cuil_proveedor.TabIndex = 33;
            // 
            // FormularioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.txt_cuil_proveedor);
            this.Controls.Add(this.btn_menor_precio);
            this.Controls.Add(this.btn_mayor_rapidez);
            this.Controls.Add(this.btn_compra_mas_comun);
            this.Controls.Add(this.btn_mayor_compra);
            this.Controls.Add(this.btn_historial_proveedor);
            this.Controls.Add(this.txt_razon_social_proveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificacion_proveedor);
            this.Controls.Add(this.btn_baja_proveedor);
            this.Controls.Add(this.btn_alta_proveedor);
            this.Controls.Add(this.grillaProveedores);
            this.Name = "FormularioProveedor";
            this.Text = "FormularioProveedor";
            this.Load += new System.EventHandler(this.FormularioProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProveedores;
        private System.Windows.Forms.Button btn_alta_proveedor;
        private System.Windows.Forms.Button btn_baja_proveedor;
        private System.Windows.Forms.Button btn_modificacion_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_razon_social_proveedor;
        private System.Windows.Forms.Button btn_historial_proveedor;
        private System.Windows.Forms.Button btn_mayor_compra;
        private System.Windows.Forms.Button btn_compra_mas_comun;
        private System.Windows.Forms.Button btn_mayor_rapidez;
        private System.Windows.Forms.Button btn_menor_precio;
        private System.Windows.Forms.MaskedTextBox txt_cuil_proveedor;
    }
}