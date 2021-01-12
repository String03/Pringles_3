namespace Pringles
{
    partial class FormularioEmail
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
            this.grillaEmail = new System.Windows.Forms.DataGridView();
            this.btn_alta_email = new System.Windows.Forms.Button();
            this.btn_baja_email = new System.Windows.Forms.Button();
            this.btn_modificacion_email = new System.Windows.Forms.Button();
            this.txt_e_mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaEmail
            // 
            this.grillaEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEmail.Location = new System.Drawing.Point(156, 75);
            this.grillaEmail.MultiSelect = false;
            this.grillaEmail.Name = "grillaEmail";
            this.grillaEmail.ReadOnly = true;
            this.grillaEmail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaEmail.Size = new System.Drawing.Size(540, 150);
            this.grillaEmail.TabIndex = 0;
            // 
            // btn_alta_email
            // 
            this.btn_alta_email.Location = new System.Drawing.Point(156, 257);
            this.btn_alta_email.Name = "btn_alta_email";
            this.btn_alta_email.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_email.TabIndex = 1;
            this.btn_alta_email.Text = "Alta";
            this.btn_alta_email.UseVisualStyleBackColor = true;
            this.btn_alta_email.Click += new System.EventHandler(this.btn_alta_email_Click);
            // 
            // btn_baja_email
            // 
            this.btn_baja_email.Location = new System.Drawing.Point(362, 257);
            this.btn_baja_email.Name = "btn_baja_email";
            this.btn_baja_email.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_email.TabIndex = 2;
            this.btn_baja_email.Text = "Baja";
            this.btn_baja_email.UseVisualStyleBackColor = true;
            this.btn_baja_email.Click += new System.EventHandler(this.btn_baja_email_Click);
            // 
            // btn_modificacion_email
            // 
            this.btn_modificacion_email.Location = new System.Drawing.Point(593, 257);
            this.btn_modificacion_email.Name = "btn_modificacion_email";
            this.btn_modificacion_email.Size = new System.Drawing.Size(103, 23);
            this.btn_modificacion_email.TabIndex = 3;
            this.btn_modificacion_email.Text = "Modificación";
            this.btn_modificacion_email.UseVisualStyleBackColor = true;
            this.btn_modificacion_email.Click += new System.EventHandler(this.btn_modificacion_email_Click);
            // 
            // txt_e_mail
            // 
            this.txt_e_mail.Location = new System.Drawing.Point(223, 323);
            this.txt_e_mail.Name = "txt_e_mail";
            this.txt_e_mail.Size = new System.Drawing.Size(100, 22);
            this.txt_e_mail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // FormularioEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_e_mail);
            this.Controls.Add(this.btn_modificacion_email);
            this.Controls.Add(this.btn_baja_email);
            this.Controls.Add(this.btn_alta_email);
            this.Controls.Add(this.grillaEmail);
            this.Name = "FormularioEmail";
            this.Text = "FormularioEmail";
            this.Load += new System.EventHandler(this.FormularioEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaEmail;
        private System.Windows.Forms.Button btn_alta_email;
        private System.Windows.Forms.Button btn_baja_email;
        private System.Windows.Forms.Button btn_modificacion_email;
        private System.Windows.Forms.TextBox txt_e_mail;
        private System.Windows.Forms.Label label1;
    }
}