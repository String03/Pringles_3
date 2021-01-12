namespace Pringles
{
    partial class FormularioTelefono
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
            this.txt_numero_telefono = new System.Windows.Forms.TextBox();
            this.btn_modificacion_telefono = new System.Windows.Forms.Button();
            this.btn_baja_telefono = new System.Windows.Forms.Button();
            this.btn_alta_telefono = new System.Windows.Forms.Button();
            this.grillaTelefono = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_telefono = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número";
            // 
            // txt_numero_telefono
            // 
            this.txt_numero_telefono.Location = new System.Drawing.Point(202, 338);
            this.txt_numero_telefono.Name = "txt_numero_telefono";
            this.txt_numero_telefono.Size = new System.Drawing.Size(100, 22);
            this.txt_numero_telefono.TabIndex = 10;
            // 
            // btn_modificacion_telefono
            // 
            this.btn_modificacion_telefono.Location = new System.Drawing.Point(572, 272);
            this.btn_modificacion_telefono.Name = "btn_modificacion_telefono";
            this.btn_modificacion_telefono.Size = new System.Drawing.Size(103, 23);
            this.btn_modificacion_telefono.TabIndex = 9;
            this.btn_modificacion_telefono.Text = "Modificación";
            this.btn_modificacion_telefono.UseVisualStyleBackColor = true;
            this.btn_modificacion_telefono.Click += new System.EventHandler(this.btn_modificacion_telefono_Click);
            // 
            // btn_baja_telefono
            // 
            this.btn_baja_telefono.Location = new System.Drawing.Point(341, 272);
            this.btn_baja_telefono.Name = "btn_baja_telefono";
            this.btn_baja_telefono.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_telefono.TabIndex = 8;
            this.btn_baja_telefono.Text = "Baja";
            this.btn_baja_telefono.UseVisualStyleBackColor = true;
            this.btn_baja_telefono.Click += new System.EventHandler(this.btn_baja_telefono_Click);
            // 
            // btn_alta_telefono
            // 
            this.btn_alta_telefono.Location = new System.Drawing.Point(135, 272);
            this.btn_alta_telefono.Name = "btn_alta_telefono";
            this.btn_alta_telefono.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_telefono.TabIndex = 7;
            this.btn_alta_telefono.Text = "Alta";
            this.btn_alta_telefono.UseVisualStyleBackColor = true;
            this.btn_alta_telefono.Click += new System.EventHandler(this.btn_alta_telefono_Click);
            // 
            // grillaTelefono
            // 
            this.grillaTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTelefono.Location = new System.Drawing.Point(135, 90);
            this.grillaTelefono.MultiSelect = false;
            this.grillaTelefono.Name = "grillaTelefono";
            this.grillaTelefono.ReadOnly = true;
            this.grillaTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaTelefono.Size = new System.Drawing.Size(540, 150);
            this.grillaTelefono.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo Teléfono";
            // 
            // cmb_tipo_telefono
            // 
            this.cmb_tipo_telefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_telefono.FormattingEnabled = true;
            this.cmb_tipo_telefono.Location = new System.Drawing.Point(521, 341);
            this.cmb_tipo_telefono.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipo_telefono.Name = "cmb_tipo_telefono";
            this.cmb_tipo_telefono.Size = new System.Drawing.Size(142, 24);
            this.cmb_tipo_telefono.TabIndex = 15;
            // 
            // FormularioTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_tipo_telefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numero_telefono);
            this.Controls.Add(this.btn_modificacion_telefono);
            this.Controls.Add(this.btn_baja_telefono);
            this.Controls.Add(this.btn_alta_telefono);
            this.Controls.Add(this.grillaTelefono);
            this.Name = "FormularioTelefono";
            this.Text = "FormularioTelefono";
            this.Load += new System.EventHandler(this.FormularioTelefono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero_telefono;
        private System.Windows.Forms.Button btn_modificacion_telefono;
        private System.Windows.Forms.Button btn_baja_telefono;
        private System.Windows.Forms.Button btn_alta_telefono;
        private System.Windows.Forms.DataGridView grillaTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipo_telefono;
    }
}