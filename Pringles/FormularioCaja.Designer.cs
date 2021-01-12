namespace Pringles
{
    partial class FormularioCaja
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
            this.btn_inicializar_caja = new System.Windows.Forms.Button();
            this.btn_cerrar_caja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_inicia_caja = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_inicializar_caja
            // 
            this.btn_inicializar_caja.Location = new System.Drawing.Point(313, 176);
            this.btn_inicializar_caja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inicializar_caja.Name = "btn_inicializar_caja";
            this.btn_inicializar_caja.Size = new System.Drawing.Size(129, 23);
            this.btn_inicializar_caja.TabIndex = 0;
            this.btn_inicializar_caja.Text = "Inicializar Caja";
            this.btn_inicializar_caja.UseVisualStyleBackColor = true;
            this.btn_inicializar_caja.Click += new System.EventHandler(this.btn_inicializar_caja_Click);
            // 
            // btn_cerrar_caja
            // 
            this.btn_cerrar_caja.Location = new System.Drawing.Point(313, 228);
            this.btn_cerrar_caja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar_caja.Name = "btn_cerrar_caja";
            this.btn_cerrar_caja.Size = new System.Drawing.Size(129, 23);
            this.btn_cerrar_caja.TabIndex = 1;
            this.btn_cerrar_caja.Text = "Cerrar Caja";
            this.btn_cerrar_caja.UseVisualStyleBackColor = true;
            this.btn_cerrar_caja.Click += new System.EventHandler(this.btn_cerrar_caja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicia en:";
            // 
            // txt_inicia_caja
            // 
            this.txt_inicia_caja.Location = new System.Drawing.Point(313, 133);
            this.txt_inicia_caja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_inicia_caja.Mask = "0000000";
            this.txt_inicia_caja.Name = "txt_inicia_caja";
            this.txt_inicia_caja.Size = new System.Drawing.Size(132, 22);
            this.txt_inicia_caja.TabIndex = 4;
            // 
            // FormularioCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 554);
            this.Controls.Add(this.txt_inicia_caja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar_caja);
            this.Controls.Add(this.btn_inicializar_caja);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioCaja";
            this.Text = "FormularioCaja";
            this.Load += new System.EventHandler(this.FormularioCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inicializar_caja;
        private System.Windows.Forms.Button btn_cerrar_caja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_inicia_caja;
    }
}