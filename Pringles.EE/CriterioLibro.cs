using Pringles.Utilities.Attributes;
using System;



namespace Pringles.EE
{
    
    public class CriterioLibro
    {
        public int id { get; set; }

        public int criterio_id { get; set; }

        public int libro_id { get; set; }

        public DateTime? fecha_reg { get; set; }

        public virtual Criterio Criterio { get; set; }

        public virtual Libro Libro { get; set; }
    }
}
