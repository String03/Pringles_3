namespace Pringles
{
    partial class FormularioUsuario
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
            this.grillaUsuario = new System.Windows.Forms.DataGridView();
            this.btn_alta_usuario = new System.Windows.Forms.Button();
            this.btn_baja_usuario = new System.Windows.Forms.Button();
            this.btn_modificacion_usuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_codigo_empleado_usuario = new System.Windows.Forms.TextBox();
            this.txt_nombres_usuario = new System.Windows.Forms.TextBox();
            this.txt_apellido_usuario = new System.Windows.Forms.TextBox();
            this.txt_nombre_del_usuario_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasenia_usuario = new System.Windows.Forms.TextBox();
            this.cbo_rol_usuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaUsuario
            // 
            this.grillaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaUsuario.Location = new System.Drawing.Point(138, 49);
            this.grillaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.grillaUsuario.Name = "grillaUsuario";
            this.grillaUsuario.ReadOnly = true;
            this.grillaUsuario.RowTemplate.Height = 24;
            this.grillaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaUsuario.Size = new System.Drawing.Size(317, 122);
            this.grillaUsuario.TabIndex = 0;
            this.grillaUsuario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grillaUsuario_CellMouseDoubleClick);
            // 
            // btn_alta_usuario
            // 
            this.btn_alta_usuario.Location = new System.Drawing.Point(138, 204);
            this.btn_alta_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_alta_usuario.Name = "btn_alta_usuario";
            this.btn_alta_usuario.Size = new System.Drawing.Size(56, 25);
            this.btn_alta_usuario.TabIndex = 1;
            this.btn_alta_usuario.Text = "Alta";
            this.btn_alta_usuario.UseVisualStyleBackColor = true;
            this.btn_alta_usuario.Click += new System.EventHandler(this.btn_alta_usuario_Click);
            // 
            // btn_baja_usuario
            // 
            this.btn_baja_usuario.Location = new System.Drawing.Point(262, 204);
            this.btn_baja_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_baja_usuario.Name = "btn_baja_usuario";
            this.btn_baja_usuario.Size = new System.Drawing.Size(56, 25);
            this.btn_baja_usuario.TabIndex = 2;
            this.btn_baja_usuario.Text = "Baja";
            this.btn_baja_usuario.UseVisualStyleBackColor = true;
            this.btn_baja_usuario.Click += new System.EventHandler(this.btn_baja_usuario_Click);
            // 
            // btn_modificacion_usuario
            // 
            this.btn_modificacion_usuario.Location = new System.Drawing.Point(378, 204);
            this.btn_modificacion_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificacion_usuario.Name = "btn_modificacion_usuario";
            this.btn_modificacion_usuario.Size = new System.Drawing.Size(77, 25);
            this.btn_modificacion_usuario.TabIndex = 3;
            this.btn_modificacion_usuario.Text = "Modificación";
            this.btn_modificacion_usuario.UseVisualStyleBackColor = true;
            this.btn_modificacion_usuario.Click += new System.EventHandler(this.btn_modificacion_usuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre del Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 445);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rol";
            // 
            // txt_codigo_empleado_usuario
            // 
            this.txt_codigo_empleado_usuario.Location = new System.Drawing.Point(336, 260);
            this.txt_codigo_empleado_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo_empleado_usuario.MaxLength = 10;
            this.txt_codigo_empleado_usuario.Name = "txt_codigo_empleado_usuario";
            this.txt_codigo_empleado_usuario.Size = new System.Drawing.Size(116, 20);
            this.txt_codigo_empleado_usuario.TabIndex = 10;
            // 
            // txt_nombres_usuario
            // 
            this.txt_nombres_usuario.Location = new System.Drawing.Point(336, 295);
            this.txt_nombres_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombres_usuario.MaxLength = 120;
            this.txt_nombres_usuario.Name = "txt_nombres_usuario";
            this.txt_nombres_usuario.Size = new System.Drawing.Size(116, 20);
            this.txt_nombres_usuario.TabIndex = 11;
            // 
            // txt_apellido_usuario
            // 
            this.txt_apellido_usuario.Location = new System.Drawing.Point(336, 335);
            this.txt_apellido_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido_usuario.MaxLength = 120;
            this.txt_apellido_usuario.Name = "txt_apellido_usuario";
            this.txt_apellido_usuario.Size = new System.Drawing.Size(116, 20);
            this.txt_apellido_usuario.TabIndex = 12;
            // 
            // txt_nombre_del_usuario_usuario
            // 
            this.txt_nombre_del_usuario_usuario.Location = new System.Drawing.Point(336, 370);
            this.txt_nombre_del_usuario_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_del_usuario_usuario.MaxLength = 20;
            this.txt_nombre_del_usuario_usuario.Name = "txt_nombre_del_usuario_usuario";
            this.txt_nombre_del_usuario_usuario.Size = new System.Drawing.Size(116, 20);
            this.txt_nombre_del_usuario_usuario.TabIndex = 13;
            // 
            // txt_contrasenia_usuario
            // 
            this.txt_contrasenia_usuario.Location = new System.Drawing.Point(336, 409);
            this.txt_contrasenia_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contrasenia_usuario.MaxLength = 256;
            this.txt_contrasenia_usuario.Name = "txt_contrasenia_usuario";
            this.txt_contrasenia_usuario.Size = new System.Drawing.Size(116, 20);
            this.txt_contrasenia_usuario.TabIndex = 14;
            // 
            // cbo_rol_usuario
            // 
            this.cbo_rol_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rol_usuario.FormattingEnabled = true;
            this.cbo_rol_usuario.Location = new System.Drawing.Point(336, 443);
            this.cbo_rol_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_rol_usuario.Name = "cbo_rol_usuario";
            this.cbo_rol_usuario.Size = new System.Drawing.Size(116, 21);
            this.cbo_rol_usuario.TabIndex = 17;
            // 
            // FormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 499);
            this.Controls.Add(this.cbo_rol_usuario);
            this.Controls.Add(this.txt_contrasenia_usuario);
            this.Controls.Add(this.txt_nombre_del_usuario_usuario);
            this.Controls.Add(this.txt_apellido_usuario);
            this.Controls.Add(this.txt_nombres_usuario);
            this.Controls.Add(this.txt_codigo_empleado_usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificacion_usuario);
            this.Controls.Add(this.btn_baja_usuario);
            this.Controls.Add(this.btn_alta_usuario);
            this.Controls.Add(this.grillaUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioUsuario";
            this.Text = "FormularioUsuario";
            this.Load += new System.EventHandler(this.FormularioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaUsuario;
        private System.Windows.Forms.Button btn_alta_usuario;
        private System.Windows.Forms.Button btn_baja_usuario;
        private System.Windows.Forms.Button btn_modificacion_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_codigo_empleado_usuario;
        private System.Windows.Forms.TextBox txt_nombres_usuario;
        private System.Windows.Forms.TextBox txt_apellido_usuario;
        private System.Windows.Forms.TextBox txt_nombre_del_usuario_usuario;
        private System.Windows.Forms.TextBox txt_contrasenia_usuario;
        private System.Windows.Forms.ComboBox cbo_rol_usuario;
    }
}