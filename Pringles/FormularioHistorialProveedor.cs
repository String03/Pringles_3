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
    public partial class FormularioHistorialProveedor : Form
    {
        private readonly Proveedor _proveedor;
        private readonly ICompraRepository _detalleCompraRepository;
        private readonly IAutorRepository _autorRepository;
        private readonly IGeneroRepository _generoRepository;

        public FormularioHistorialProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            _proveedor = proveedor;
            _detalleCompraRepository = new CompraRepository();
            _autorRepository = new AutorRepository();
            _generoRepository = new GeneroRepository();
        }

        private void FormularioHistorialProveedor_Load(object sender, EventArgs e)
        {
            RefrescarGrillaCompra();
            lbl_autor_mas_comprado_proveedor.Text = _autorRepository.BuscarAutorMasVendidoPorProveedor(_proveedor)?.ToString();
            lbl_genero_mas_comprado_proveedor.Text = _generoRepository.BuscarGeneroMasVendidoPorProveedor(_proveedor)?.ToString();
        }

        private void RefrescarGrillaCompra()
        {
            grillaHistorialProveedor.DataSource = _detalleCompraRepository
                .BuscarPedidosProveedor(_proveedor)
                .SelectMany(TransformarHistoriales)
                .OrderBy(h => h.Titulo)
                .ToList();

            var columnaFecha = grillaHistorialProveedor.Columns[nameof(HistorialCompra.FechaStr)];
            columnaFecha.HeaderText = "Fecha";

            var columnaCantidad = grillaHistorialProveedor.Columns[nameof(HistorialCompra.Cantidad)];
            columnaCantidad.HeaderText = "Cantidad";

            var columnaTitulo = grillaHistorialProveedor.Columns[nameof(HistorialCompra.Titulo)];
            columnaTitulo.HeaderText = "Titulo";
        }

        private IEnumerable<HistorialCompra> TransformarHistoriales(Compra compra)
        {
            foreach (var articulo in compra.DetallesCompra)
            {
                yield return new HistorialCompra
                {
                    Fecha = compra.fecha_reg.GetValueOrDefault(),
                    FechaStr = compra.Fecha_RegStr,
                    Cantidad = articulo.Cantidad.ToString(),
                    Titulo = articulo.Libro.Titulo
                };
            }
        }

        internal class HistorialCompra
        {
            public DateTime Fecha { get; set; }
            public string FechaStr { get; set; }
            public string Titulo { get; set; }
            public string Cantidad { get; set; }
        }
    }
}
