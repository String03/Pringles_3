namespace Pringles.EE
{
    using Pringles.Utilities.Attributes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    

    
    public class Criterio
    {

        public Criterio()
        {
            CriterioLibros = new HashSet<CriterioLibro>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string codigo_criterio { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public DateTime? fecha_reg { get; set; }

        public bool? requiere_cliente { get; set; }

        public bool? prohibe_venta { get; set; }

       
        public virtual ICollection<CriterioLibro> CriterioLibros { get; set; }
    }
}
