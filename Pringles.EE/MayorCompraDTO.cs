using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{
    public class MayorCompraDTO
    {
        public int cantidad { get; set; }
        public string titulo { get; set; }
        public int libro_fk { get; set; }
        public int proveedor_fk { get; set; }
    }
}
