namespace Pringles
{
    partial class FormularioDescuento
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
            this.grv_descuentos = new System.Windows.Forms.DataGridView();
            this.btn_agregar_descuento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_fecha_habil_descuento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion_descuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_aplica_genero = new System.Windows.Forms.CheckBox();
            this.chk_aplica_autor = new System.Windows.Forms.CheckBox();
            this.nbu_descuento = new System.Windows.Forms.NumericUpDown();
            this.btn_eliminar_descuento = new System.Windows.Forms.Button();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.cmb_autor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_descuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbu_descuento)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_descuentos
            // 
            this.grv_descuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_descuentos.Location = new System.Drawing.Point(11, 11);
            this.grv_descuentos.Margin = new System.Windows.Forms.Padding(2);
            this.grv_descuentos.Name = "grv_descuentos";
            this.grv_descuentos.ReadOnly = true;
            this.grv_descuentos.RowTemplate.Height = 24;
            this.grv_descuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_descuentos.Size = new System.Drawing.Size(350, 122);
            this.grv_descuentos.TabIndex = 0;
            // 
            // btn_agregar_descuento
            // 
            this.btn_agregar_descuento.Location = new System.Drawing.Point(49, 137);
            this.btn_agregar_descuento.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar_descuento.Name = "btn_agregar_descuento";
            this.btn_agregar_descuento.Size = new System.Drawing.Size(56, 26);
            this.btn_agregar_descuento.TabIndex = 1;
            this.btn_agregar_descuento.Text = "Agregar";
            this.btn_agregar_descuento.UseVisualStyleBackColor = true;
            this.btn_agregar_descuento.Click += new System.EventHandler(this.btn_agregar_descuento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // dt_fecha_habil_descuento
            // 
            this.dt_fecha_habil_descuento.Location = new System.Drawing.Point(163, 305);
            this.dt_fecha_habil_descuento.Margin = new System.Windows.Forms.Padding(2);
            this.dt_fecha_habil_descuento.Name = "dt_fecha_habil_descuento";
            this.dt_fecha_habil_descuento.Size = new System.Drawing.Size(151, 20);
            this.dt_fecha_habil_descuento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha hábil";
            // 
            // txt_descripcion_descuento
            // 
            this.txt_descripcion_descuento.Location = new System.Drawing.Point(163, 201);
            this.txt_descripcion_descuento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion_descuento.MaxLength = 120;
            this.txt_descripcion_descuento.Name = "txt_descripcion_descuento";
            this.txt_descripcion_descuento.Size = new System.Drawing.Size(151, 20);
            this.txt_descripcion_descuento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Porcentaje";
            // 
            // chk_aplica_genero
            // 
            this.chk_aplica_genero.AutoSize = true;
            this.chk_aplica_genero.Location = new System.Drawing.Point(45, 254);
            this.chk_aplica_genero.Name = "chk_aplica_genero";
            this.chk_aplica_genero.Size = new System.Drawing.Size(93, 17);
            this.chk_aplica_genero.TabIndex = 10;
            this.chk_aplica_genero.Text = "Aplica Genero";
            this.chk_aplica_genero.UseVisualStyleBackColor = true;
            // 
            // chk_aplica_autor
            // 
            this.chk_aplica_autor.AutoSize = true;
            this.chk_aplica_autor.Location = new System.Drawing.Point(45, 281);
            this.chk_aplica_autor.Name = "chk_aplica_autor";
            this.chk_aplica_autor.Size = new System.Drawing.Size(83, 17);
            this.chk_aplica_autor.TabIndex = 11;
            this.chk_aplica_autor.Text = "Aplica Autor";
            this.chk_aplica_autor.UseVisualStyleBackColor = true;
            // 
            // nbu_descuento
            // 
            this.nbu_descuento.Location = new System.Drawing.Point(163, 226);
            this.nbu_descuento.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nbu_descuento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbu_descuento.Name = "nbu_descuento";
            this.nbu_descuento.Size = new System.Drawing.Size(50, 20);
            this.nbu_descuento.TabIndex = 12;
            this.nbu_descuento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_eliminar_descuento
            // 
            this.btn_eliminar_descuento.Location = new System.Drawing.Point(239, 140);
            this.btn_eliminar_descuento.Name = "btn_eliminar_descuento";
            this.btn_eliminar_descuento.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_descuento.TabIndex = 13;
            this.btn_eliminar_descuento.Text = "Desactivar";
            this.btn_eliminar_descuento.UseVisualStyleBackColor = true;
            this.btn_eliminar_descuento.Click += new System.EventHandler(this.btn_eliminar_descuento_Click);
            // 
            // cmb_genero
            // 
            this.cmb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Location = new System.Drawing.Point(163, 252);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(151, 21);
            this.cmb_genero.TabIndex = 14;
            // 
            // cmb_autor
            // 
            this.cmb_autor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_autor.FormattingEnabled = true;
            this.cmb_autor.Location = new System.Drawing.Point(163, 279);
            this.cmb_autor.Name = "cmb_autor";
            this.cmb_autor.Size = new System.Drawing.Size(151, 21);
            this.cmb_autor.TabIndex = 15;
            // 
            // FormularioDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 384);
            this.Controls.Add(this.cmb_autor);
            this.Controls.Add(this.cmb_genero);
            this.Controls.Add(this.btn_eliminar_descuento);
            this.Controls.Add(this.nbu_descuento);
            this.Controls.Add(this.chk_aplica_autor);
            this.Controls.Add(this.chk_aplica_genero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descripcion_descuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_fecha_habil_descuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_agregar_descuento);
            this.Controls.Add(this.grv_descuentos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(388, 423);
            this.MinimumSize = new System.Drawing.Size(388, 423);
            this.Name = "FormularioDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioDescuento";
            this.Load += new System.EventHandler(this.FormularioDescuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_descuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbu_descuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_descuentos;
        private System.Windows.Forms.Button btn_agregar_descuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_fecha_habil_descuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion_descuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_aplica_genero;
        private System.Windows.Forms.CheckBox chk_aplica_autor;
        private System.Windows.Forms.NumericUpDown nbu_descuento;
        private System.Windows.Forms.Button btn_eliminar_descuento;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.ComboBox cmb_autor;
    }
}