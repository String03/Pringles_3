using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{
   
    public class Compra
    {
        [KeyTableColumn]
        public int Id { get; set; }

        public int Proveedor_Fk { get; set; }

        public int Usuario_Fk { get; set; }

        public DateTime? fecha_reg { get; set; }
        [TransientColumn]
        public IList<DetalleCompra> DetallesCompra { get; set; }
        [TransientColumn]
        public Proveedor Proveedor { get; set; }
        [TransientColumn]
        public Usuario Usuario { get; set; }

        public DateTime? Fecha_de_Recepcion { get; set; }

        public bool Recibido { get; set; }

        [TransientColumn]
        public string Fecha_RegStr
        {
            get
            {
                try
                {
                    return fecha_reg.GetValueOrDefault().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch
                {
                    return "N/A";
                }
            }
        }
    }
}
