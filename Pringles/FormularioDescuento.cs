using Pringles.BLL;
using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.EE;
using Pringles.DAL.Validators;
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
    public partial class FormularioDescuento : BaseForm
    {
        private readonly IRepository<Autor> _autorRepository;
        private readonly IRepository<Genero> _generoRepository;
        private readonly DetalleDescuentoBLL _detalleDescuentoBLL;

        public FormularioDescuento() : base()
        {
            RevisarRol();
            InitializeComponent();
            _detalleDescuentoBLL = new DetalleDescuentoBLL(new DetalleDescuentoRepository());
            _autorRepository = new Repository<Autor>();
            _generoRepository = new Repository<Genero>();
        }

        private void btn_agregar_descuento_Click(object sender, EventArgs e)
        {
            DetalleDescuento detalleDescuento = LeerDetalleDescuento();
            if (!detalleDescuento.ValidarDetalleDescuento())
            {
                MessageBox.Show(this, "Datos no validos, por favor validar.");
                return;
            }
            _detalleDescuentoBLL.AltaDetalleDescuento(detalleDescuento);
            LimpiarFormulario();
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            grv_descuentos.DataSource = null;
            grv_descuentos.DataSource = _detalleDescuentoBLL.ListarDetalleDescuentos().ToList();

            grv_descuentos.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

            grv_descuentos.Columns[nameof(DetalleDescuento.Descripcion)].Visible = true;
            grv_descuentos.Columns[nameof(DetalleDescuento.FechaVencimientoStr)].Visible = true;
            grv_descuentos.Columns[nameof(DetalleDescuento.Descuento)].Visible = true;

            grv_descuentos.Columns[nameof(DetalleDescuento.Descripcion)].HeaderText = "Descripcion";
            grv_descuentos.Columns[nameof(DetalleDescuento.FechaVencimientoStr)].HeaderText = "Fecha Vencimiento";
            grv_descuentos.Columns[nameof(DetalleDescuento.Descuento)].HeaderText = "Descuento";
        }

        private DetalleDescuento SeleccionarDescuento()
        {
            try
            {
                return grv_descuentos.SelectedRows[0].DataBoundItem as DetalleDescuento;
            }
            catch
            {
                return null;
            }
        }

        private void LimpiarFormulario() 
        {
            txt_descripcion_descuento.Text = string.Empty;
            nbu_descuento.Value = 1;
            chk_aplica_autor.Checked = false;
            chk_aplica_genero.Checked = false;
            dt_fecha_habil_descuento.Value = DateTime.Now.Date;
        }

        private DetalleDescuento LeerDetalleDescuento()
        {
            return new DetalleDescuento
            {
                Descripcion = txt_descripcion_descuento.Text,
                Aplica_Autor = chk_aplica_autor.Checked,
                Aplica_Genero = chk_aplica_genero.Checked,
                Autor_Fk = Convert.ToInt32(cmb_autor.SelectedValue),
                Genero_Fk = Convert.ToInt32(cmb_genero.SelectedValue),
                Fecha_Fin = dt_fecha_habil_descuento.Value,
                Descuento = nbu_descuento.Value
            };
        }

        private void btn_eliminar_descuento_Click(object sender, EventArgs e)
        {
            DetalleDescuento detalleDescuento = SeleccionarDescuento();
            
            if (detalleDescuento == null)
            {
                MessageBox.Show(this, "Debe seleccionar un descuento");
                return;
            }

            if (MessageBox.Show(this, "", "Desea desactivar este descuento?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            _detalleDescuentoBLL.BajaDetalleDescuento(detalleDescuento);
            RefrescarGrilla();
        }

        private void FormularioDescuento_Load(object sender, EventArgs e)
        {
            cmb_autor.DataSource = _autorRepository.GetAll().OrderBy(c => c.NombreCompleto).ToList();
            cmb_autor.DisplayMember = nameof(Autor.NombreCompleto);
            cmb_autor.ValueMember = nameof(Autor.Id);

            cmb_genero.DataSource = _generoRepository.GetAll().OrderBy(c => c.Nombre).ToList();
            cmb_genero.DisplayMember = nameof(Genero.Nombre);
            cmb_genero.ValueMember = nameof(Genero.Id);

            RefrescarGrilla();
        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.CAJERO, UserRoles.GERENTE_TECNOLOGIA, UserRoles.GERENTE_VENTAS };
        }
    }
}
