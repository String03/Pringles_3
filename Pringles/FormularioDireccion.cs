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
    public partial class FormularioDireccion : BaseForm
    {
        private int _cliente_id;
        private IDireccionRepository direccionRepository = new DireccionRepository();

        public FormularioDireccion(int cliente_id)
        {
            InitializeComponent();
            _cliente_id = cliente_id;
            RefrescarGrillaDireccion();
        }

        private void RefrescarGrillaDireccion()
        {
            grillaDireccion.DataSource = null;
            grillaDireccion.DataSource = direccionRepository.BuscarDireccionCliente(_cliente_id).ToList();
        }

        private void btn_alta_direccion_Click(object sender, EventArgs e)
        {
            var direccion = LeerDireccion();
            direccionRepository.Save(direccion);
            LimpiarCampos();
            RefrescarGrillaDireccion();
        }

        private void LimpiarCampos()
        {
            txt_direccion.Text = string.Empty;
        }

        private Direccion LeerDireccion()
        {
            return new Direccion
            {
                Descripcion = txt_direccion.Text.Trim(),
                Cliente_fk = this._cliente_id
            };
        }

        private void FormularioDireccion_Load(object sender, EventArgs e)
        {

        }

        private void btn_baja_direccion_Click(object sender, EventArgs e)
        {
            var direccion = grillaDireccion.SelectedRows[0].DataBoundItem as Direccion;
            if (direccion == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono dirección a eliminar");
                return;
            }
            direccionRepository.Delete(direccion);
            LimpiarCampos();
            RefrescarGrillaDireccion();
        }

        private void btn_modificacion_direccion_Click(object sender, EventArgs e)
        {
            var direccion = grillaDireccion.SelectedRows[0].DataBoundItem as Direccion;
            if (direccion == null)
            {
                MessageBox.Show(this, "Error", "No se selecciono dirección a modificar");
                return;
            }
            direccion.Descripcion = txt_direccion.Text.Trim();
            
            direccionRepository.Update(direccion);
            LimpiarCampos();
            RefrescarGrillaDireccion();
        }
    }
}
