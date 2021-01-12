namespace Pringles
{
    partial class FormularioTipoTelefono
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tipo_telefono = new System.Windows.Forms.TextBox();
            this.btn_modificacion_tipo_telefono = new System.Windows.Forms.Button();
            this.btn_baja_tipo_telefono = new System.Windows.Forms.Button();
            this.btn_alta_tipo_telefono = new System.Windows.Forms.Button();
            this.grillaTipoTelefono = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de teléfono";
            // 
            // txt_tipo_telefono
            // 
            this.txt_tipo_telefono.Location = new System.Drawing.Point(261, 335);
            this.txt_tipo_telefono.Name = "txt_tipo_telefono";
            this.txt_tipo_telefono.Size = new System.Drawing.Size(100, 22);
            this.txt_tipo_telefono.TabIndex = 10;
            // 
            // btn_modificacion_tipo_telefono
            // 
            this.btn_modificacion_tipo_telefono.Location = new System.Drawing.Point(572, 272);
            this.btn_modificacion_tipo_telefono.Name = "btn_modificacion_tipo_telefono";
            this.btn_modificacion_tipo_telefono.Size = new System.Drawing.Size(103, 23);
            this.btn_modificacion_tipo_telefono.TabIndex = 9;
            this.btn_modificacion_tipo_telefono.Text = "Modificación";
            this.btn_modificacion_tipo_telefono.UseVisualStyleBackColor = true;
            this.btn_modificacion_tipo_telefono.Click += new System.EventHandler(this.btn_modificacion_tipo_telefono_Click);
            // 
            // btn_baja_tipo_telefono
            // 
            this.btn_baja_tipo_telefono.Location = new System.Drawing.Point(341, 272);
            this.btn_baja_tipo_telefono.Name = "btn_baja_tipo_telefono";
            this.btn_baja_tipo_telefono.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_tipo_telefono.TabIndex = 8;
            this.btn_baja_tipo_telefono.Text = "Baja";
            this.btn_baja_tipo_telefono.UseVisualStyleBackColor = true;
            this.btn_baja_tipo_telefono.Click += new System.EventHandler(this.btn_baja_tipo_telefono_Click);
            // 
            // btn_alta_tipo_telefono
            // 
            this.btn_alta_tipo_telefono.Location = new System.Drawing.Point(135, 272);
            this.btn_alta_tipo_telefono.Name = "btn_alta_tipo_telefono";
            this.btn_alta_tipo_telefono.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_tipo_telefono.TabIndex = 7;
            this.btn_alta_tipo_telefono.Text = "Alta";
            this.btn_alta_tipo_telefono.UseVisualStyleBackColor = true;
            this.btn_alta_tipo_telefono.Click += new System.EventHandler(this.btn_alta_tipo_telefono_Click);
            // 
            // grillaTipoTelefono
            // 
            this.grillaTipoTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTipoTelefono.Location = new System.Drawing.Point(135, 90);
            this.grillaTipoTelefono.MultiSelect = false;
            this.grillaTipoTelefono.Name = "grillaTipoTelefono";
            this.grillaTipoTelefono.ReadOnly = true;
            this.grillaTipoTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaTipoTelefono.Size = new System.Drawing.Size(540, 150);
            this.grillaTipoTelefono.TabIndex = 6;
            // 
            // FormularioTipoTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tipo_telefono);
            this.Controls.Add(this.btn_modificacion_tipo_telefono);
            this.Controls.Add(this.btn_baja_tipo_telefono);
            this.Controls.Add(this.btn_alta_tipo_telefono);
            this.Controls.Add(this.grillaTipoTelefono);
            this.Name = "FormularioTipoTelefono";
            this.Text = "FormularioTipoTelefono";
            this.Load += new System.EventHandler(this.FormularioTipoTelefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTipoTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tipo_telefono;
        private System.Windows.Forms.Button btn_modificacion_tipo_telefono;
        private System.Windows.Forms.Button btn_baja_tipo_telefono;
        private System.Windows.Forms.Button btn_alta_tipo_telefono;
        private System.Windows.Forms.DataGridView grillaTipoTelefono;
    }
}