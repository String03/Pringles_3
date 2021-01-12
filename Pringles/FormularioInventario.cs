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
    public partial class FormularioInventario : BaseForm
    {
        private readonly LibroBLL libroBLL;
        private readonly AutorBLL _autorBLL;
        private readonly GeneroBLL _generoBLL;
        private readonly ProveedorBLL _proveedorBLL;
        private readonly IList<Autor> AutoresLibros = new List<Autor>();
        private event EventHandler AutorSeleccionado;

        public FormularioInventario() : base()
        {
            RevisarRol();
            InitializeComponent();
            libroBLL = new LibroBLL(new LibroRepository());
            _autorBLL = new AutorBLL(new Repository<Autor>());
            _generoBLL = new GeneroBLL(new Repository<Genero>());
            _proveedorBLL = new ProveedorBLL(new ProveedorRepository());
            AutorSeleccionado += (o, s) => CargarAutorLibro();
        }

        /// <summary>
        /// Carga los autores en el listado.
        /// </summary>
        private void CargarAutorLibro()
        {
            var dataSource = _autorBLL.ListarAutores().Where(a=> !AutoresLibros.Contains(a)).ToList();
            cmb_autor_libro.DataSource = dataSource;
            cmb_autor_libro.ValueMember = "Id";
            cmb_autor_libro.DisplayMember = "Nombres";
        }

        

        private void CargarProveedorLibro()
        {
            var dataSource = _proveedorBLL.ListarProveedores().ToList();
            cmb_proveedores_inventario.DataSource = dataSource;
            cmb_proveedores_inventario.ValueMember = "Id";
            cmb_proveedores_inventario.DisplayMember = "Razon_Social";
        }

        private void CargarGeneroLibro()
        {
            var dataSource = _generoBLL.ListarGeneros().ToList();
            cmb_genero_libro.DataSource = dataSource;
            cmb_genero_libro.ValueMember = "Id";
            cmb_genero_libro.DisplayMember = "Nombre";
        }

        private void RefrescarGrilla()
        {
            grillaLibro.DataSource = null;
            grillaLibro.DataSource = libroBLL.ListarLibros().OrderByDescending(c => c.Cantidad_Stock).ToList();

            grillaLibro.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

            var cambiarMontoUnitario = grillaLibro.Columns[nameof(Libro.Monto_Unitario)];
            cambiarMontoUnitario.Visible = true;
            cambiarMontoUnitario.HeaderText = "Monto Unitario";
            cambiarMontoUnitario.DisplayIndex = 0;

            var cambiarCantidadStock = grillaLibro.Columns[nameof(Libro.Cantidad_Stock)];
            cambiarCantidadStock.Visible = true;
            cambiarCantidadStock.HeaderText = "Cantidad de Stock";
            cambiarCantidadStock.DisplayIndex = 0;

            var tituloUbicacion = grillaLibro.Columns[nameof(Libro.Titulo)];
            tituloUbicacion.Visible = true;
            tituloUbicacion.HeaderText = "Título";
            tituloUbicacion.DisplayIndex = 0;

            var isbnMinuscula = grillaLibro.Columns[nameof(Libro.Isbn)];
            isbnMinuscula.Visible = true;
            isbnMinuscula.HeaderText = "ISBN";
            isbnMinuscula.DisplayIndex = 0;

            var restringidoColumna = grillaLibro.Columns[nameof(Libro.RestringidoStr)];
            restringidoColumna.Visible = true;
            restringidoColumna.HeaderText = "Restringido";

            var prohibidoColumna = grillaLibro.Columns[nameof(Libro.ProhibidoStr)];
            prohibidoColumna.Visible = true;
            prohibidoColumna.HeaderText = "Prohibido";

            var proveedorLibroColumna = grillaLibro.Columns[nameof(Libro.Nombre_Proveedor)];
            proveedorLibroColumna.Visible = true;
            proveedorLibroColumna.HeaderText = "Proveedor";

            var precioUnitarioVenta = grillaLibro.Columns[nameof(Libro.Monto_Unitario)];
            precioUnitarioVenta.Visible = true;
            precioUnitarioVenta.HeaderText = "Monto Unitario";

        }

        private Libro LeerLibro()
        {
            try
            {
                return new Libro
                {
                    Titulo = txt_titulo_libro.Text.Trim(),
                    Isbn = txt_isbn_libro.Text.Trim(),
                    Cantidad_Stock = 0,
                    Autores = new List<Autor>(AutoresLibros),
                    Genero_Fk = Convert.ToInt32(cmb_genero_libro.SelectedValue),
                    Proveedor_FK = Convert.ToInt32(cmb_proveedores_inventario.SelectedValue),
                    Monto_Unitario = Decimal.TryParse(txt_monto_unitario_venta.Text.Trim(), out decimal montoUnitario) ? montoUnitario : 0,
                    Restringido = chk_restringido.Checked,
                    Prohibido = chk_prohibido.Checked,
                    Criterio_Acaba = Convert.ToInt32(nud_criterio_acaba.Value),
                    Criterio_Esperado = Convert.ToInt32(nud_criterio_esperado.Value),
                    Activo = true
                    
                };
            }
            catch
            {
                return null;
            }
        }

       // private void prueba(Libro libro)
       // {
       //     
       // }


        private void AplicarAccion(Libro libro, Action<Libro> action)
        {
            //Action<Libro> nombre = (libros) => { };
            //Action<Libro> nombre2 = prueba;

            //nombre.Invoke(libro);

            if (!libro.ValidarLibro())
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }
            try
            {
                action.Invoke(libro);
                RefrescarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error agregando datos a la base de datos");
            }
        }

        private void btn_alta_libro_Click(object sender, EventArgs e)
        {
            if (!TienePrivilegios()) 
            {
                MessageBox.Show("Este usuario no puede modificar el inventario");
                return;
            }

            var libro = LeerLibro();

            if (libro.Autores.Count == 0)
            {
                MessageBox.Show("No se agregó ningún autor");
                    return;
            }

            if (libro == null || !libro.ValidarLibro()|| libro.Autores.Count == 0)
            {
                MessageBox.Show(this, "Datos no validos");
                return;
            }
            AplicarAccion(libro, libroBLL.AltaLibros);
            LimpiarFormulario();
            RefrescarGrilla();
        }

        private void LimpiarFormulario()
        {
            txt_isbn_libro.Text = string.Empty;
            txt_titulo_libro.Text = string.Empty;
           
            chk_prohibido.Checked = false;
            chk_restringido.Checked = false;
            nud_criterio_acaba.Value = 0;
        }

        private void btn_agregar_autor_Click(object sender, EventArgs e)
        {
            // Abre el formulario del autor.
            var formulario = new FormularioAutor();
            formulario.DatosAutorActualizados += (o, s) =>
            {
                CargarAutorLibro();
            };
            if (!formulario.IsDisposed)
                formulario.ShowDialog(this);
        }

        private void btn_agregar_genero_Click(object sender, EventArgs e)
        {
            // Abre el formulario del genero.
            var formulario = new FormularioGenero();
            formulario.DatosGeneroActualizados += (o, s) =>
            {
                CargarGeneroLibro();
            };
            if (!formulario.IsDisposed)
                formulario.ShowDialog(this);
        }

        private void FormularioInventario_Load(object sender, EventArgs e)
        {
            CargarAutorLibro();
            CargarGeneroLibro();
            CargarProveedorLibro();
            RefrescarGrilla();
            RefrescarAutoresLibros();
        }

        private Libro SeleccionarLibro()
        {
            try
            {
                var libro = grillaLibro.SelectedRows[0].DataBoundItem as Libro;
                return libro;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private void btn_baja_libro_Click(object sender, EventArgs e)
        {
            if (!TienePrivilegios()) 
            {
                MessageBox.Show("Este usuario no puede modificar el inventario");
                return;
            }

            var libro = SeleccionarLibro();
            if (libro == null)
            {
                MessageBox.Show(this, "Debe seleccionar un usuario");
            }
            libroBLL.BajaLibros(libro);
            RefrescarGrilla();
        }

        private void btn_modificacion_libro_Click(object sender, EventArgs e)
        {
            var libro = SeleccionarLibro();
            if (libro == null)
            {
                MessageBox.Show(this, "Error", "No se seleccionó método a editar");
                return;
            }
            libro.Autores = new List<Autor>(AutoresLibros);

            libro.Titulo = txt_titulo_libro.Text.Trim();
            libro.Isbn = txt_isbn_libro.Text.Trim();
           
            //libro.Autor_Fk = Convert.ToInt32(cmb_autor_libro.SelectedValue);
            libro.Genero_Fk = Convert.ToInt32(cmb_genero_libro.SelectedValue);
           
            libro.Restringido = chk_restringido.Checked;
            libro.Prohibido = chk_prohibido.Checked;
            libro.Criterio_Acaba = nud_criterio_acaba.Value == 0m ? null : (int?)Convert.ToInt32(nud_criterio_acaba.Value);
            libro.Criterio_Esperado = nud_criterio_esperado.Value == 0m ? null : (int?)Convert.ToInt32(nud_criterio_esperado.Value);
            libro.Monto_Unitario = Decimal.TryParse(txt_monto_unitario_venta.Text.Trim(),out decimal montoUnitario)? montoUnitario : 0;
            AplicarAccion(libro, libroBLL.ModificarLibros);
            LimpiarFormulario();
        }

        private void txt_monto_unitario_inventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_libros_terminan_Click(object sender, EventArgs e)
        {
            MostrasLibrosAgotados();
        }

        private void MostrasLibrosAgotados()
        {
            Libro libroSeleccionado;

            try
            {
                libroSeleccionado = grillaLibro.SelectedRows[0].DataBoundItem as Libro;
            }
            catch (Exception)
            {

                MessageBox.Show("debe seleccionar el error");
                return;
            }
            
            var librosAgotados = libroBLL.BuscarLibrosCriterio().AsQueryable();
            var grillaGenerica = new GrillaGenericaCriterioLibro(libroSeleccionado);
            grillaGenerica.GrillaRefrescada += (o, s) =>
            {
                GrillaGenericaCriterioLibro referenciaInterna = o as GrillaGenericaCriterioLibro;
                s.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

                var columnaTitulo = s.Columns[nameof(Libro.Titulo)]; ;
                columnaTitulo.Visible = true;
                columnaTitulo.HeaderText = "Titulo";

                var columnaIsbn = s.Columns[nameof(Libro.Isbn)];
                columnaIsbn.Visible = true;
                columnaIsbn.HeaderText = "Isbn";

                var columnaStock = s.Columns[nameof(Libro.Cantidad_Stock)]; ;
                columnaStock.Visible = true;
                columnaStock.HeaderText = "Cantidad en stock";

                var list = (IEnumerable<Libro>)s.DataSource;
                if (list.Count() == 0)
                    return;
                int criterioAcaba = referenciaInterna.LibroSeleccionado.Criterio_Acaba ?? -1;
                int criterioEsperado = referenciaInterna.LibroSeleccionado.Criterio_Esperado ?? 0;
                int cantidadStock = referenciaInterna.LibroSeleccionado.Cantidad_Stock;
                StringBuilder sb = new StringBuilder();

                if (cantidadStock <= criterioAcaba)
                {
                    sb.Append("Este libro se encuentra acabandose\n");
                }
                else if (cantidadStock < criterioEsperado)
                {
                    sb.Append($"Me faltan {criterioEsperado - cantidadStock} para llegar al criterio esperado\n");
                }
                
                else if (criterioAcaba * 1.0 <= cantidadStock * 0.10)
                {
                    sb.Append("Me falta un 10% para que se me acaben los libros\n");
                }
                if (!string.IsNullOrEmpty(sb.ToString()))
                {
                    MessageBox.Show((IWin32Window)o, sb.ToString());
                }
                
            };
            grillaGenerica.RefrescarGrilla<Libro>(librosAgotados);
            grillaGenerica.ShowDialog(this);
        }

        private void grillaLibro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Libro libro = SeleccionarLibro();
            if (libro == null)
                return;
            CargarFormularioLibro(libro);
        }

        private void CargarFormularioLibro(Libro libro)
        {
            txt_titulo_libro.Text = libro.Titulo;
            txt_isbn_libro.Text = libro.Isbn;


            //cmb_autor_libro.SelectedValue = libro.Autor_Fk;
            cmb_genero_libro.SelectedValue = libro.Genero_Fk;

            chk_restringido.Checked = libro.Restringido;
            chk_prohibido.Checked = libro.Prohibido;
            nud_criterio_acaba.Value = libro.Criterio_Acaba ?? 0;
        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            var roles = new int[] { UserRoles.ADMIN, UserRoles.CAJERO, UserRoles.GERENTE_ALMACEN, UserRoles.GERENTE_TECNOLOGIA };
            return roles;
        }

        /// <summary>
        /// Utilizado para saber si el usuario tiene privilegios para modificar el inventario.
        /// </summary>
        /// <returns></returns>
        private bool TienePrivilegios() 
        {
            // Roles que pueden manipular el inventario.
            var roles = new int[] { UserRoles.ADMIN, UserRoles.CAJERO, UserRoles.GERENTE_ALMACEN };
            return TieneAcceso(roles);
        }

        private void btn_agregar_compra_Click(object sender, EventArgs e)
        {
            var formulario = new FormularioCompra();
            formulario.CompraRealizada += (o, s) =>
            {
                RefrescarGrilla();
            };
            if (!formulario.IsDisposed)
                formulario.ShowDialog(this);
        }

        private void txt_isbn_libro_TextChanged(object sender, EventArgs e)
        {
            BuscarLibroExiste();
        }

        private void BuscarLibroExiste()
        {
            var libro = libroBLL.BuscarLibroPorISBN(txt_isbn_libro.Text.Trim());
            if (libro != null)
            {
                CargarFormularioLibro(libro);
            }
        }

        private void btn_recepcion_de_libros_Click(object sender, EventArgs e)
        {
            var formulario = new FormularioRecibirLibros();
            if (!formulario.IsDisposed)
                formulario.ShowDialog(this);
        }

        private void RefrescarAutoresLibros()
        {
            grillaSeleccionarAutor.DataSource = null;
            grillaSeleccionarAutor.DataSource = AutoresLibros;
            if (AutoresLibros.Count == 0)
            {
                return;
            }

            grillaSeleccionarAutor.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

            var nombreAutor = grillaSeleccionarAutor.Columns[nameof(Autor.NombreCompleto)];
            nombreAutor.Visible = true;
            nombreAutor.HeaderText = "Nombre Autor";
            nombreAutor.DisplayIndex = 0;
        }

        private void agregar_autor_al_libro_Click(object sender, EventArgs e)
        {
            var autor = SeleccionarAutorLibro();
            if(autor == null)
            {
                MessageBox.Show("No se seleccionó autor");
                return;
            }
            AutoresLibros.Add(autor);
            RefrescarAutoresLibros();
            AutorSeleccionado?.Invoke(this,null);
        }

        private void limpiar_grilla_autor_Click(object sender, EventArgs e)
        {
            AutoresLibros.Clear();
            RefrescarAutoresLibros();
            AutorSeleccionado?.Invoke(this, null);
        }

        private Autor SeleccionarAutorLibro()
        {
            try
            {
                var autor = cmb_autor_libro.SelectedItem as Autor;
                return autor;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
