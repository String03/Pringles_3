namespace Pringles
{
    partial class FormularioDisponibilidadZonaCliente
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
            this.grillaZona = new System.Windows.Forms.DataGridView();
            this.btn_agregar_zona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_zona_disponibilidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaZona)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaZona
            // 
            this.grillaZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaZona.Location = new System.Drawing.Point(177, 59);
            this.grillaZona.Name = "grillaZona";
            this.grillaZona.Size = new System.Drawing.Size(423, 150);
            this.grillaZona.TabIndex = 0;
            // 
            // btn_agregar_zona
            // 
            this.btn_agregar_zona.Location = new System.Drawing.Point(339, 261);
            this.btn_agregar_zona.Name = "btn_agregar_zona";
            this.btn_agregar_zona.Size = new System.Drawing.Size(75, 31);
            this.btn_agregar_zona.TabIndex = 1;
            this.btn_agregar_zona.Text = "Agregar";
            this.btn_agregar_zona.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zona";
            // 
            // txt_zona_disponibilidad
            // 
            this.txt_zona_disponibilidad.Location = new System.Drawing.Point(314, 341);
            this.txt_zona_disponibilidad.Name = "txt_zona_disponibilidad";
            this.txt_zona_disponibilidad.Size = new System.Drawing.Size(266, 22);
            this.txt_zona_disponibilidad.TabIndex = 3;
            // 
            // FormularioDisponibilidadZonaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_zona_disponibilidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar_zona);
            this.Controls.Add(this.grillaZona);
            this.Name = "FormularioDisponibilidadZonaCliente";
            this.Text = "FormularioDisponibilidadZonaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.grillaZona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaZona;
        private System.Windows.Forms.Button btn_agregar_zona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_zona_disponibilidad;
    }
}