using Pringles.EE;
using Pringles.Utilities.Serializador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pringles
{
    public partial class FormularioGrillaFactura : GrillaGenerica
    {
        public FormularioGrillaFactura()
        {
            InitializeComponent();
            this.LineaSeleccionada += SeleccionarFactura;
        }

        private void SeleccionarFactura(object sender, object e)
        {
            if (e == null)
            {
                MessageBox.Show("Debe agregar factura");
            }

            try
            {

                var factura = e as FacturaDTO;
                var facturaXml = SerializadorXml.LeerXml<FacturaXML>(factura.texto);
                new FormularioPresentarFactura(facturaXml).ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrio un error generando factura");
                
            }
        }
    }
}
