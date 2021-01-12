using Pringles.BLL;
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
    public partial class FormularioProveedor : BaseForm
    {
        private readonly ProveedorBLL proveedorBLL;
        private readonly LibroBLL libroBLL;

        public event EventHandler DatosProveedorActualizado;

        public FormularioProveedor()
        {
            RevisarRol();
            InitializeComponent();
            proveedorBLL = new ProveedorBLL(new ProveedorRepository());
            libroBLL = new LibroBLL(new LibroRepository());
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            grillaProveedores.DataSource = null;
            grillaProveedores.DataSource = proveedorBLL.ListarProveedores().ToList();

          

            var sacarLibro = grillaProveedores.Columns[nameof(Proveedor.Libros)];
            sacarLibro.Visible = false;
           

        }

        private void AplicarAccion(Proveedor proveedor, Action<Proveedor> action)
        {
            if (!proveedor.ValidarProveedor())
            {
                MessageBox.Show(this, "Datos no válidos");
                return;
            }
            try
            {
                action.Invoke(proveedor);
                RefrescarGrilla();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error agregando datos a la base de datos");
            }
        }

        private Proveedor LeerProveedor()
        {
            return new Proveedor
            {
                Cuil = txt_cuil_proveedor.Text.Trim(),
                Razon_Social = txt_razon_social_proveedor.Text.Trim()
            };
        }

        private Proveedor SeleccionarProveedor()
        {
            try
            {
                var proveedor = grillaProveedores.SelectedRows[0].DataBoundItem as Proveedor;
                return proveedor;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void LimpiarFormulario()
        {
            txt_cuil_proveedor.Text = string.Empty;
            txt_razon_social_proveedor.Text = string.Empty;
        }


        private void FormularioProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_alta_proveedor_Click(object sender, EventArgs e)
        {
            var proveedor = LeerProveedor();
            if (!proveedor.ValidarProveedor())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }
            AplicarAccion(proveedor, proveedorBLL.GuardarProveedorNuevo);
            LimpiarFormulario();
            RefrescarGrilla();
            DatosProveedorActualizado?.Invoke(this, new EventArgs());
        }

        private void btn_baja_proveedor_Click(object sender, EventArgs e)
        {
            var proveedor = SeleccionarProveedor();
            if (proveedor == null)
            {
                MessageBox.Show(this, "Debe seleccionar un autor");
                return;
            }

            proveedorBLL.EliminarProveedor(proveedor);
            RefrescarGrilla();
            DatosProveedorActualizado?.Invoke(this, new EventArgs());

        }

        private void btn_modificacion_proveedor_Click(object sender, EventArgs e)
        {
            var proveedor = SeleccionarProveedor();
            if (proveedor == null)
            {
                MessageBox.Show(this, "Error", "No se seleccionó método a editar");
                return;
            }
            proveedor.Cuil = txt_cuil_proveedor.Text.Trim();
            proveedor.Razon_Social = txt_razon_social_proveedor.Text.Trim();
            AplicarAccion(proveedor, proveedorBLL.ModificarProveedor);
            DatosProveedorActualizado?.Invoke(this, new EventArgs());
        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.GERENTE_ALMACEN, UserRoles.GERENTE_TECNOLOGIA };
        }

        private void btn_historial_proveedor_Click(object sender, EventArgs e)
        {
            var proveedor = SeleccionarProveedor();
            if (proveedor == null)
            {
                MessageBox.Show(this, "Debe seleccionar un proveedor");
                return;
            }
            FormularioHistorialProveedor formulario = new FormularioHistorialProveedor(proveedor);
            if (!formulario.Disposing)
                formulario.ShowDialog(this);
        }

        private void btn_compra_mas_comun_Click(object sender, EventArgs e)
        {
            var proveedor = SeleccionarProveedor();
            if (proveedor == null)
            {
                MessageBox.Show("No hay proveedor seleccionado");
                return;
            }

            var librosMasComprados = libroBLL.BuscarLibroMasCompradoPorProveedor().AsQueryable();
            var grillaGenerica = new GrillaGenerica();
            grillaGenerica.GrillaRefrescada += (o, s) =>
            {
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Isbn)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Fecha_Reg)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Cantidad_Stock)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Genero_Fk)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Criterio_Acaba)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Monto_Unitario)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Activo)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Autores)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Genero)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Proveedor)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Nombre_Proveedor)].Visible = false;
                s.Columns[nameof(ConsultaLibroMasCompraDTO.Criterio_Esperado)].Visible = false;
            };
            grillaGenerica.RefrescarGrilla<ConsultaLibroMasCompraDTO>(librosMasComprados.Where(li => li.Proveedor_FK == proveedor.Id).OrderByDescending(ca => ca.cantidad));
            
            grillaGenerica.ShowDialog(this);
        }

        private void btn_mayor_compra_Click(object sender, EventArgs e)
        {
            var proveedor = SeleccionarProveedor();
            if (proveedor == null)
            {
                MessageBox.Show("No hay proveedor seleccionado");
                return;
            }

            var mayorCompra = libroBLL.MayorCompraProveedor().AsQueryable();
            var grillaGenerica = new GrillaGenerica();
            grillaGenerica.RefrescarGrilla<MayorCompraDTO>(mayorCompra.Where(li => li.proveedor_fk == proveedor.Id).OrderByDescending(ca => ca.cantidad));
            grillaGenerica.ShowDialog(this);
        }

        private void btn_menor_precio_Click(object sender, EventArgs e)
        {
            var menorPrecio = libroBLL.MenorPrecioProveedores().AsQueryable();
            var grillaGenerica = new GrillaGenerica();
            grillaGenerica.RefrescarGrilla<MenorPrecioDTO>(menorPrecio.OrderBy(precio => precio.precio));
            grillaGenerica.ShowDialog(this);
        }

        private void btn_mayor_rapidez_Click(object sender, EventArgs e)
        {
            var mayorRapidez = proveedorBLL.BuscarProveedorConMayorRapidez().AsQueryable();
            var grillaGenerica = new GrillaGenerica();
            grillaGenerica.RefrescarGrilla<MayorRapidezDTO>(mayorRapidez);
            grillaGenerica.ShowDialog(this);
        }
    }
}
