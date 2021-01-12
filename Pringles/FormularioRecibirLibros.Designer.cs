namespace Pringles
{
    partial class FormularioRecibirLibros
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
            this.grillaLibrosRecibidos = new System.Windows.Forms.DataGridView();
            this.btn_libros_recibidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLibrosRecibidos)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaLibrosRecibidos
            // 
            this.grillaLibrosRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLibrosRecibidos.Location = new System.Drawing.Point(141, 58);
            this.grillaLibrosRecibidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaLibrosRecibidos.MultiSelect = false;
            this.grillaLibrosRecibidos.Name = "grillaLibrosRecibidos";
            this.grillaLibrosRecibidos.ReadOnly = true;
            this.grillaLibrosRecibidos.RowTemplate.Height = 24;
            this.grillaLibrosRecibidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaLibrosRecibidos.Size = new System.Drawing.Size(461, 150);
            this.grillaLibrosRecibidos.TabIndex = 0;
            // 
            // btn_libros_recibidos
            // 
            this.btn_libros_recibidos.Location = new System.Drawing.Point(320, 266);
            this.btn_libros_recibidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_libros_recibidos.Name = "btn_libros_recibidos";
            this.btn_libros_recibidos.Size = new System.Drawing.Size(125, 23);
            this.btn_libros_recibidos.TabIndex = 1;
            this.btn_libros_recibidos.Text = "Libros Recibidos";
            this.btn_libros_recibidos.UseVisualStyleBackColor = true;
            this.btn_libros_recibidos.Click += new System.EventHandler(this.btn_libros_recibidos_Click);
            // 
            // FormularioRecibirLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_libros_recibidos);
            this.Controls.Add(this.grillaLibrosRecibidos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioRecibirLibros";
            this.Text = "FormularioRecibirLibros";
            this.Load += new System.EventHandler(this.FormularioRecibirLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaLibrosRecibidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaLibrosRecibidos;
        private System.Windows.Forms.Button btn_libros_recibidos;
    }
}