namespace Pringles
{
    partial class FormularioLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario_login = new System.Windows.Forms.TextBox();
            this.txt_contrasenia_login = new System.Windows.Forms.TextBox();
            this.btn_aceptar_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txt_usuario_login
            // 
            this.txt_usuario_login.Location = new System.Drawing.Point(277, 97);
            this.txt_usuario_login.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usuario_login.MaxLength = 20;
            this.txt_usuario_login.Name = "txt_usuario_login";
            this.txt_usuario_login.Size = new System.Drawing.Size(130, 20);
            this.txt_usuario_login.TabIndex = 2;
            this.txt_usuario_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usuario_login_KeyDown);
            // 
            // txt_contrasenia_login
            // 
            this.txt_contrasenia_login.Location = new System.Drawing.Point(277, 164);
            this.txt_contrasenia_login.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contrasenia_login.MaxLength = 128;
            this.txt_contrasenia_login.Name = "txt_contrasenia_login";
            this.txt_contrasenia_login.Size = new System.Drawing.Size(130, 20);
            this.txt_contrasenia_login.TabIndex = 3;
            this.txt_contrasenia_login.UseSystemPasswordChar = true;
            this.txt_contrasenia_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contrasenia_login_KeyDown);
            // 
            // btn_aceptar_login
            // 
            this.btn_aceptar_login.Location = new System.Drawing.Point(249, 269);
            this.btn_aceptar_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aceptar_login.Name = "btn_aceptar_login";
            this.btn_aceptar_login.Size = new System.Drawing.Size(56, 19);
            this.btn_aceptar_login.TabIndex = 4;
            this.btn_aceptar_login.Text = "Aceptar";
            this.btn_aceptar_login.UseVisualStyleBackColor = true;
            this.btn_aceptar_login.Click += new System.EventHandler(this.btn_aceptar_login_Click);
            // 
            // FormularioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_aceptar_login);
            this.Controls.Add(this.txt_contrasenia_login);
            this.Controls.Add(this.txt_usuario_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioLogin";
            this.Load += new System.EventHandler(this.FormularioLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario_login;
        private System.Windows.Forms.TextBox txt_contrasenia_login;
        private System.Windows.Forms.Button btn_aceptar_login;
    }
}