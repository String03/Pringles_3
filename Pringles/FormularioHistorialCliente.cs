using Pringles.Contracts.Repositories;
using Pringles.DAL;
using Pringles.EE;
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
    public partial class FormularioHistorialCliente : Form
    {

        private readonly Cliente _cliente;
        private readonly IOrdenRepository _detalleOrdenRepository;
        private readonly IAutorRepository _autorRepository;
        private readonly IGeneroRepository _generoRepository;

        public FormularioHistorialCliente(Cliente cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            _detalleOrdenRepository = new OrdenRepository();
            _autorRepository = new AutorRepository();
            _generoRepository = new GeneroRepository();
        }

        private void FormularioHistorialCliente_Load(object sender, EventArgs e)
        {
            RefrescarGrillaCompras();
            lbl_autor_mas_vendido.Text = _autorRepository.BuscarAutorMasVendido(_cliente)?.ToString() ?? "Ninguno";
            lbl_genero_mas_vendido.Text = _generoRepository.BuscarGeneroMasVendido(_cliente)?.ToString() ?? "Ninguno";
        }

        private void RefrescarGrillaCompras()
        {
            grillaHistorialCliente.DataSource = _detalleOrdenRepository
                .BuscarPedidosCliente(_cliente)
                .SelectMany(TransformarHistorial)
                .OrderBy(c => c.Fecha)
                .ToList();

            var columnaFecha = grillaHistorialCliente.Columns[nameof(HistorialVenta.FechaStr)];
            columnaFecha.HeaderText = "Fecha";

            var columnaCantidad = grillaHistorialCliente.Columns[nameof(HistorialVenta.Cantidad)];
            columnaCantidad.HeaderText = "Cantidad";

            var columnaEfectivo = grillaHistorialCliente.Columns[nameof(HistorialVenta.Monto_Pago_Efectivo)];
            columnaEfectivo.HeaderText = "Monto Efectivo";

            var columnaTarjeta = grillaHistorialCliente.Columns[nameof(HistorialVenta.Monto_Pago_Tarjeta)];
            columnaTarjeta.HeaderText = "Monto Tarjeta";

            var columnaTitulo = grillaHistorialCliente.Columns[nameof(HistorialVenta.Titulo)];
            columnaTitulo.HeaderText = "Titulo";
        }

        private IEnumerable<HistorialVenta> TransformarHistorial(Orden orden)
        {
            foreach (var articulo in orden.DetallesOrdenes)
                // Retorna lista preparada con cada HistorialVenta.
                yield return new HistorialVenta
                {
                    Fecha = orden.Fecha_Reg.GetValueOrDefault(),
                    FechaStr = orden.Fecha_RegStr,
                    Cantidad = articulo.Cantidad.ToString(),
                    Monto_Pago_Efectivo = orden.Monto_Pago_Efectivo.ToString("0.00", CultureInfo.InvariantCulture),
                    Monto_Pago_Tarjeta = orden.Monto_Pago_Tarjeta.ToString("0.00", CultureInfo.InvariantCulture),
                    Titulo = articulo.Libro.Titulo
                };
        }
    }

    internal class HistorialVenta
    {
        public DateTime Fecha { get; set; }
        public string FechaStr { get; set; }
        public string Titulo { get; set; }
        public string Cantidad { get; set; }
        public string Monto_Pago_Efectivo { get; set; }
        public string Monto_Pago_Tarjeta { get; set; }
    }
}
