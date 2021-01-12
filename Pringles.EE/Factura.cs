using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{

    public class Factura
    {
        [KeyTableColumn]
        public int Id { get; set; }
       
        public string Texto { get; set; }
        public int Orden_Fk { get; set; }
       
    }
}
