using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;

namespace Pringles.EE
{
   
    public class Genero
    {
        public Genero()
        {
            DetallesDescuentos = new HashSet<DetalleDescuento>();
           
        }

        [KeyTableColumn]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [TransientColumn]
        public DateTime? Fecha_reg { get; set; }

        [TransientColumn]
        public virtual ICollection<DetalleDescuento> DetallesDescuentos { get; set; }


     

        public override string ToString()
        {
            return Nombre;
        }
    }
}
