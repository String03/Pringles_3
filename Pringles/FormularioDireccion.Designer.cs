namespace Pringles
{
    partial class FormularioDireccion
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
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.btn_modificacion_direccion = new System.Windows.Forms.Button();
            this.btn_baja_direccion = new System.Windows.Forms.Button();
            this.btn_alta_direccion = new System.Windows.Forms.Button();
            this.grillaDireccion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dirección";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(202, 338);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(345, 22);
            this.txt_direccion.TabIndex = 10;
            // 
            // btn_modificacion_direccion
            // 
            this.btn_modificacion_direccion.Location = new System.Drawing.Point(572, 272);
            this.btn_modificacion_direccion.Name = "btn_modificacion_direccion";
            this.btn_modificacion_direccion.Size = new System.Drawing.Size(103, 23);
            this.btn_modificacion_direccion.TabIndex = 9;
            this.btn_modificacion_direccion.Text = "Modificación";
            this.btn_modificacion_direccion.UseVisualStyleBackColor = true;
            this.btn_modificacion_direccion.Click += new System.EventHandler(this.btn_modificacion_direccion_Click);
            // 
            // btn_baja_direccion
            // 
            this.btn_baja_direccion.Location = new System.Drawing.Point(341, 272);
            this.btn_baja_direccion.Name = "btn_baja_direccion";
            this.btn_baja_direccion.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_direccion.TabIndex = 8;
            this.btn_baja_direccion.Text = "Baja";
            this.btn_baja_direccion.UseVisualStyleBackColor = true;
            this.btn_baja_direccion.Click += new System.EventHandler(this.btn_baja_direccion_Click);
            // 
            // btn_alta_direccion
            // 
            this.btn_alta_direccion.Location = new System.Drawing.Point(135, 272);
            this.btn_alta_direccion.Name = "btn_alta_direccion";
            this.btn_alta_direccion.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_direccion.TabIndex = 7;
            this.btn_alta_direccion.Text = "Alta";
            this.btn_alta_direccion.UseVisualStyleBackColor = true;
            this.btn_alta_direccion.Click += new System.EventHandler(this.btn_alta_direccion_Click);
            // 
            // grillaDireccion
            // 
            this.grillaDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDireccion.Location = new System.Drawing.Point(135, 90);
            this.grillaDireccion.MultiSelect = false;
            this.grillaDireccion.Name = "grillaDireccion";
            this.grillaDireccion.ReadOnly = true;
            this.grillaDireccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaDireccion.Size = new System.Drawing.Size(540, 150);
            this.grillaDireccion.TabIndex = 6;
            // 
            // FormularioDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.btn_modificacion_direccion);
            this.Controls.Add(this.btn_baja_direccion);
            this.Controls.Add(this.btn_alta_direccion);
            this.Controls.Add(this.grillaDireccion);
            this.Name = "FormularioDireccion";
            this.Text = "FormularioDireccion";
            this.Load += new System.EventHandler(this.FormularioDireccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Button btn_modificacion_direccion;
        private System.Windows.Forms.Button btn_baja_direccion;
        private System.Windows.Forms.Button btn_alta_direccion;
        private System.Windows.Forms.DataGridView grillaDireccion;
    }
}