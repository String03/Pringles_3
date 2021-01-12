namespace Pringles
{
    partial class FormularioVenta
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
            this.grillaVenta = new System.Windows.Forms.DataGridView();
            this.btn_alta_venta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_libro_venta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_monto_tarjeta = new System.Windows.Forms.TextBox();
            this.txt_monto_efectivo = new System.Windows.Forms.TextBox();
            this.ch_tarjeta_credito_forma_pago = new System.Windows.Forms.CheckBox();
            this.ch_efectivo_forma_pago = new System.Windows.Forms.CheckBox();
            this.txt_dni_clilente_venta = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.grp_grupo_cliente = new System.Windows.Forms.GroupBox();
            this.btn_cancelar_cliente = new System.Windows.Forms.Button();
            this.lbl_nombre_cliente = new System.Windows.Forms.Label();
            this.lbl_dni_cliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_cantidad_libro_venta = new System.Windows.Forms.NumericUpDown();
            this.grp_libro_venta = new System.Windows.Forms.GroupBox();
            this.btn_cancelar_libro = new System.Windows.Forms.Button();
            this.btn_agregar_libro = new System.Windows.Forms.Button();
            this.lbl_precio_libro = new System.Windows.Forms.Label();
            this.lbl_titulo_libro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar_libro = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.grp_venta = new System.Windows.Forms.GroupBox();
            this.btn_eliminar_descuento = new System.Windows.Forms.Button();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.lbl_desc_descuento = new System.Windows.Forms.Label();
            this.lbl_total_venta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_eliminar_articulo = new System.Windows.Forms.Button();
            this.grv_descuentos = new System.Windows.Forms.DataGridView();
            this.grp_descuentos = new System.Windows.Forms.GroupBox();
            this.btn_descuentos_generos = new System.Windows.Forms.Button();
            this.btn_descuentos_autor = new System.Windows.Forms.Button();
            this.btn_seleccionar_descuento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_autor_mas_vendido = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_genero_mas_vendido = new System.Windows.Forms.Label();
            this.btn_mostrar_factura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_grupo_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_libro_venta)).BeginInit();
            this.grp_libro_venta.SuspendLayout();
            this.grp_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_descuentos)).BeginInit();
            this.grp_descuentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaVenta
            // 
            this.grillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVenta.Location = new System.Drawing.Point(24, 47);
            this.grillaVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaVenta.Name = "grillaVenta";
            this.grillaVenta.ReadOnly = true;
            this.grillaVenta.RowTemplate.Height = 24;
            this.grillaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaVenta.Size = new System.Drawing.Size(487, 150);
            this.grillaVenta.TabIndex = 0;
            // 
            // btn_alta_venta
            // 
            this.btn_alta_venta.Location = new System.Drawing.Point(24, 215);
            this.btn_alta_venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alta_venta.Name = "btn_alta_venta";
            this.btn_alta_venta.Size = new System.Drawing.Size(131, 28);
            this.btn_alta_venta.TabIndex = 1;
            this.btn_alta_venta.Text = "Realizar Venta";
            this.btn_alta_venta.UseVisualStyleBackColor = true;
            this.btn_alta_venta.Click += new System.EventHandler(this.btn_alta_venta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Libro";
            // 
            // txt_libro_venta
            // 
            this.txt_libro_venta.Location = new System.Drawing.Point(69, 261);
            this.txt_libro_venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_libro_venta.Name = "txt_libro_venta";
            this.txt_libro_venta.Size = new System.Drawing.Size(172, 22);
            this.txt_libro_venta.TabIndex = 7;
            this.txt_libro_venta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_libro_venta_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_monto_tarjeta);
            this.groupBox1.Controls.Add(this.txt_monto_efectivo);
            this.groupBox1.Controls.Add(this.ch_tarjeta_credito_forma_pago);
            this.groupBox1.Controls.Add(this.ch_efectivo_forma_pago);
            this.groupBox1.Location = new System.Drawing.Point(756, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(279, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de Pago";
            // 
            // txt_monto_tarjeta
            // 
            this.txt_monto_tarjeta.Location = new System.Drawing.Point(112, 85);
            this.txt_monto_tarjeta.Name = "txt_monto_tarjeta";
            this.txt_monto_tarjeta.Size = new System.Drawing.Size(132, 22);
            this.txt_monto_tarjeta.TabIndex = 5;
            this.txt_monto_tarjeta.Leave += new System.EventHandler(this.txt_monto_tarjeta_Leave);
            // 
            // txt_monto_efectivo
            // 
            this.txt_monto_efectivo.Location = new System.Drawing.Point(112, 39);
            this.txt_monto_efectivo.Name = "txt_monto_efectivo";
            this.txt_monto_efectivo.Size = new System.Drawing.Size(132, 22);
            this.txt_monto_efectivo.TabIndex = 4;
            this.txt_monto_efectivo.Leave += new System.EventHandler(this.txt_monto_efectivo_Leave);
            // 
            // ch_tarjeta_credito_forma_pago
            // 
            this.ch_tarjeta_credito_forma_pago.AutoSize = true;
            this.ch_tarjeta_credito_forma_pago.Location = new System.Drawing.Point(19, 85);
            this.ch_tarjeta_credito_forma_pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ch_tarjeta_credito_forma_pago.Name = "ch_tarjeta_credito_forma_pago";
            this.ch_tarjeta_credito_forma_pago.Size = new System.Drawing.Size(75, 21);
            this.ch_tarjeta_credito_forma_pago.TabIndex = 1;
            this.ch_tarjeta_credito_forma_pago.Text = "Tarjeta";
            this.ch_tarjeta_credito_forma_pago.UseVisualStyleBackColor = true;
            this.ch_tarjeta_credito_forma_pago.CheckedChanged += new System.EventHandler(this.ch_tarjeta_credito_forma_pago_CheckedChanged);
            // 
            // ch_efectivo_forma_pago
            // 
            this.ch_efectivo_forma_pago.AutoSize = true;
            this.ch_efectivo_forma_pago.Location = new System.Drawing.Point(19, 39);
            this.ch_efectivo_forma_pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ch_efectivo_forma_pago.Name = "ch_efectivo_forma_pago";
            this.ch_efectivo_forma_pago.Size = new System.Drawing.Size(80, 21);
            this.ch_efectivo_forma_pago.TabIndex = 0;
            this.ch_efectivo_forma_pago.Text = "Efectivo";
            this.ch_efectivo_forma_pago.UseVisualStyleBackColor = true;
            this.ch_efectivo_forma_pago.CheckedChanged += new System.EventHandler(this.ch_efectivo_forma_pago_CheckedChanged);
            // 
            // txt_dni_clilente_venta
            // 
            this.txt_dni_clilente_venta.Location = new System.Drawing.Point(145, 332);
            this.txt_dni_clilente_venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dni_clilente_venta.Mask = "00.000.000";
            this.txt_dni_clilente_venta.Name = "txt_dni_clilente_venta";
            this.txt_dni_clilente_venta.Size = new System.Drawing.Size(96, 22);
            this.txt_dni_clilente_venta.TabIndex = 14;
            this.txt_dni_clilente_venta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dni_clilente_venta_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "DNI Cliente";
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.Location = new System.Drawing.Point(249, 330);
            this.btn_buscar_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(122, 44);
            this.btn_buscar_cliente.TabIndex = 16;
            this.btn_buscar_cliente.Text = "Buscar Cliente por DNI";
            this.btn_buscar_cliente.UseVisualStyleBackColor = true;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // grp_grupo_cliente
            // 
            this.grp_grupo_cliente.Controls.Add(this.btn_cancelar_cliente);
            this.grp_grupo_cliente.Controls.Add(this.lbl_nombre_cliente);
            this.grp_grupo_cliente.Controls.Add(this.lbl_dni_cliente);
            this.grp_grupo_cliente.Controls.Add(this.label7);
            this.grp_grupo_cliente.Controls.Add(this.label6);
            this.grp_grupo_cliente.Location = new System.Drawing.Point(559, 402);
            this.grp_grupo_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.grp_grupo_cliente.Name = "grp_grupo_cliente";
            this.grp_grupo_cliente.Padding = new System.Windows.Forms.Padding(4);
            this.grp_grupo_cliente.Size = new System.Drawing.Size(360, 116);
            this.grp_grupo_cliente.TabIndex = 17;
            this.grp_grupo_cliente.TabStop = false;
            this.grp_grupo_cliente.Text = "Datos del Cliente";
            this.grp_grupo_cliente.Visible = false;
            // 
            // btn_cancelar_cliente
            // 
            this.btn_cancelar_cliente.Location = new System.Drawing.Point(173, 32);
            this.btn_cancelar_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar_cliente.Name = "btn_cancelar_cliente";
            this.btn_cancelar_cliente.Size = new System.Drawing.Size(100, 28);
            this.btn_cancelar_cliente.TabIndex = 4;
            this.btn_cancelar_cliente.Text = "Cancelar";
            this.btn_cancelar_cliente.UseVisualStyleBackColor = true;
            this.btn_cancelar_cliente.Click += new System.EventHandler(this.btn_cancelar_cliente_Click);
            // 
            // lbl_nombre_cliente
            // 
            this.lbl_nombre_cliente.AutoSize = true;
            this.lbl_nombre_cliente.Location = new System.Drawing.Point(88, 75);
            this.lbl_nombre_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_cliente.Name = "lbl_nombre_cliente";
            this.lbl_nombre_cliente.Size = new System.Drawing.Size(46, 17);
            this.lbl_nombre_cliente.TabIndex = 3;
            this.lbl_nombre_cliente.Text = "label8";
            // 
            // lbl_dni_cliente
            // 
            this.lbl_dni_cliente.AutoSize = true;
            this.lbl_dni_cliente.Location = new System.Drawing.Point(88, 38);
            this.lbl_dni_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dni_cliente.Name = "lbl_dni_cliente";
            this.lbl_dni_cliente.Size = new System.Drawing.Size(46, 17);
            this.lbl_dni_cliente.TabIndex = 2;
            this.lbl_dni_cliente.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dni:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre:";
            // 
            // nud_cantidad_libro_venta
            // 
            this.nud_cantidad_libro_venta.Location = new System.Drawing.Point(95, 42);
            this.nud_cantidad_libro_venta.Margin = new System.Windows.Forms.Padding(4);
            this.nud_cantidad_libro_venta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cantidad_libro_venta.Name = "nud_cantidad_libro_venta";
            this.nud_cantidad_libro_venta.Size = new System.Drawing.Size(48, 22);
            this.nud_cantidad_libro_venta.TabIndex = 19;
            this.nud_cantidad_libro_venta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grp_libro_venta
            // 
            this.grp_libro_venta.Controls.Add(this.btn_cancelar_libro);
            this.grp_libro_venta.Controls.Add(this.btn_agregar_libro);
            this.grp_libro_venta.Controls.Add(this.lbl_precio_libro);
            this.grp_libro_venta.Controls.Add(this.lbl_titulo_libro);
            this.grp_libro_venta.Controls.Add(this.nud_cantidad_libro_venta);
            this.grp_libro_venta.Controls.Add(this.label8);
            this.grp_libro_venta.Controls.Add(this.label2);
            this.grp_libro_venta.Location = new System.Drawing.Point(16, 402);
            this.grp_libro_venta.Margin = new System.Windows.Forms.Padding(4);
            this.grp_libro_venta.Name = "grp_libro_venta";
            this.grp_libro_venta.Padding = new System.Windows.Forms.Padding(4);
            this.grp_libro_venta.Size = new System.Drawing.Size(472, 116);
            this.grp_libro_venta.TabIndex = 20;
            this.grp_libro_venta.TabStop = false;
            this.grp_libro_venta.Text = "Detalle del libro";
            this.grp_libro_venta.Visible = false;
            // 
            // btn_cancelar_libro
            // 
            this.btn_cancelar_libro.Location = new System.Drawing.Point(8, 75);
            this.btn_cancelar_libro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar_libro.Name = "btn_cancelar_libro";
            this.btn_cancelar_libro.Size = new System.Drawing.Size(79, 28);
            this.btn_cancelar_libro.TabIndex = 22;
            this.btn_cancelar_libro.Text = "Cancelar";
            this.btn_cancelar_libro.UseVisualStyleBackColor = true;
            this.btn_cancelar_libro.Click += new System.EventHandler(this.btn_cancelar_libro_Click);
            // 
            // btn_agregar_libro
            // 
            this.btn_agregar_libro.Location = new System.Drawing.Point(8, 38);
            this.btn_agregar_libro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar_libro.Name = "btn_agregar_libro";
            this.btn_agregar_libro.Size = new System.Drawing.Size(79, 28);
            this.btn_agregar_libro.TabIndex = 21;
            this.btn_agregar_libro.Text = "Agregar";
            this.btn_agregar_libro.UseVisualStyleBackColor = true;
            this.btn_agregar_libro.Click += new System.EventHandler(this.btn_agregar_libro_Click);
            // 
            // lbl_precio_libro
            // 
            this.lbl_precio_libro.AutoSize = true;
            this.lbl_precio_libro.Location = new System.Drawing.Point(261, 81);
            this.lbl_precio_libro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio_libro.Name = "lbl_precio_libro";
            this.lbl_precio_libro.Size = new System.Drawing.Size(46, 17);
            this.lbl_precio_libro.TabIndex = 3;
            this.lbl_precio_libro.Text = "label9";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Precio Unitario:";
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
            // btn_buscar_libro
            // 
            this.btn_buscar_libro.Location = new System.Drawing.Point(249, 261);
            this.btn_buscar_libro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar_libro.Name = "btn_buscar_libro";
            this.btn_buscar_libro.Size = new System.Drawing.Size(143, 48);
            this.btn_buscar_libro.TabIndex = 21;
            this.btn_buscar_libro.Text = "Buscar Libro por ISBN";
            this.btn_buscar_libro.UseVisualStyleBackColor = true;
            this.btn_buscar_libro.Click += new System.EventHandler(this.btn_buscar_libro_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Venta realizada por:";
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(168, 12);
            this.lbl_nombre_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(54, 17);
            this.lbl_nombre_usuario.TabIndex = 23;
            this.lbl_nombre_usuario.Text = "label10";
            // 
            // grp_venta
            // 
            this.grp_venta.Controls.Add(this.btn_eliminar_descuento);
            this.grp_venta.Controls.Add(this.lbl_descuento);
            this.grp_venta.Controls.Add(this.lbl_desc_descuento);
            this.grp_venta.Controls.Add(this.lbl_total_venta);
            this.grp_venta.Controls.Add(this.label3);
            this.grp_venta.Location = new System.Drawing.Point(519, 47);
            this.grp_venta.Margin = new System.Windows.Forms.Padding(4);
            this.grp_venta.Name = "grp_venta";
            this.grp_venta.Padding = new System.Windows.Forms.Padding(4);
            this.grp_venta.Size = new System.Drawing.Size(231, 150);
            this.grp_venta.TabIndex = 24;
            this.grp_venta.TabStop = false;
            this.grp_venta.Text = "Detalles de la venta";
            // 
            // btn_eliminar_descuento
            // 
            this.btn_eliminar_descuento.Location = new System.Drawing.Point(8, 114);
            this.btn_eliminar_descuento.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar_descuento.Name = "btn_eliminar_descuento";
            this.btn_eliminar_descuento.Size = new System.Drawing.Size(215, 28);
            this.btn_eliminar_descuento.TabIndex = 4;
            this.btn_eliminar_descuento.Text = "Eliminar Descuento";
            this.btn_eliminar_descuento.UseVisualStyleBackColor = true;
            this.btn_eliminar_descuento.Visible = false;
            this.btn_eliminar_descuento.Click += new System.EventHandler(this.btn_eliminar_descuento_Click);
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Location = new System.Drawing.Point(16, 85);
            this.lbl_descuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(46, 17);
            this.lbl_descuento.TabIndex = 3;
            this.lbl_descuento.Text = "label4";
            // 
            // lbl_desc_descuento
            // 
            this.lbl_desc_descuento.AutoSize = true;
            this.lbl_desc_descuento.Location = new System.Drawing.Point(12, 64);
            this.lbl_desc_descuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desc_descuento.Name = "lbl_desc_descuento";
            this.lbl_desc_descuento.Size = new System.Drawing.Size(84, 17);
            this.lbl_desc_descuento.TabIndex = 2;
            this.lbl_desc_descuento.Text = "Descuento: ";
            // 
            // lbl_total_venta
            // 
            this.lbl_total_venta.AutoSize = true;
            this.lbl_total_venta.Location = new System.Drawing.Point(63, 39);
            this.lbl_total_venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total_venta.Name = "lbl_total_venta";
            this.lbl_total_venta.Size = new System.Drawing.Size(54, 17);
            this.lbl_total_venta.TabIndex = 1;
            this.lbl_total_venta.Text = "label10";
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
            // btn_eliminar_articulo
            // 
            this.btn_eliminar_articulo.Location = new System.Drawing.Point(161, 215);
            this.btn_eliminar_articulo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar_articulo.Name = "btn_eliminar_articulo";
            this.btn_eliminar_articulo.Size = new System.Drawing.Size(173, 28);
            this.btn_eliminar_articulo.TabIndex = 25;
            this.btn_eliminar_articulo.Text = "Eliminar Articulo";
            this.btn_eliminar_articulo.UseVisualStyleBackColor = true;
            this.btn_eliminar_articulo.Click += new System.EventHandler(this.btn_eliminar_articulo_Click);
            // 
            // grv_descuentos
            // 
            this.grv_descuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_descuentos.Location = new System.Drawing.Point(21, 23);
            this.grv_descuentos.Margin = new System.Windows.Forms.Padding(4);
            this.grv_descuentos.Name = "grv_descuentos";
            this.grv_descuentos.ReadOnly = true;
            this.grv_descuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_descuentos.Size = new System.Drawing.Size(303, 149);
            this.grv_descuentos.TabIndex = 27;
            this.grv_descuentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_descuentos_CellContentDoubleClick);
            // 
            // grp_descuentos
            // 
            this.grp_descuentos.Controls.Add(this.btn_descuentos_generos);
            this.grp_descuentos.Controls.Add(this.btn_descuentos_autor);
            this.grp_descuentos.Controls.Add(this.btn_seleccionar_descuento);
            this.grp_descuentos.Controls.Add(this.grv_descuentos);
            this.grp_descuentos.Location = new System.Drawing.Point(400, 215);
            this.grp_descuentos.Margin = new System.Windows.Forms.Padding(4);
            this.grp_descuentos.Name = "grp_descuentos";
            this.grp_descuentos.Padding = new System.Windows.Forms.Padding(4);
            this.grp_descuentos.Size = new System.Drawing.Size(453, 180);
            this.grp_descuentos.TabIndex = 28;
            this.grp_descuentos.TabStop = false;
            this.grp_descuentos.Text = "Descuentos";
            // 
            // btn_descuentos_generos
            // 
            this.btn_descuentos_generos.Location = new System.Drawing.Point(332, 128);
            this.btn_descuentos_generos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_descuentos_generos.Name = "btn_descuentos_generos";
            this.btn_descuentos_generos.Size = new System.Drawing.Size(100, 44);
            this.btn_descuentos_generos.TabIndex = 30;
            this.btn_descuentos_generos.Text = "Descuentos por Genero";
            this.btn_descuentos_generos.UseVisualStyleBackColor = true;
            this.btn_descuentos_generos.Click += new System.EventHandler(this.btn_descuentos_generos_Click);
            // 
            // btn_descuentos_autor
            // 
            this.btn_descuentos_autor.Location = new System.Drawing.Point(332, 76);
            this.btn_descuentos_autor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_descuentos_autor.Name = "btn_descuentos_autor";
            this.btn_descuentos_autor.Size = new System.Drawing.Size(100, 44);
            this.btn_descuentos_autor.TabIndex = 29;
            this.btn_descuentos_autor.Text = "Descuento por Autor";
            this.btn_descuentos_autor.UseVisualStyleBackColor = true;
            this.btn_descuentos_autor.Click += new System.EventHandler(this.btn_descuentos_autor_Click);
            // 
            // btn_seleccionar_descuento
            // 
            this.btn_seleccionar_descuento.Location = new System.Drawing.Point(332, 23);
            this.btn_seleccionar_descuento.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seleccionar_descuento.Name = "btn_seleccionar_descuento";
            this.btn_seleccionar_descuento.Size = new System.Drawing.Size(100, 44);
            this.btn_seleccionar_descuento.TabIndex = 28;
            this.btn_seleccionar_descuento.Text = "Seleccionar descuento";
            this.btn_seleccionar_descuento.UseVisualStyleBackColor = true;
            this.btn_seleccionar_descuento.Click += new System.EventHandler(this.btn_seleccionar_descuento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(865, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sugerencia por Autor";
            // 
            // lbl_autor_mas_vendido
            // 
            this.lbl_autor_mas_vendido.AutoSize = true;
            this.lbl_autor_mas_vendido.Location = new System.Drawing.Point(873, 267);
            this.lbl_autor_mas_vendido.Name = "lbl_autor_mas_vendido";
            this.lbl_autor_mas_vendido.Size = new System.Drawing.Size(46, 17);
            this.lbl_autor_mas_vendido.TabIndex = 30;
            this.lbl_autor_mas_vendido.Text = "label2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(865, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Sugerencia por Género";
            // 
            // lbl_genero_mas_vendido
            // 
            this.lbl_genero_mas_vendido.AutoSize = true;
            this.lbl_genero_mas_vendido.Location = new System.Drawing.Point(873, 357);
            this.lbl_genero_mas_vendido.Name = "lbl_genero_mas_vendido";
            this.lbl_genero_mas_vendido.Size = new System.Drawing.Size(46, 17);
            this.lbl_genero_mas_vendido.TabIndex = 32;
            this.lbl_genero_mas_vendido.Text = "label4";
            // 
            // btn_mostrar_factura
            // 
            this.btn_mostrar_factura.Location = new System.Drawing.Point(945, 440);
            this.btn_mostrar_factura.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mostrar_factura.Name = "btn_mostrar_factura";
            this.btn_mostrar_factura.Size = new System.Drawing.Size(100, 45);
            this.btn_mostrar_factura.TabIndex = 33;
            this.btn_mostrar_factura.Text = "Mostrar Factura";
            this.btn_mostrar_factura.UseVisualStyleBackColor = true;
            this.btn_mostrar_factura.Click += new System.EventHandler(this.btn_mostrar_factura_Click);
            // 
            // FormularioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 553);
            this.Controls.Add(this.btn_mostrar_factura);
            this.Controls.Add(this.lbl_genero_mas_vendido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_autor_mas_vendido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grp_descuentos);
            this.Controls.Add(this.btn_eliminar_articulo);
            this.Controls.Add(this.grp_venta);
            this.Controls.Add(this.lbl_nombre_usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_buscar_libro);
            this.Controls.Add(this.grp_libro_venta);
            this.Controls.Add(this.grp_grupo_cliente);
            this.Controls.Add(this.btn_buscar_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dni_clilente_venta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_libro_venta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_alta_venta);
            this.Controls.Add(this.grillaVenta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioVenta";
            this.Text = "FormularioVenta";
            this.Load += new System.EventHandler(this.FormularioVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_grupo_cliente.ResumeLayout(false);
            this.grp_grupo_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_libro_venta)).EndInit();
            this.grp_libro_venta.ResumeLayout(false);
            this.grp_libro_venta.PerformLayout();
            this.grp_venta.ResumeLayout(false);
            this.grp_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_descuentos)).EndInit();
            this.grp_descuentos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaVenta;
        private System.Windows.Forms.Button btn_alta_venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_libro_venta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ch_tarjeta_credito_forma_pago;
        private System.Windows.Forms.CheckBox ch_efectivo_forma_pago;
        private System.Windows.Forms.MaskedTextBox txt_dni_clilente_venta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar_cliente;
        private System.Windows.Forms.GroupBox grp_grupo_cliente;
        private System.Windows.Forms.Label lbl_nombre_cliente;
        private System.Windows.Forms.Label lbl_dni_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_cantidad_libro_venta;
        private System.Windows.Forms.GroupBox grp_libro_venta;
        private System.Windows.Forms.Label lbl_precio_libro;
        private System.Windows.Forms.Label lbl_titulo_libro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar_libro;
        private System.Windows.Forms.Button btn_cancelar_libro;
        private System.Windows.Forms.Button btn_buscar_libro;
        private System.Windows.Forms.Button btn_cancelar_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.GroupBox grp_venta;
        private System.Windows.Forms.Label lbl_total_venta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_eliminar_articulo;
        private System.Windows.Forms.DataGridView grv_descuentos;
        private System.Windows.Forms.GroupBox grp_descuentos;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.Label lbl_desc_descuento;
        private System.Windows.Forms.Button btn_seleccionar_descuento;
        private System.Windows.Forms.Button btn_eliminar_descuento;
        private System.Windows.Forms.Button btn_descuentos_autor;
        private System.Windows.Forms.Button btn_descuentos_generos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_autor_mas_vendido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_genero_mas_vendido;
        private System.Windows.Forms.Button btn_mostrar_factura;
        private System.Windows.Forms.TextBox txt_monto_tarjeta;
        private System.Windows.Forms.TextBox txt_monto_efectivo;
    }
}