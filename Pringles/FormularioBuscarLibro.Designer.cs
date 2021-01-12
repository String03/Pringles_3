namespace Pringles
{
    partial class FormularioBuscarLibro
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
            this.grillaBuscarLibro = new System.Windows.Forms.DataGridView();
            this.btn_buscar_libro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_autor_buscar_libro = new System.Windows.Forms.TextBox();
            this.txt_genero_buscar_libro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBuscarLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaBuscarLibro
            // 
            this.grillaBuscarLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBuscarLibro.Location = new System.Drawing.Point(145, 44);
            this.grillaBuscarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaBuscarLibro.MultiSelect = false;
            this.grillaBuscarLibro.Name = "grillaBuscarLibro";
            this.grillaBuscarLibro.ReadOnly = true;
            this.grillaBuscarLibro.RowTemplate.Height = 24;
            this.grillaBuscarLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaBuscarLibro.Size = new System.Drawing.Size(481, 150);
            this.grillaBuscarLibro.TabIndex = 0;
            this.grillaBuscarLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBuscarLibro_CellDoubleClick);
            // 
            // btn_buscar_libro
            // 
            this.btn_buscar_libro.Location = new System.Drawing.Point(341, 228);
            this.btn_buscar_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar_libro.Name = "btn_buscar_libro";
            this.btn_buscar_libro.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_libro.TabIndex = 1;
            this.btn_buscar_libro.Text = "Buscar";
            this.btn_buscar_libro.UseVisualStyleBackColor = true;
            this.btn_buscar_libro.Click += new System.EventHandler(this.btn_buscar_libro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Género";
            // 
            // txt_autor_buscar_libro
            // 
            this.txt_autor_buscar_libro.Location = new System.Drawing.Point(445, 305);
            this.txt_autor_buscar_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_autor_buscar_libro.Name = "txt_autor_buscar_libro";
            this.txt_autor_buscar_libro.Size = new System.Drawing.Size(196, 22);
            this.txt_autor_buscar_libro.TabIndex = 4;
            this.txt_autor_buscar_libro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_autor_buscar_libro_KeyDown);
            // 
            // txt_genero_buscar_libro
            // 
            this.txt_genero_buscar_libro.Location = new System.Drawing.Point(445, 348);
            this.txt_genero_buscar_libro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_genero_buscar_libro.Name = "txt_genero_buscar_libro";
            this.txt_genero_buscar_libro.Size = new System.Drawing.Size(196, 22);
            this.txt_genero_buscar_libro.TabIndex = 5;
            this.txt_genero_buscar_libro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_genero_buscar_libro_KeyDown);
            // 
            // FormularioBuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_genero_buscar_libro);
            this.Controls.Add(this.txt_autor_buscar_libro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar_libro);
            this.Controls.Add(this.grillaBuscarLibro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioBuscarLibro";
            this.Text = "FormularioBuscarLibro";
            this.Load += new System.EventHandler(this.FormularioBuscarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaBuscarLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaBuscarLibro;
        private System.Windows.Forms.Button btn_buscar_libro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_autor_buscar_libro;
        private System.Windows.Forms.TextBox txt_genero_buscar_libro;
    }
}