namespace Pringles
{
    partial class FormularioAgregarTelefono
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
            this.btn_buscar_telefono = new System.Windows.Forms.Button();
            this.txt_buscar_telefono = new System.Windows.Forms.TextBox();
            this.grillaTelefono = new System.Windows.Forms.DataGridView();
            this.grillaTelefonoCliente = new System.Windows.Forms.DataGridView();
            this.btn_relacionar_cliente_con_telefono = new System.Windows.Forms.Button();
            this.btn_quitar_relacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTelefonoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar_telefono
            // 
            this.btn_buscar_telefono.Location = new System.Drawing.Point(369, 279);
            this.btn_buscar_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar_telefono.Name = "btn_buscar_telefono";
            this.btn_buscar_telefono.Size = new System.Drawing.Size(157, 23);
            this.btn_buscar_telefono.TabIndex = 36;
            this.btn_buscar_telefono.Text = "Buscar Teléfono";
            this.btn_buscar_telefono.UseVisualStyleBackColor = true;
            this.btn_buscar_telefono.Click += new System.EventHandler(this.btn_buscar_telefono_Click);
            // 
            // txt_buscar_telefono
            // 
            this.txt_buscar_telefono.Location = new System.Drawing.Point(108, 280);
            this.txt_buscar_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_buscar_telefono.MaxLength = 20;
            this.txt_buscar_telefono.Name = "txt_buscar_telefono";
            this.txt_buscar_telefono.Size = new System.Drawing.Size(224, 22);
            this.txt_buscar_telefono.TabIndex = 35;
            // 
            // grillaTelefono
            // 
            this.grillaTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTelefono.Location = new System.Drawing.Point(77, 72);
            this.grillaTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaTelefono.Name = "grillaTelefono";
            this.grillaTelefono.ReadOnly = true;
            this.grillaTelefono.RowTemplate.Height = 24;
            this.grillaTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaTelefono.Size = new System.Drawing.Size(533, 150);
            this.grillaTelefono.TabIndex = 34;
            // 
            // grillaTelefonoCliente
            // 
            this.grillaTelefonoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTelefonoCliente.Location = new System.Drawing.Point(77, 364);
            this.grillaTelefonoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaTelefonoCliente.Name = "grillaTelefonoCliente";
            this.grillaTelefonoCliente.ReadOnly = true;
            this.grillaTelefonoCliente.RowTemplate.Height = 24;
            this.grillaTelefonoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaTelefonoCliente.Size = new System.Drawing.Size(533, 150);
            this.grillaTelefonoCliente.TabIndex = 37;
            // 
            // btn_relacionar_cliente_con_telefono
            // 
            this.btn_relacionar_cliente_con_telefono.Location = new System.Drawing.Point(616, 139);
            this.btn_relacionar_cliente_con_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_relacionar_cliente_con_telefono.Name = "btn_relacionar_cliente_con_telefono";
            this.btn_relacionar_cliente_con_telefono.Size = new System.Drawing.Size(157, 66);
            this.btn_relacionar_cliente_con_telefono.TabIndex = 38;
            this.btn_relacionar_cliente_con_telefono.Text = "Relacionar Cliente con Teléfono";
            this.btn_relacionar_cliente_con_telefono.UseVisualStyleBackColor = true;
            this.btn_relacionar_cliente_con_telefono.Click += new System.EventHandler(this.btn_relacionar_cliente_con_telefono_Click);
            // 
            // btn_quitar_relacion
            // 
            this.btn_quitar_relacion.Location = new System.Drawing.Point(645, 330);
            this.btn_quitar_relacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quitar_relacion.Name = "btn_quitar_relacion";
            this.btn_quitar_relacion.Size = new System.Drawing.Size(113, 50);
            this.btn_quitar_relacion.TabIndex = 39;
            this.btn_quitar_relacion.Text = "Quitar relación";
            this.btn_quitar_relacion.UseVisualStyleBackColor = true;
            this.btn_quitar_relacion.Click += new System.EventHandler(this.btn_quitar_relacion_Click);
            // 
            // FormularioAgregarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.btn_quitar_relacion);
            this.Controls.Add(this.btn_relacionar_cliente_con_telefono);
            this.Controls.Add(this.grillaTelefonoCliente);
            this.Controls.Add(this.btn_buscar_telefono);
            this.Controls.Add(this.txt_buscar_telefono);
            this.Controls.Add(this.grillaTelefono);
            this.Name = "FormularioAgregarTelefono";
            this.Text = "FormularioAgregarTelefono";
            this.Load += new System.EventHandler(this.FormularioAgregarTelefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTelefonoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar_telefono;
        private System.Windows.Forms.TextBox txt_buscar_telefono;
        private System.Windows.Forms.DataGridView grillaTelefono;
        private System.Windows.Forms.DataGridView grillaTelefonoCliente;
        private System.Windows.Forms.Button btn_relacionar_cliente_con_telefono;
        private System.Windows.Forms.Button btn_quitar_relacion;
    }
}