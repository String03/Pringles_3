using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{
    public class ConsultaLibroMasCompraDTO : Libro
    {
        public string razon_Social { get; set; }
        public string titulo { get; set; }
        public int id { get; set; }
        public int cantidad { get; set; }
    }
}
