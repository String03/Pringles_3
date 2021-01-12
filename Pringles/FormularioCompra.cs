using Pringles.Contracts.Repositories;
using Pringles.Contracts.UnitsOfWorks;
using Pringles.DAL;
using Pringles.DAL.Lists;
using Pringles.DAL.Singletons;
using Pringles.DAL.UnitsOfWorks;
using Pringles.EE;
using Pringles.Utilities.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioCompra : BaseForm
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ILibroRepository _libroRepository;
        private readonly IAutorRepository _autorRepository;
        private readonly IGeneroRepository _generoRepository;
        private readonly IList<DetalleCompra> _compras;
        private readonly IProveedorRepository _proveedorRepository;

        private Proveedor instanciaProveedor;
        private Libro instanciaLibro;
        public event EventHandler CompraRealizada; 


        public FormularioCompra() : base()
        {
            RevisarRol();
            InitializeComponent();
            _clienteRepository = new ClienteRepository();
            _libroRepository = new LibroRepository();
            _compras = new CompraList();
            _autorRepository = new AutorRepository();
            _generoRepository = new GeneroRepository();
            _proveedorRepository = new ProveedorRepository();
        }

        private void RefrescarMonto()
        {
            decimal? totalCompra = ObtenerMontoCompra();
            lbl_total_compra.Text = (totalCompra ?? 0.00m).ToString("0.00", CultureInfo.InvariantCulture);
        }

        private decimal? ObtenerMontoCompra()
        {
            return _compras
                .Select(libro => libro.Cantidad * libro.Precio_Unitario)
                .Sum();
        }

        private void txt_cuil_proveedor_compra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarProveedor();
        }

        private void BuscarProveedor()
        {
            string cuil = txt_cuil_proveedor_compra.Text;

            if (string.IsNullOrEmpty(cuil) || !txt_cuil_proveedor_compra.MaskFull)
            {
                MessageBox.Show(this, "CUIL Incorrecto");
                return;
            }

            LimpiarCuil();

            Proveedor proveedor = _proveedorRepository.BuscarProveedorPorCuil(cuil);

            if (proveedor == null)
            {
                MessageBox.Show(this, "Proveedor no encontrado");
                LimpiarProveedor();
                return;
            }

            AsignarProveedor(proveedor);
        }

        private void BuscarLibro()
        {
            string isbn = txt_libro_compra.Text;
            LimpiarIsbn();

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show(this, "ISBN Vacio");
                return;
            }

            var libro = _libroRepository.BuscarLibroPorISBN(isbn);

            if (libro == null)
            {
                MessageBox.Show(this, "Libro no encontrado");
                LimpiarLibro();
                return;
            }

            AsignarLibro(libro);
        }

        private void LimpiarProveedor()
        {
            grp_grupo_proveedor.Visible = false;
            lbl_cuil_proveedor.Text = string.Empty;
            lbl_razon_social_proveedor.Text = string.Empty;
            instanciaProveedor = null;
        }

        private void LimpiarLibro()
        {
            grp_libro_compra.Visible = false;
            nud_cantidad_libro_compra.Value = 1;
            lbl_titulo_libro.Text = string.Empty;
            instanciaLibro = null;
        }

        private void AsignarProveedor(Proveedor proveedor)
        {
            instanciaProveedor = proveedor;
            lbl_cuil_proveedor.Text = instanciaProveedor.Cuil;
            lbl_razon_social_proveedor.Text = instanciaProveedor.Razon_Social;
            grp_grupo_proveedor.Visible = true;
        }

        private void AsignarLibro(Libro libro)
        {
            instanciaLibro = libro;
            nud_cantidad_libro_compra.Value = 1;
            lbl_titulo_libro.Text = instanciaLibro.Titulo;
            grp_libro_compra.Visible = true;
        }

        private void AgregarLibro()
        {
            if (instanciaLibro == null)
            {
                MessageBox.Show(this, "No hay libro cargado");
                return;
            }

            if (instanciaLibro.Prohibido)
            {
                MessageBox.Show(this, "Este libro esta prohibido");
                return;
            }

            if (instanciaLibro.Restringido && instanciaProveedor == null)
            {
                MessageBox.Show(this, "Este libro esta restringido, debe de ser un cliente inscrito para poder comprarlo");
                return;
            }



            DetalleCompra libro = CrearArticulo();

            if (libro.Precio_Unitario <= 0)
            {
                MessageBox.Show(this, "Monto unitario no válido");
                return;
            }
            _compras.Add(libro);
            LimpiarLibro();
            RefrescarCompra();
        }

        private void RefrescarGrillaCompra()
        {
            grillaCompra.DataSource = null;
            grillaCompra.DataSource = _compras.ToList();
            grillaCompra.Columns[nameof(DetalleCompra.Compras_Fk)].Visible = false;
            grillaCompra.Columns[nameof(DetalleCompra.Libro_Fk)].Visible = false;
            grillaCompra.Columns[nameof(DetalleCompra.Cantidad)].Visible = true;
            grillaCompra.Columns[nameof(DetalleCompra.Id)].Visible = false;
            grillaCompra.Columns[nameof(DetalleCompra.Precio_Unitario)].Visible = true;

        }

        private void LimpiarCuil()
        {
            txt_cuil_proveedor_compra.Text = string.Empty;
        }

        private void LimpiarIsbn()
        {
            txt_libro_compra.Text = string.Empty;
        }




        private DetalleCompra CrearArticulo()
        {
            return new DetalleCompra
            {
                Libro_Fk = instanciaLibro.Id,
                Precio_Unitario = decimal.TryParse(txt_monto_unitario_inventario_compra.Text, out decimal precioUnitario) ? precioUnitario : -1,
                Cantidad = Convert.ToInt32(nud_cantidad_libro_compra.Value),
                Libro = instanciaLibro
            };
        }





        private void txt_libro_venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BuscarLibro();
        }





        private void RefrescarCompra()
        {
            RefrescarGrillaCompra();
            RefrescarMonto();

        }


        private DetalleCompra SeleccionarArticulo()
        {
            try
            {
                return grillaCompra.SelectedRows[0].DataBoundItem as DetalleCompra;
            }
            catch
            {
                return null;
            }
        }



        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.GERENTE_TECNOLOGIA, UserRoles.GERENTE_ALMACEN };
        }

        private void btn_buscar_proveedor_compra_Click_1(object sender, EventArgs e)
        {
            BuscarProveedor();
            RefrescarCompra();
        }

        private void btn_buscar_libro_Click_1(object sender, EventArgs e)
        {
            BuscarLibro();
        }

        private void btn_alta_compra_Click(object sender, EventArgs e)
        {

            if (_compras.Count() == 0)
            {
                MessageBox.Show(this, "No hay articulos");
                return;
            }

            if (_compras.Any(a => a.Libro.Prohibido))
            {
                MessageBox.Show(this, "Esta venta contiene libro prohibido");
                return;
            }

            if (_compras.Any(a => a.Libro.Restringido) && instanciaProveedor == null)
            {
                MessageBox.Show(this, "Este libro esta restringido, debe de ser un cliente inscrito para poder comprarlo");
                return;
            }

            decimal montoTotal = ObtenerMontoCompra() ?? 0;


            if (montoTotal <= 0)
            {
                MessageBox.Show("No hay venta a realizar");
                return;
            }

            try
            {
                ICompraUnitOfWork uow = new CompraUnitOfWork();


                Usuario usuario = CurrentUser.GetCurrentInstance().Usuario;

                Compra compra = new Compra
                {

                    DetallesCompra = _compras,
                    fecha_reg = DateTime.Now,
                    Proveedor = instanciaProveedor,
                    Proveedor_Fk = instanciaProveedor.Id,
                    Usuario = usuario,
                    Usuario_Fk = usuario.Id,
                    Recibido = false,
                    Fecha_de_Recepcion = null
                };

                uow.RealizarCompra(compra, _compras);
                MessageBox.Show(this, "Compra realizada");


                _compras.Clear();
                LimpiarProveedor();
                LimpiarLibro();
                RefrescarCompra();
                CompraRealizada?.Invoke(this,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_articulo_compra_Click(object sender, EventArgs e)
        {
            var articulo = SeleccionarArticulo();

            if (articulo == null)
            {
                MessageBox.Show(this, "Debe de seleccionar un articulo");
                return;
            }

            _compras.Remove(articulo);

            RefrescarCompra();
        }

        private void btn_agregar_libro_compra_Click(object sender, EventArgs e)
        {
            AgregarLibro();
        }

        private void btn_cancelar_libro_compra_Click(object sender, EventArgs e)
        {
            LimpiarLibro();
        }

        private void btn_cancelar_proveedor_Click(object sender, EventArgs e)
        {
            LimpiarProveedor();
            RefrescarCompra();
        }

        private void FormularioCompra_Load(object sender, EventArgs e)
        {
            RefrescarCompra();
        }
    }



}

