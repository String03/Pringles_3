namespace Pringles
{
    partial class FormularioCliente
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
            this.grillaCliente = new System.Windows.Forms.DataGridView();
            this.btn_alta_cliente = new System.Windows.Forms.Button();
            this.btn_baja_cliente = new System.Windows.Forms.Button();
            this.btn_modificacion_cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.txt_apellido_cliente = new System.Windows.Forms.TextBox();
            this.txt_celular_cliente = new System.Windows.Forms.TextBox();
            this.dt_fecha_nacimiento_cliente = new System.Windows.Forms.DateTimePicker();
            this.txt_dni_cliente = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cliente_mas_compras = new System.Windows.Forms.Button();
            this.btn_agregar_email = new System.Windows.Forms.Button();
            this.btn_agregar_direccion = new System.Windows.Forms.Button();
            this.btn_agregar_telefono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaCliente
            // 
            this.grillaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCliente.Location = new System.Drawing.Point(151, 48);
            this.grillaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaCliente.Name = "grillaCliente";
            this.grillaCliente.ReadOnly = true;
            this.grillaCliente.RowTemplate.Height = 24;
            this.grillaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaCliente.Size = new System.Drawing.Size(533, 150);
            this.grillaCliente.TabIndex = 0;
            this.grillaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaCliente_CellDoubleClick);
            // 
            // btn_alta_cliente
            // 
            this.btn_alta_cliente.Location = new System.Drawing.Point(121, 249);
            this.btn_alta_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alta_cliente.Name = "btn_alta_cliente";
            this.btn_alta_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_cliente.TabIndex = 1;
            this.btn_alta_cliente.Text = "Alta";
            this.btn_alta_cliente.UseVisualStyleBackColor = true;
            this.btn_alta_cliente.Click += new System.EventHandler(this.btn_alta_cliente_Click);
            // 
            // btn_baja_cliente
            // 
            this.btn_baja_cliente.Location = new System.Drawing.Point(363, 249);
            this.btn_baja_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_baja_cliente.Name = "btn_baja_cliente";
            this.btn_baja_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_cliente.TabIndex = 2;
            this.btn_baja_cliente.Text = "Baja";
            this.btn_baja_cliente.UseVisualStyleBackColor = true;
            this.btn_baja_cliente.Click += new System.EventHandler(this.btn_baja_cliente_Click);
            // 
            // btn_modificacion_cliente
            // 
            this.btn_modificacion_cliente.Location = new System.Drawing.Point(597, 249);
            this.btn_modificacion_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificacion_cliente.Name = "btn_modificacion_cliente";
            this.btn_modificacion_cliente.Size = new System.Drawing.Size(123, 23);
            this.btn_modificacion_cliente.TabIndex = 3;
            this.btn_modificacion_cliente.Text = "Modificación";
            this.btn_modificacion_cliente.UseVisualStyleBackColor = true;
            this.btn_modificacion_cliente.Click += new System.EventHandler(this.btn_modificacion_cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Location = new System.Drawing.Point(204, 356);
            this.txt_nombre_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre_cliente.MaxLength = 120;
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(180, 22);
            this.txt_nombre_cliente.TabIndex = 13;
            // 
            // txt_apellido_cliente
            // 
            this.txt_apellido_cliente.Location = new System.Drawing.Point(204, 395);
            this.txt_apellido_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido_cliente.MaxLength = 120;
            this.txt_apellido_cliente.Name = "txt_apellido_cliente";
            this.txt_apellido_cliente.Size = new System.Drawing.Size(180, 22);
            this.txt_apellido_cliente.TabIndex = 14;
            // 
            // txt_celular_cliente
            // 
            this.txt_celular_cliente.Location = new System.Drawing.Point(513, 310);
            this.txt_celular_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_celular_cliente.MaxLength = 20;
            this.txt_celular_cliente.Name = "txt_celular_cliente";
            this.txt_celular_cliente.Size = new System.Drawing.Size(224, 22);
            this.txt_celular_cliente.TabIndex = 19;
            // 
            // dt_fecha_nacimiento_cliente
            // 
            this.dt_fecha_nacimiento_cliente.Location = new System.Drawing.Point(284, 438);
            this.dt_fecha_nacimiento_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.dt_fecha_nacimiento_cliente.MaxDate = new System.DateTime(2099, 12, 28, 0, 0, 0, 0);
            this.dt_fecha_nacimiento_cliente.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_fecha_nacimiento_cliente.Name = "dt_fecha_nacimiento_cliente";
            this.dt_fecha_nacimiento_cliente.Size = new System.Drawing.Size(100, 22);
            this.dt_fecha_nacimiento_cliente.TabIndex = 20;
            // 
            // txt_dni_cliente
            // 
            this.txt_dni_cliente.Location = new System.Drawing.Point(204, 314);
            this.txt_dni_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dni_cliente.Mask = "00.000.000";
            this.txt_dni_cliente.Name = "txt_dni_cliente";
            this.txt_dni_cliente.Size = new System.Drawing.Size(180, 22);
            this.txt_dni_cliente.TabIndex = 21;
            this.txt_dni_cliente.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 91);
            this.button1.TabIndex = 22;
            this.button1.Text = "Historial del Cliente Seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cliente_mas_compras
            // 
            this.btn_cliente_mas_compras.Location = new System.Drawing.Point(295, 548);
            this.btn_cliente_mas_compras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cliente_mas_compras.Name = "btn_cliente_mas_compras";
            this.btn_cliente_mas_compras.Size = new System.Drawing.Size(212, 23);
            this.btn_cliente_mas_compras.TabIndex = 27;
            this.btn_cliente_mas_compras.Text = "Cliente con más Compras";
            this.btn_cliente_mas_compras.UseVisualStyleBackColor = true;
            this.btn_cliente_mas_compras.Click += new System.EventHandler(this.btn_cliente_mas_compras_Click);
            // 
            // btn_agregar_email
            // 
            this.btn_agregar_email.Location = new System.Drawing.Point(529, 349);
            this.btn_agregar_email.Name = "btn_agregar_email";
            this.btn_agregar_email.Size = new System.Drawing.Size(121, 37);
            this.btn_agregar_email.TabIndex = 28;
            this.btn_agregar_email.Text = "Agregar Email";
            this.btn_agregar_email.UseVisualStyleBackColor = true;
            this.btn_agregar_email.Click += new System.EventHandler(this.btn_agregar_email_Click);
            // 
            // btn_agregar_direccion
            // 
            this.btn_agregar_direccion.Location = new System.Drawing.Point(263, 486);
            this.btn_agregar_direccion.Name = "btn_agregar_direccion";
            this.btn_agregar_direccion.Size = new System.Drawing.Size(159, 37);
            this.btn_agregar_direccion.TabIndex = 29;
            this.btn_agregar_direccion.Text = "Agregar Dirección";
            this.btn_agregar_direccion.UseVisualStyleBackColor = true;
            this.btn_agregar_direccion.Click += new System.EventHandler(this.btn_agregar_direccion_Click);
            // 
            // btn_agregar_telefono
            // 
            this.btn_agregar_telefono.Location = new System.Drawing.Point(540, 438);
            this.btn_agregar_telefono.Name = "btn_agregar_telefono";
            this.btn_agregar_telefono.Size = new System.Drawing.Size(159, 37);
            this.btn_agregar_telefono.TabIndex = 30;
            this.btn_agregar_telefono.Text = "Agregar Teléfono";
            this.btn_agregar_telefono.UseVisualStyleBackColor = true;
            this.btn_agregar_telefono.Click += new System.EventHandler(this.btn_agregar_telefono_Click);
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 610);
            this.Controls.Add(this.btn_agregar_telefono);
            this.Controls.Add(this.btn_agregar_direccion);
            this.Controls.Add(this.btn_agregar_email);
            this.Controls.Add(this.btn_cliente_mas_compras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_dni_cliente);
            this.Controls.Add(this.dt_fecha_nacimiento_cliente);
            this.Controls.Add(this.txt_celular_cliente);
            this.Controls.Add(this.txt_apellido_cliente);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificacion_cliente);
            this.Controls.Add(this.btn_baja_cliente);
            this.Controls.Add(this.btn_alta_cliente);
            this.Controls.Add(this.grillaCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaCliente;
        private System.Windows.Forms.Button btn_alta_cliente;
        private System.Windows.Forms.Button btn_baja_cliente;
        private System.Windows.Forms.Button btn_modificacion_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.TextBox txt_apellido_cliente;
        private System.Windows.Forms.TextBox txt_celular_cliente;
        private System.Windows.Forms.DateTimePicker dt_fecha_nacimiento_cliente;
        private System.Windows.Forms.MaskedTextBox txt_dni_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cliente_mas_compras;
        private System.Windows.Forms.Button btn_agregar_email;
        private System.Windows.Forms.Button btn_agregar_direccion;
        private System.Windows.Forms.Button btn_agregar_telefono;
    }
}