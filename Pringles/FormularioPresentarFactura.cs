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
    public partial class FormularioPresentarFactura : BaseForm
    {
        public FacturaXML FacturaDTO { get; set; }
        public FormularioPresentarFactura(FacturaXML _facturaDTO)
        {

            InitializeComponent();
            FacturaDTO = _facturaDTO;
            CrearGrilla();
        }

        private void CrearGrilla()
        {
            this.grillaPresentarFactura.DataSource = null;
            this.grillaPresentarFactura.DataSource = FacturaDTO.DetalleOrdenes;

            grillaPresentarFactura.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c => c.Visible = false);

            grillaPresentarFactura.Columns[nameof(DetalleOrden.Libro_Fk)].Visible = true;
            grillaPresentarFactura.Columns[nameof(DetalleOrden.Precio_Unitario)].Visible = true;

            grillaPresentarFactura.Columns[nameof(DetalleOrden.Cantidad)].Visible = true;
            grillaPresentarFactura.Columns[nameof(DetalleOrden.Registro_Caja_Fk)].Visible = true;
            grillaPresentarFactura.Columns[nameof(DetalleOrden.MontoTotal)].Visible = true;
        }

        private void FormularioPresentarFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
