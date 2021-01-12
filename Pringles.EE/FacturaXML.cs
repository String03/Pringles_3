using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pringles.EE
{
    [Serializable]
    public class FacturaXML
    {
    
        public List<DetalleOrden> DetalleOrdenes { get; set; } = new List<DetalleOrden>();
        public Orden ordenes { get; set; } = new Orden();

    }
}
