using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioEmail : BaseForm
    {
        private int _cliente_id;
        private IEmailRepository emailRepository = new EmailRepository();

        public FormularioEmail(int cliente_id)
        {
            InitializeComponent();
            _cliente_id = cliente_id;
            RefrescarGrillaEmail();

        }

        private void RefrescarGrillaEmail()
        {
            grillaEmail.DataSource = null;
            grillaEmail.DataSource = emailRepository.BuscarEmailCliente(_cliente_id).ToList();
        }

        private bool ValidarEmail(string email)
        {
            string regex = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])";
            return Regex.IsMatch(email, regex);

        }

        private void btn_alta_email_Click(object sender, EventArgs e)
        {
            if (!ValidarEmail(txt_e_mail.Text.Trim()))
            {
                MessageBox.Show("No se respeta el formato de e-mail");
                return;
            }
            var email = LeerEmail();
            emailRepository.Save(email);
            LimpiarCampos();
            RefrescarGrillaEmail();

        }

        private void LimpiarCampos()
        {
            txt_e_mail.Text = string.Empty;
        }

        private Email LeerEmail()
        {
            return new Email
            {
                Descripcion = txt_e_mail.Text.Trim(),
                Cliente_fk = this._cliente_id
            };
        }

        private void btn_baja_email_Click(object sender, EventArgs e)
        {
            var email = grillaEmail.SelectedRows[0].DataBoundItem as Email;
            if (email == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono email a eliminar");
                return;
            }
            emailRepository.Delete(email);
            LimpiarCampos();
            RefrescarGrillaEmail();
        }

        private void btn_modificacion_email_Click(object sender, EventArgs e)
        {
            var email = grillaEmail.SelectedRows[0].DataBoundItem as Email;
            if (email == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono email a modificar");
                return;
            }
            email.Descripcion = txt_e_mail.Text.Trim();
            emailRepository.Update(email);
            LimpiarCampos();
            RefrescarGrillaEmail();
        }

        private void FormularioEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
