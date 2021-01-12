namespace Pringles
{
    partial class FormularioAutor
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
            this.btn_alta_autor = new System.Windows.Forms.Button();
            this.btn_baja_autor = new System.Windows.Forms.Button();
            this.btn_modificacion_autor = new System.Windows.Forms.Button();
            this.txt_nombre_autor = new System.Windows.Forms.TextBox();
            this.txt_apellido_autor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grillaAutor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta_autor
            // 
            this.btn_alta_autor.Location = new System.Drawing.Point(112, 261);
            this.btn_alta_autor.Name = "btn_alta_autor";
            this.btn_alta_autor.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_autor.TabIndex = 0;
            this.btn_alta_autor.Text = "Alta";
            this.btn_alta_autor.UseVisualStyleBackColor = true;
            this.btn_alta_autor.Click += new System.EventHandler(this.btn_alta_autor_Click);
            // 
            // btn_baja_autor
            // 
            this.btn_baja_autor.Location = new System.Drawing.Point(346, 261);
            this.btn_baja_autor.Name = "btn_baja_autor";
            this.btn_baja_autor.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_autor.TabIndex = 1;
            this.btn_baja_autor.Text = "Baja";
            this.btn_baja_autor.UseVisualStyleBackColor = true;
            this.btn_baja_autor.Click += new System.EventHandler(this.btn_baja_autor_Click);
            // 
            // btn_modificacion_autor
            // 
            this.btn_modificacion_autor.Location = new System.Drawing.Point(616, 261);
            this.btn_modificacion_autor.Name = "btn_modificacion_autor";
            this.btn_modificacion_autor.Size = new System.Drawing.Size(100, 23);
            this.btn_modificacion_autor.TabIndex = 2;
            this.btn_modificacion_autor.Text = "Modificación";
            this.btn_modificacion_autor.UseVisualStyleBackColor = true;
            this.btn_modificacion_autor.Click += new System.EventHandler(this.btn_modificacion_autor_Click);
            // 
            // txt_nombre_autor
            // 
            this.txt_nombre_autor.Location = new System.Drawing.Point(184, 353);
            this.txt_nombre_autor.MaxLength = 120;
            this.txt_nombre_autor.Name = "txt_nombre_autor";
            this.txt_nombre_autor.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre_autor.TabIndex = 3;
            // 
            // txt_apellido_autor
            // 
            this.txt_apellido_autor.Location = new System.Drawing.Point(616, 353);
            this.txt_apellido_autor.MaxLength = 120;
            this.txt_apellido_autor.Name = "txt_apellido_autor";
            this.txt_apellido_autor.Size = new System.Drawing.Size(100, 22);
            this.txt_apellido_autor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // grillaAutor
            // 
            this.grillaAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAutor.Location = new System.Drawing.Point(205, 57);
            this.grillaAutor.Name = "grillaAutor";
            this.grillaAutor.ReadOnly = true;
            this.grillaAutor.RowTemplate.Height = 24;
            this.grillaAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaAutor.Size = new System.Drawing.Size(409, 150);
            this.grillaAutor.TabIndex = 7;
            // 
            // FormularioAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grillaAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_apellido_autor);
            this.Controls.Add(this.txt_nombre_autor);
            this.Controls.Add(this.btn_modificacion_autor);
            this.Controls.Add(this.btn_baja_autor);
            this.Controls.Add(this.btn_alta_autor);
            this.Name = "FormularioAutor";
            this.Text = "FormAutor";
            this.Load += new System.EventHandler(this.FormularioAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alta_autor;
        private System.Windows.Forms.Button btn_baja_autor;
        private System.Windows.Forms.Button btn_modificacion_autor;
        private System.Windows.Forms.TextBox txt_nombre_autor;
        private System.Windows.Forms.TextBox txt_apellido_autor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grillaAutor;
    }
}