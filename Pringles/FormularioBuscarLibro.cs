using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.EE;
using Pringles.Utilities.Consts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioBuscarLibro : BaseForm
    {
        private readonly ILibroRepository _libroRepository;

        public FormularioBuscarLibro(ILibroRepository libroRepository) : base()
        {
            InitializeComponent();
            _libroRepository = libroRepository;
        }

        public FormularioBuscarLibro() : base()
        {
            RevisarRol();
            InitializeComponent();
            _libroRepository = new LibroRepository();
        }

        private void RefrescarGrillar(IEnumerable<Libro> libros)
        {
            grillaBuscarLibro.DataSource = null;
            grillaBuscarLibro.DataSource = libros.ToList();

            grillaBuscarLibro.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

            var cambiarMontoUnitario = grillaBuscarLibro.Columns[nameof(Libro.Monto_Unitario)];
            cambiarMontoUnitario.Visible = true;
            cambiarMontoUnitario.HeaderText = "Monto Unitario";
            cambiarMontoUnitario.DisplayIndex = 0;

            var cambiarCantidadStock = grillaBuscarLibro.Columns[nameof(Libro.Cantidad_Stock)];
            cambiarCantidadStock.Visible = true;
            cambiarCantidadStock.HeaderText = "Cantidad de Stock";
            cambiarCantidadStock.DisplayIndex = 0;

            var tituloUbicacion = grillaBuscarLibro.Columns[nameof(Libro.Titulo)];
            tituloUbicacion.Visible = true;
            tituloUbicacion.HeaderText = "Título";
            tituloUbicacion.DisplayIndex = 0;

            var isbnMinuscula = grillaBuscarLibro.Columns[nameof(Libro.Isbn)];
            isbnMinuscula.Visible = true;
            isbnMinuscula.HeaderText = "ISBN";
            isbnMinuscula.DisplayIndex = 0;

            var restringidoColumna = grillaBuscarLibro.Columns[nameof(Libro.RestringidoStr)];
            restringidoColumna.Visible = true;
            restringidoColumna.HeaderText = "Restringido";

            var prohibidoColumna = grillaBuscarLibro.Columns[nameof(Libro.ProhibidoStr)];
            prohibidoColumna.Visible = true;
            prohibidoColumna.HeaderText = "Prohibido";
        }

        private void btn_buscar_libro_Click(object sender, EventArgs e)
        {
            IniciarBusquesda();
        }

        private void IniciarBusquesda()
        {
            string autor = txt_autor_buscar_libro.Text.Trim();
            string genero = txt_genero_buscar_libro.Text.Trim();

            IEnumerable<Libro> libros = _libroRepository.BuscarLibros(genero, autor);
            RefrescarGrillar(libros);

            if (libros.Count() == 0)
                MessageBox.Show(this, "No hubo coincidencia.");
        }

        private void txt_autor_buscar_libro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                IniciarBusquesda();
        }

        private void txt_genero_buscar_libro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                IniciarBusquesda();
        }

        private void grillaBuscarLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Libro libro = SeleccionarLibro();
            if (libro == null)
            {
                MessageBox.Show(this, "Debe de seleccionar un libro");
                return;
            }

            new FormularioDetalleLibro(libro).ShowDialog(this);
        }

        private Libro SeleccionarLibro()
        {
            try
            {
                return grillaBuscarLibro.SelectedRows[0].DataBoundItem as Libro;
            }
            catch
            {
                return null;
            }
        }

        private void FormularioBuscarLibro_Load(object sender, EventArgs e)
        {

        }

        protected override IEnumerable<int> GetRolesPermitidos()
        {
            return new int[] { UserRoles.ADMIN, UserRoles.CAJERO, UserRoles.GERENTE_TECNOLOGIA, UserRoles.GERENTE_VENTAS };
        }
    }
}
