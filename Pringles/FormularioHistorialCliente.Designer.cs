namespace Pringles
{
    partial class FormularioHistorialCliente
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
            this.grillaHistorialCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_autor_mas_vendido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_genero_mas_vendido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaHistorialCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaHistorialCliente
            // 
            this.grillaHistorialCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaHistorialCliente.Location = new System.Drawing.Point(122, 10);
            this.grillaHistorialCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaHistorialCliente.MultiSelect = false;
            this.grillaHistorialCliente.Name = "grillaHistorialCliente";
            this.grillaHistorialCliente.ReadOnly = true;
            this.grillaHistorialCliente.RowTemplate.Height = 24;
            this.grillaHistorialCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaHistorialCliente.Size = new System.Drawing.Size(378, 122);
            this.grillaHistorialCliente.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sugerencia por Autor";
            // 
            // lbl_autor_mas_vendido
            // 
            this.lbl_autor_mas_vendido.AutoSize = true;
            this.lbl_autor_mas_vendido.Location = new System.Drawing.Point(196, 154);
            this.lbl_autor_mas_vendido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_autor_mas_vendido.Name = "lbl_autor_mas_vendido";
            this.lbl_autor_mas_vendido.Size = new System.Drawing.Size(35, 13);
            this.lbl_autor_mas_vendido.TabIndex = 28;
            this.lbl_autor_mas_vendido.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sugerencia por Género";
            // 
            // lbl_genero_mas_vendido
            // 
            this.lbl_genero_mas_vendido.AutoSize = true;
            this.lbl_genero_mas_vendido.Location = new System.Drawing.Point(488, 154);
            this.lbl_genero_mas_vendido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_genero_mas_vendido.Name = "lbl_genero_mas_vendido";
            this.lbl_genero_mas_vendido.Size = new System.Drawing.Size(35, 13);
            this.lbl_genero_mas_vendido.TabIndex = 30;
            this.lbl_genero_mas_vendido.Text = "label4";
            // 
            // FormularioHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 272);
            this.Controls.Add(this.lbl_genero_mas_vendido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_autor_mas_vendido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaHistorialCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormularioHistorialCliente";
            this.Text = "FormularioHistorialCliente";
            this.Load += new System.EventHandler(this.FormularioHistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaHistorialCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaHistorialCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_autor_mas_vendido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_genero_mas_vendido;
    }
}