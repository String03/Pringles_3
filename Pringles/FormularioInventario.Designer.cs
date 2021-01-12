namespace Pringles
{
    partial class FormularioInventario
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
            this.grillaLibro = new System.Windows.Forms.DataGridView();
            this.btn_alta_libro = new System.Windows.Forms.Button();
            this.btn_baja_libro = new System.Windows.Forms.Button();
            this.btn_modificacion_libro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_titulo_libro = new System.Windows.Forms.TextBox();
            this.txt_isbn_libro = new System.Windows.Forms.TextBox();
            this.cmb_autor_libro = new System.Windows.Forms.ComboBox();
            this.cmb_genero_libro = new System.Windows.Forms.ComboBox();
            this.btn_agregar_autor = new System.Windows.Forms.Button();
            this.btn_agregar_genero = new System.Windows.Forms.Button();
            this.btn_libros_terminan = new System.Windows.Forms.Button();
            this.chk_restringido = new System.Windows.Forms.CheckBox();
            this.chk_prohibido = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_criterio_acaba = new System.Windows.Forms.NumericUpDown();
            this.nud_criterio_esperado = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_proveedores_inventario = new System.Windows.Forms.ComboBox();
            this.btn_agregar_compra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_monto_unitario_venta = new System.Windows.Forms.TextBox();
            this.btn_recepcion_de_libros = new System.Windows.Forms.Button();
            this.grillaSeleccionarAutor = new System.Windows.Forms.DataGridView();
            this.agregar_autor_al_libro = new System.Windows.Forms.Button();
            this.limpiar_grilla_autor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_criterio_acaba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_criterio_esperado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionarAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaLibro
            // 
            this.grillaLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLibro.Location = new System.Drawing.Point(133, 46);
            this.grillaLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaLibro.MultiSelect = false;
            this.grillaLibro.Name = "grillaLibro";
            this.grillaLibro.ReadOnly = true;
            this.grillaLibro.RowTemplate.Height = 24;
            this.grillaLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaLibro.Size = new System.Drawing.Size(507, 150);
            this.grillaLibro.TabIndex = 0;
            this.grillaLibro.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaLibro_CellContentDoubleClick);
            // 
            // btn_alta_libro
            // 
            this.btn_alta_libro.Location = new System.Drawing.Point(133, 226);
            this.btn_alta_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alta_libro.Name = "btn_alta_libro";
            this.btn_alta_libro.Size = new System.Drawing.Size(75, 30);
            this.btn_alta_libro.TabIndex = 1;
            this.btn_alta_libro.Text = "Alta ";
            this.btn_alta_libro.UseVisualStyleBackColor = true;
            this.btn_alta_libro.Click += new System.EventHandler(this.btn_alta_libro_Click);
            // 
            // btn_baja_libro
            // 
            this.btn_baja_libro.Location = new System.Drawing.Point(333, 226);
            this.btn_baja_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_baja_libro.Name = "btn_baja_libro";
            this.btn_baja_libro.Size = new System.Drawing.Size(75, 30);
            this.btn_baja_libro.TabIndex = 2;
            this.btn_baja_libro.Text = "Baja";
            this.btn_baja_libro.UseVisualStyleBackColor = true;
            this.btn_baja_libro.Click += new System.EventHandler(this.btn_baja_libro_Click);
            // 
            // btn_modificacion_libro
            // 
            this.btn_modificacion_libro.Location = new System.Drawing.Point(543, 226);
            this.btn_modificacion_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificacion_libro.Name = "btn_modificacion_libro";
            this.btn_modificacion_libro.Size = new System.Drawing.Size(111, 30);
            this.btn_modificacion_libro.TabIndex = 3;
            this.btn_modificacion_libro.Text = "Modificación";
            this.btn_modificacion_libro.UseVisualStyleBackColor = true;
            this.btn_modificacion_libro.Click += new System.EventHandler(this.btn_modificacion_libro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Género";
            // 
            // txt_titulo_libro
            // 
            this.txt_titulo_libro.Location = new System.Drawing.Point(284, 323);
            this.txt_titulo_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_titulo_libro.MaxLength = 120;
            this.txt_titulo_libro.Name = "txt_titulo_libro";
            this.txt_titulo_libro.Size = new System.Drawing.Size(100, 22);
            this.txt_titulo_libro.TabIndex = 9;
            // 
            // txt_isbn_libro
            // 
            this.txt_isbn_libro.Location = new System.Drawing.Point(284, 282);
            this.txt_isbn_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_isbn_libro.MaxLength = 40;
            this.txt_isbn_libro.Name = "txt_isbn_libro";
            this.txt_isbn_libro.Size = new System.Drawing.Size(100, 22);
            this.txt_isbn_libro.TabIndex = 10;
            this.txt_isbn_libro.TextChanged += new System.EventHandler(this.txt_isbn_libro_TextChanged);
            // 
            // cmb_autor_libro
            // 
            this.cmb_autor_libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_autor_libro.FormattingEnabled = true;
            this.cmb_autor_libro.Location = new System.Drawing.Point(281, 362);
            this.cmb_autor_libro.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_autor_libro.Name = "cmb_autor_libro";
            this.cmb_autor_libro.Size = new System.Drawing.Size(100, 24);
            this.cmb_autor_libro.TabIndex = 14;
            // 
            // cmb_genero_libro
            // 
            this.cmb_genero_libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_genero_libro.FormattingEnabled = true;
            this.cmb_genero_libro.Location = new System.Drawing.Point(281, 407);
            this.cmb_genero_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_genero_libro.Name = "cmb_genero_libro";
            this.cmb_genero_libro.Size = new System.Drawing.Size(100, 24);
            this.cmb_genero_libro.TabIndex = 15;
            // 
            // btn_agregar_autor
            // 
            this.btn_agregar_autor.Location = new System.Drawing.Point(795, 373);
            this.btn_agregar_autor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_autor.Name = "btn_agregar_autor";
            this.btn_agregar_autor.Size = new System.Drawing.Size(152, 23);
            this.btn_agregar_autor.TabIndex = 16;
            this.btn_agregar_autor.Text = "Agregar Autor";
            this.btn_agregar_autor.UseVisualStyleBackColor = true;
            this.btn_agregar_autor.Click += new System.EventHandler(this.btn_agregar_autor_Click);
            // 
            // btn_agregar_genero
            // 
            this.btn_agregar_genero.Location = new System.Drawing.Point(795, 424);
            this.btn_agregar_genero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_genero.Name = "btn_agregar_genero";
            this.btn_agregar_genero.Size = new System.Drawing.Size(152, 23);
            this.btn_agregar_genero.TabIndex = 17;
            this.btn_agregar_genero.Text = "Agregar Género";
            this.btn_agregar_genero.UseVisualStyleBackColor = true;
            this.btn_agregar_genero.Click += new System.EventHandler(this.btn_agregar_genero_Click);
            // 
            // btn_libros_terminan
            // 
            this.btn_libros_terminan.Location = new System.Drawing.Point(675, 143);
            this.btn_libros_terminan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_libros_terminan.Name = "btn_libros_terminan";
            this.btn_libros_terminan.Size = new System.Drawing.Size(100, 53);
            this.btn_libros_terminan.TabIndex = 25;
            this.btn_libros_terminan.Text = "Libros Agotados";
            this.btn_libros_terminan.UseVisualStyleBackColor = true;
            this.btn_libros_terminan.Click += new System.EventHandler(this.btn_libros_terminan_Click);
            // 
            // chk_restringido
            // 
            this.chk_restringido.AutoSize = true;
            this.chk_restringido.Location = new System.Drawing.Point(425, 284);
            this.chk_restringido.Margin = new System.Windows.Forms.Padding(4);
            this.chk_restringido.Name = "chk_restringido";
            this.chk_restringido.Size = new System.Drawing.Size(102, 21);
            this.chk_restringido.TabIndex = 28;
            this.chk_restringido.Text = "Restringido";
            this.chk_restringido.UseVisualStyleBackColor = true;
            // 
            // chk_prohibido
            // 
            this.chk_prohibido.AutoSize = true;
            this.chk_prohibido.Location = new System.Drawing.Point(425, 325);
            this.chk_prohibido.Margin = new System.Windows.Forms.Padding(4);
            this.chk_prohibido.Name = "chk_prohibido";
            this.chk_prohibido.Size = new System.Drawing.Size(90, 21);
            this.chk_prohibido.TabIndex = 29;
            this.chk_prohibido.Text = "Prohibido";
            this.chk_prohibido.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 477);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Criterio Acaba Stock";
            // 
            // nud_criterio_acaba
            // 
            this.nud_criterio_acaba.Location = new System.Drawing.Point(281, 472);
            this.nud_criterio_acaba.Margin = new System.Windows.Forms.Padding(4);
            this.nud_criterio_acaba.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_criterio_acaba.Name = "nud_criterio_acaba";
            this.nud_criterio_acaba.Size = new System.Drawing.Size(100, 22);
            this.nud_criterio_acaba.TabIndex = 31;
            this.nud_criterio_acaba.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_criterio_esperado
            // 
            this.nud_criterio_esperado.Location = new System.Drawing.Point(281, 536);
            this.nud_criterio_esperado.Margin = new System.Windows.Forms.Padding(4);
            this.nud_criterio_esperado.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_criterio_esperado.Name = "nud_criterio_esperado";
            this.nud_criterio_esperado.Size = new System.Drawing.Size(100, 22);
            this.nud_criterio_esperado.TabIndex = 32;
            this.nud_criterio_esperado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 536);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Criterio Esperado Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Proveedores";
            // 
            // cmb_proveedores_inventario
            // 
            this.cmb_proveedores_inventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_proveedores_inventario.FormattingEnabled = true;
            this.cmb_proveedores_inventario.Location = new System.Drawing.Point(276, 597);
            this.cmb_proveedores_inventario.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_proveedores_inventario.Name = "cmb_proveedores_inventario";
            this.cmb_proveedores_inventario.Size = new System.Drawing.Size(132, 24);
            this.cmb_proveedores_inventario.TabIndex = 35;
            // 
            // btn_agregar_compra
            // 
            this.btn_agregar_compra.Location = new System.Drawing.Point(795, 528);
            this.btn_agregar_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_compra.Name = "btn_agregar_compra";
            this.btn_agregar_compra.Size = new System.Drawing.Size(128, 30);
            this.btn_agregar_compra.TabIndex = 36;
            this.btn_agregar_compra.Text = "Agregar Compra";
            this.btn_agregar_compra.UseVisualStyleBackColor = true;
            this.btn_agregar_compra.Click += new System.EventHandler(this.btn_agregar_compra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 668);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Precio Unitario de Venta";
            // 
            // txt_monto_unitario_venta
            // 
            this.txt_monto_unitario_venta.Location = new System.Drawing.Point(276, 663);
            this.txt_monto_unitario_venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_monto_unitario_venta.MaxLength = 120;
            this.txt_monto_unitario_venta.Name = "txt_monto_unitario_venta";
            this.txt_monto_unitario_venta.Size = new System.Drawing.Size(100, 22);
            this.txt_monto_unitario_venta.TabIndex = 38;
            // 
            // btn_recepcion_de_libros
            // 
            this.btn_recepcion_de_libros.Location = new System.Drawing.Point(795, 472);
            this.btn_recepcion_de_libros.Name = "btn_recepcion_de_libros";
            this.btn_recepcion_de_libros.Size = new System.Drawing.Size(152, 28);
            this.btn_recepcion_de_libros.TabIndex = 44;
            this.btn_recepcion_de_libros.Text = "Recepción de libros";
            this.btn_recepcion_de_libros.UseVisualStyleBackColor = true;
            this.btn_recepcion_de_libros.Click += new System.EventHandler(this.btn_recepcion_de_libros_Click);
            // 
            // grillaSeleccionarAutor
            // 
            this.grillaSeleccionarAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSeleccionarAutor.Location = new System.Drawing.Point(434, 362);
            this.grillaSeleccionarAutor.MultiSelect = false;
            this.grillaSeleccionarAutor.Name = "grillaSeleccionarAutor";
            this.grillaSeleccionarAutor.ReadOnly = true;
            this.grillaSeleccionarAutor.RowTemplate.Height = 24;
            this.grillaSeleccionarAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaSeleccionarAutor.Size = new System.Drawing.Size(284, 150);
            this.grillaSeleccionarAutor.TabIndex = 45;
            // 
            // agregar_autor_al_libro
            // 
            this.agregar_autor_al_libro.Location = new System.Drawing.Point(434, 528);
            this.agregar_autor_al_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregar_autor_al_libro.Name = "agregar_autor_al_libro";
            this.agregar_autor_al_libro.Size = new System.Drawing.Size(128, 57);
            this.agregar_autor_al_libro.TabIndex = 46;
            this.agregar_autor_al_libro.Text = "Agregar Autor Al Libro";
            this.agregar_autor_al_libro.UseVisualStyleBackColor = true;
            this.agregar_autor_al_libro.Click += new System.EventHandler(this.agregar_autor_al_libro_Click);
            // 
            // limpiar_grilla_autor
            // 
            this.limpiar_grilla_autor.Location = new System.Drawing.Point(590, 536);
            this.limpiar_grilla_autor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.limpiar_grilla_autor.Name = "limpiar_grilla_autor";
            this.limpiar_grilla_autor.Size = new System.Drawing.Size(128, 30);
            this.limpiar_grilla_autor.TabIndex = 47;
            this.limpiar_grilla_autor.Text = "Limpiar Grilla";
            this.limpiar_grilla_autor.UseVisualStyleBackColor = true;
            this.limpiar_grilla_autor.Click += new System.EventHandler(this.limpiar_grilla_autor_Click);
            // 
            // FormularioInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 766);
            this.Controls.Add(this.limpiar_grilla_autor);
            this.Controls.Add(this.agregar_autor_al_libro);
            this.Controls.Add(this.grillaSeleccionarAutor);
            this.Controls.Add(this.btn_recepcion_de_libros);
            this.Controls.Add(this.txt_monto_unitario_venta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_agregar_compra);
            this.Controls.Add(this.cmb_proveedores_inventario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nud_criterio_esperado);
            this.Controls.Add(this.nud_criterio_acaba);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chk_prohibido);
            this.Controls.Add(this.chk_restringido);
            this.Controls.Add(this.btn_libros_terminan);
            this.Controls.Add(this.btn_agregar_genero);
            this.Controls.Add(this.btn_agregar_autor);
            this.Controls.Add(this.cmb_genero_libro);
            this.Controls.Add(this.cmb_autor_libro);
            this.Controls.Add(this.txt_isbn_libro);
            this.Controls.Add(this.txt_titulo_libro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificacion_libro);
            this.Controls.Add(this.btn_baja_libro);
            this.Controls.Add(this.btn_alta_libro);
            this.Controls.Add(this.grillaLibro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioInventario";
            this.Text = "FormularioInventario";
            this.Load += new System.EventHandler(this.FormularioInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_criterio_acaba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_criterio_esperado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSeleccionarAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaLibro;
        private System.Windows.Forms.Button btn_alta_libro;
        private System.Windows.Forms.Button btn_baja_libro;
        private System.Windows.Forms.Button btn_modificacion_libro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_titulo_libro;
        private System.Windows.Forms.TextBox txt_isbn_libro;
        private System.Windows.Forms.ComboBox cmb_autor_libro;
        private System.Windows.Forms.ComboBox cmb_genero_libro;
        private System.Windows.Forms.Button btn_agregar_autor;
        private System.Windows.Forms.Button btn_agregar_genero;
        private System.Windows.Forms.Button btn_libros_terminan;
        private System.Windows.Forms.CheckBox chk_restringido;
        private System.Windows.Forms.CheckBox chk_prohibido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_criterio_acaba;
        private System.Windows.Forms.NumericUpDown nud_criterio_esperado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_proveedores_inventario;
        private System.Windows.Forms.Button btn_agregar_compra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto_unitario_venta;
        private System.Windows.Forms.Button btn_recepcion_de_libros;
        private System.Windows.Forms.DataGridView grillaSeleccionarAutor;
        private System.Windows.Forms.Button agregar_autor_al_libro;
        private System.Windows.Forms.Button limpiar_grilla_autor;
    }
}