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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioTipoTelefono : BaseForm
    {
        private IRepository<TipoTelefono> tipoTelefonoRepository = new Repository<TipoTelefono>();
        public FormularioTipoTelefono()
        {
            InitializeComponent();
            RefrescarGrillaTipoTelefono();
        }

        private void RefrescarGrillaTipoTelefono()
        {
            grillaTipoTelefono.DataSource = null;
            grillaTipoTelefono.DataSource = tipoTelefonoRepository.GetAll().ToList();
        }


        private TipoTelefono LeerTipoTelefono()
        {
            return new TipoTelefono
            {
                Descripcion = txt_tipo_telefono.Text.Trim()
            };
        }

        private void btn_alta_tipo_telefono_Click(object sender, EventArgs e)
        {
            var tipoTelefono = LeerTipoTelefono();
            tipoTelefonoRepository.Save(tipoTelefono);
            LimpiarCampos();
            RefrescarGrillaTipoTelefono();
        }

        private void LimpiarCampos()
        {
            txt_tipo_telefono.Text = string.Empty;
        }

        private void FormularioTipoTelefono_Load(object sender, EventArgs e)
        {

        }

        private void btn_baja_tipo_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoTelefono = grillaTipoTelefono.SelectedRows[0].DataBoundItem as TipoTelefono;
                if (tipoTelefono == null)
                {
                    MessageBox.Show(this, "Error", "No se selecciono tipo telefono a eliminar");
                    return;
                }
                tipoTelefonoRepository.Delete(tipoTelefono);
                LimpiarCampos();
                RefrescarGrillaTipoTelefono();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_modificacion_tipo_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoTelefono = grillaTipoTelefono.SelectedRows[0].DataBoundItem as TipoTelefono;
                if (tipoTelefono == null)
                {
                    MessageBox.Show(this, "Error", "No se selecciono tipo telefono a modificar");
                    return;
                }
                tipoTelefono.Descripcion = txt_tipo_telefono.Text.Trim();

                tipoTelefonoRepository.Update(tipoTelefono);
                LimpiarCampos();
                RefrescarGrillaTipoTelefono();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
