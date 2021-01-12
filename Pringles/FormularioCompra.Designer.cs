namespace Pringles
{
    partial class FormularioCompra
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
            this.grillaCompra = new System.Windows.Forms.DataGridView();
            this.grp_compra = new System.Windows.Forms.GroupBox();
            this.lbl_total_compra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar_libro = new System.Windows.Forms.Button();
            this.btn_buscar_proveedor_compra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cuil_proveedor_compra = new System.Windows.Forms.MaskedTextBox();
            this.txt_libro_compra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar_articulo_compra = new System.Windows.Forms.Button();
            this.btn_alta_compra = new System.Windows.Forms.Button();
            this.grp_libro_compra = new System.Windows.Forms.GroupBox();
            this.btn_cancelar_libro_compra = new System.Windows.Forms.Button();
            this.btn_agregar_libro_compra = new System.Windows.Forms.Button();
            this.lbl_titulo_libro = new System.Windows.Forms.Label();
            this.nud_cantidad_libro_compra = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_grupo_proveedor = new System.Windows.Forms.GroupBox();
            this.btn_cancelar_proveedor = new System.Windows.Forms.Button();
            this.lbl_razon_social_proveedor = new System.Windows.Forms.Label();
            this.lbl_cuil_proveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_monto_unitario_inventario_compra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCompra)).BeginInit();
            this.grp_compra.SuspendLayout();
            this.grp_libro_compra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_libro_compra)).BeginInit();
            this.grp_grupo_proveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaCompra
            // 
            this.grillaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCompra.Location = new System.Drawing.Point(60, 11);
            this.grillaCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaCompra.Name = "grillaCompra";
            this.grillaCompra.ReadOnly = true;
            this.grillaCompra.RowTemplate.Height = 24;
            this.grillaCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaCompra.Size = new System.Drawing.Size(487, 150);
            this.grillaCompra.TabIndex = 28;
            // 
            // grp_compra
            // 
            this.grp_compra.Controls.Add(this.lbl_total_compra);
            this.grp_compra.Controls.Add(this.label3);
            this.grp_compra.Location = new System.Drawing.Point(556, 34);
            this.grp_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_compra.Name = "grp_compra";
            this.grp_compra.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_compra.Size = new System.Drawing.Size(231, 110);
            this.grp_compra.TabIndex = 29;
            this.grp_compra.TabStop = false;
            this.grp_compra.Text = "Detalles de la compra";
            // 
            // lbl_total_compra
            // 
            this.lbl_total_compra.AutoSize = true;
            this.lbl_total_compra.Location = new System.Drawing.Point(63, 39);
            this.lbl_total_compra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total_compra.Name = "lbl_total_compra";
            this.lbl_total_compra.Size = new System.Drawing.Size(54, 17);
            this.lbl_total_compra.TabIndex = 1;
            this.lbl_total_compra.Text = "label10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            // 
            // btn_buscar_libro
            // 
            this.btn_buscar_libro.Location = new System.Drawing.Point(269, 254);
            this.btn_buscar_libro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar_libro.Name = "btn_buscar_libro";
            this.btn_buscar_libro.Size = new System.Drawing.Size(100, 28);
            this.btn_buscar_libro.TabIndex = 35;
            this.btn_buscar_libro.Text = "Buscar";
            this.btn_buscar_libro.UseVisualStyleBackColor = true;
            this.btn_buscar_libro.Click += new System.EventHandler(this.btn_buscar_libro_Click_1);
            // 
            // btn_buscar_proveedor_compra
            // 
            this.btn_buscar_proveedor_compra.Location = new System.Drawing.Point(269, 297);
            this.btn_buscar_proveedor_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar_proveedor_compra.Name = "btn_buscar_proveedor_compra";
            this.btn_buscar_proveedor_compra.Size = new System.Drawing.Size(100, 28);
            this.btn_buscar_proveedor_compra.TabIndex = 34;
            this.btn_buscar_proveedor_compra.Text = "Buscar";
            this.btn_buscar_proveedor_compra.UseVisualStyleBackColor = true;
            this.btn_buscar_proveedor_compra.Click += new System.EventHandler(this.btn_buscar_proveedor_compra_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "CUIL Proveedor";
            // 
            // txt_cuil_proveedor_compra
            // 
            this.txt_cuil_proveedor_compra.Location = new System.Drawing.Point(165, 299);
            this.txt_cuil_proveedor_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cuil_proveedor_compra.Mask = "00.000.000";
            this.txt_cuil_proveedor_compra.Name = "txt_cuil_proveedor_compra";
            this.txt_cuil_proveedor_compra.Size = new System.Drawing.Size(96, 22);
            this.txt_cuil_proveedor_compra.TabIndex = 32;
            // 
            // txt_libro_compra
            // 
            this.txt_libro_compra.Location = new System.Drawing.Point(89, 254);
            this.txt_libro_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_libro_compra.Name = "txt_libro_compra";
            this.txt_libro_compra.Size = new System.Drawing.Size(172, 22);
            this.txt_libro_compra.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Libro";
            // 
            // btn_eliminar_articulo_compra
            // 
            this.btn_eliminar_articulo_compra.Location = new System.Drawing.Point(187, 175);
            this.btn_eliminar_articulo_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar_articulo_compra.Name = "btn_eliminar_articulo_compra";
            this.btn_eliminar_articulo_compra.Size = new System.Drawing.Size(173, 28);
            this.btn_eliminar_articulo_compra.TabIndex = 37;
            this.btn_eliminar_articulo_compra.Text = "Eliminar Articulo";
            this.btn_eliminar_articulo_compra.UseVisualStyleBackColor = true;
            this.btn_eliminar_articulo_compra.Click += new System.EventHandler(this.btn_eliminar_articulo_compra_Click);
            // 
            // btn_alta_compra
            // 
            this.btn_alta_compra.Location = new System.Drawing.Point(49, 175);
            this.btn_alta_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alta_compra.Name = "btn_alta_compra";
            this.btn_alta_compra.Size = new System.Drawing.Size(131, 28);
            this.btn_alta_compra.TabIndex = 36;
            this.btn_alta_compra.Text = "Realizar Compra";
            this.btn_alta_compra.UseVisualStyleBackColor = true;
            this.btn_alta_compra.Click += new System.EventHandler(this.btn_alta_compra_Click);
            // 
            // grp_libro_compra
            // 
            this.grp_libro_compra.Controls.Add(this.btn_cancelar_libro_compra);
            this.grp_libro_compra.Controls.Add(this.btn_agregar_libro_compra);
            this.grp_libro_compra.Controls.Add(this.lbl_titulo_libro);
            this.grp_libro_compra.Controls.Add(this.nud_cantidad_libro_compra);
            this.grp_libro_compra.Controls.Add(this.label2);
            this.grp_libro_compra.Location = new System.Drawing.Point(13, 375);
            this.grp_libro_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_libro_compra.Name = "grp_libro_compra";
            this.grp_libro_compra.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_libro_compra.Size = new System.Drawing.Size(472, 116);
            this.grp_libro_compra.TabIndex = 38;
            this.grp_libro_compra.TabStop = false;
            this.grp_libro_compra.Text = "Detalle del libro";
            this.grp_libro_compra.Visible = false;
            // 
            // btn_cancelar_libro_compra
            // 
            this.btn_cancelar_libro_compra.Location = new System.Drawing.Point(8, 75);
            this.btn_cancelar_libro_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar_libro_compra.Name = "btn_cancelar_libro_compra";
            this.btn_cancelar_libro_compra.Size = new System.Drawing.Size(79, 28);
            this.btn_cancelar_libro_compra.TabIndex = 22;
            this.btn_cancelar_libro_compra.Text = "Cancelar";
            this.btn_cancelar_libro_compra.UseVisualStyleBackColor = true;
            this.btn_cancelar_libro_compra.Click += new System.EventHandler(this.btn_cancelar_libro_compra_Click);
            // 
            // btn_agregar_libro_compra
            // 
            this.btn_agregar_libro_compra.Location = new System.Drawing.Point(8, 38);
            this.btn_agregar_libro_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar_libro_compra.Name = "btn_agregar_libro_compra";
            this.btn_agregar_libro_compra.Size = new System.Drawing.Size(79, 28);
            this.btn_agregar_libro_compra.TabIndex = 21;
            this.btn_agregar_libro_compra.Text = "Agregar";
            this.btn_agregar_libro_compra.UseVisualStyleBackColor = true;
            this.btn_agregar_libro_compra.Click += new System.EventHandler(this.btn_agregar_libro_compra_Click);
            // 
            // lbl_titulo_libro
            // 
            this.lbl_titulo_libro.AutoSize = true;
            this.lbl_titulo_libro.Location = new System.Drawing.Point(261, 44);
            this.lbl_titulo_libro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo_libro.Name = "lbl_titulo_libro";
            this.lbl_titulo_libro.Size = new System.Drawing.Size(46, 17);
            this.lbl_titulo_libro.TabIndex = 2;
            this.lbl_titulo_libro.Text = "label9";
            // 
            // nud_cantidad_libro_compra
            // 
            this.nud_cantidad_libro_compra.Location = new System.Drawing.Point(95, 42);
            this.nud_cantidad_libro_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_cantidad_libro_compra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cantidad_libro_compra.Name = "nud_cantidad_libro_compra";
            this.nud_cantidad_libro_compra.Size = new System.Drawing.Size(48, 22);
            this.nud_cantidad_libro_compra.TabIndex = 19;
            this.nud_cantidad_libro_compra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo:";
            // 
            // grp_grupo_proveedor
            // 
            this.grp_grupo_proveedor.Controls.Add(this.btn_cancelar_proveedor);
            this.grp_grupo_proveedor.Controls.Add(this.lbl_razon_social_proveedor);
            this.grp_grupo_proveedor.Controls.Add(this.lbl_cuil_proveedor);
            this.grp_grupo_proveedor.Controls.Add(this.label7);
            this.grp_grupo_proveedor.Controls.Add(this.label6);
            this.grp_grupo_proveedor.Location = new System.Drawing.Point(523, 386);
            this.grp_grupo_proveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_grupo_proveedor.Name = "grp_grupo_proveedor";
            this.grp_grupo_proveedor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_grupo_proveedor.Size = new System.Drawing.Size(404, 116);
            this.grp_grupo_proveedor.TabIndex = 39;
            this.grp_grupo_proveedor.TabStop = false;
            this.grp_grupo_proveedor.Text = "Datos del Proveedor";
            this.grp_grupo_proveedor.Visible = false;
            // 
            // btn_cancelar_proveedor
            // 
            this.btn_cancelar_proveedor.Location = new System.Drawing.Point(243, 38);
            this.btn_cancelar_proveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar_proveedor.Name = "btn_cancelar_proveedor";
            this.btn_cancelar_proveedor.Size = new System.Drawing.Size(100, 28);
            this.btn_cancelar_proveedor.TabIndex = 4;
            this.btn_cancelar_proveedor.Text = "Cancelar";
            this.btn_cancelar_proveedor.UseVisualStyleBackColor = true;
            this.btn_cancelar_proveedor.Click += new System.EventHandler(this.btn_cancelar_proveedor_Click);
            // 
            // lbl_razon_social_proveedor
            // 
            this.lbl_razon_social_proveedor.AutoSize = true;
            this.lbl_razon_social_proveedor.Location = new System.Drawing.Point(131, 75);
            this.lbl_razon_social_proveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_razon_social_proveedor.Name = "lbl_razon_social_proveedor";
            this.lbl_razon_social_proveedor.Size = new System.Drawing.Size(46, 17);
            this.lbl_razon_social_proveedor.TabIndex = 3;
            this.lbl_razon_social_proveedor.Text = "label8";
            // 
            // lbl_cuil_proveedor
            // 
            this.lbl_cuil_proveedor.AutoSize = true;
            this.lbl_cuil_proveedor.Location = new System.Drawing.Point(131, 38);
            this.lbl_cuil_proveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cuil_proveedor.Name = "lbl_cuil_proveedor";
            this.lbl_cuil_proveedor.Size = new System.Drawing.Size(46, 17);
            this.lbl_cuil_proveedor.TabIndex = 2;
            this.lbl_cuil_proveedor.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cuil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Razón Social";
            // 
            // txt_monto_unitario_inventario_compra
            // 
            this.txt_monto_unitario_inventario_compra.Location = new System.Drawing.Point(713, 255);
            this.txt_monto_unitario_inventario_compra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_monto_unitario_inventario_compra.Name = "txt_monto_unitario_inventario_compra";
            this.txt_monto_unitario_inventario_compra.Size = new System.Drawing.Size(132, 22);
            this.txt_monto_unitario_inventario_compra.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Monto Unitario";
            // 
            // FormularioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 546);
            this.Controls.Add(this.txt_monto_unitario_inventario_compra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grp_grupo_proveedor);
            this.Controls.Add(this.grp_libro_compra);
            this.Controls.Add(this.btn_eliminar_articulo_compra);
            this.Controls.Add(this.btn_alta_compra);
            this.Controls.Add(this.btn_buscar_libro);
            this.Controls.Add(this.btn_buscar_proveedor_compra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cuil_proveedor_compra);
            this.Controls.Add(this.txt_libro_compra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_compra);
            this.Controls.Add(this.grillaCompra);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioCompra";
            this.Text = "FormularioCompra";
            this.Load += new System.EventHandler(this.FormularioCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCompra)).EndInit();
            this.grp_compra.ResumeLayout(false);
            this.grp_compra.PerformLayout();
            this.grp_libro_compra.ResumeLayout(false);
            this.grp_libro_compra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_libro_compra)).EndInit();
            this.grp_grupo_proveedor.ResumeLayout(false);
            this.grp_grupo_proveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grillaCompra;
        private System.Windows.Forms.GroupBox grp_compra;
        private System.Windows.Forms.Label lbl_total_compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar_libro;
        private System.Windows.Forms.Button btn_buscar_proveedor_compra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_cuil_proveedor_compra;
        private System.Windows.Forms.TextBox txt_libro_compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar_articulo_compra;
        private System.Windows.Forms.Button btn_alta_compra;
        private System.Windows.Forms.GroupBox grp_libro_compra;
        private System.Windows.Forms.Button btn_cancelar_libro_compra;
        private System.Windows.Forms.Button btn_agregar_libro_compra;
        private System.Windows.Forms.Label lbl_titulo_libro;
        private System.Windows.Forms.NumericUpDown nud_cantidad_libro_compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp_grupo_proveedor;
        private System.Windows.Forms.Button btn_cancelar_proveedor;
        private System.Windows.Forms.Label lbl_razon_social_proveedor;
        private System.Windows.Forms.Label lbl_cuil_proveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_monto_unitario_inventario_compra;
        private System.Windows.Forms.Label label10;
    }
}