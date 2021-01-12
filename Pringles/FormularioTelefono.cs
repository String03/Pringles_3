using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.EE;
using Pringles.Utilities.Consts;
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
    public partial class FormularioTelefono : BaseForm
    {
        
        private IRepository<Telefono> telefonoRepository = new TelefonoRepository();
        private IRepository<TipoTelefono> tipoTelefonoRepository = new Repository<TipoTelefono>();

        public FormularioTelefono()
        {
            RevisarRol();
            InitializeComponent();
            
            RefrescarGrillaTelefono();
            RefrescarTipoTelefono();
        }

        private void RefrescarTipoTelefono()
        {
            cmb_tipo_telefono.DataSource = tipoTelefonoRepository.GetAll().ToList();
            cmb_tipo_telefono.DisplayMember = nameof(TipoTelefono.Descripcion);
            cmb_tipo_telefono.ValueMember = nameof(TipoTelefono.Id);
        }

        private void RefrescarGrillaTelefono()
        {
            grillaTelefono.DataSource = null;
            grillaTelefono.DataSource = telefonoRepository.GetAll().ToList();

            grillaTelefono.Columns[nameof(Telefono.Id)].Visible = false;
            grillaTelefono.Columns[nameof(Telefono.Tipo_telefono_fk)].Visible = false;
           

        }

        private Telefono LeerTelefono()
        {
            return new Telefono
            {
                
                Numero = txt_numero_telefono.Text.Trim(),
                Tipo_telefono_fk = Convert.ToInt32(cmb_tipo_telefono.SelectedValue)
            };
        }

        private void LimpiarCampos()
        {
            txt_numero_telefono.Text = string.Empty;
        }

        private void btn_alta_telefono_Click(object sender, EventArgs e)
        {
            var telefono = LeerTelefono();
            telefonoRepository.Save(telefono);
            LimpiarCampos();
            RefrescarGrillaTelefono();
        }


        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.CAJERO, UserRoles.GERENTE_TECNOLOGIA, UserRoles.GERENTE_VENTAS };
        }

        private void btn_modificacion_telefono_Click(object sender, EventArgs e)
        {
            var telefono = grillaTelefono.SelectedRows[0].DataBoundItem as Telefono;
            if (telefono == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono telefono a modificar");
                return;
            }
            telefono.Numero = txt_numero_telefono.Text.Trim();
            telefono.Tipo_telefono_fk = Convert.ToInt32(cmb_tipo_telefono.SelectedValue);

            telefonoRepository.Update(telefono);
            LimpiarCampos();
            RefrescarGrillaTelefono();
        }

        private void btn_baja_telefono_Click(object sender, EventArgs e)
        {
            var telefono = grillaTelefono.SelectedRows[0].DataBoundItem as Telefono;
            if (telefono == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono telefono a eliminar");
                return;
            }
            telefonoRepository.Delete(telefono);
            LimpiarCampos();
            RefrescarGrillaTelefono();

        }

        private void FormularioTelefono_Load(object sender, EventArgs e)
        {

        }
    }
}
