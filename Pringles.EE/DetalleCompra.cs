using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{
    
    public class DetalleCompra
    {
        public int Id { get; set; }

        public int Compras_Fk { get; set; }

        public int Libro_Fk { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio_Unitario { get; set; }

        [TransientColumn]
        public Libro Libro { get; set; }
    }
}
