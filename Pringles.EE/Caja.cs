using System;
using System.ComponentModel.DataAnnotations;
using Pringles.Utilities.Attributes;

namespace Pringles.EE
{
   
    public class Caja
    {
        [KeyTableColumn]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Descripcion { get; set; }

        [TransientColumn]
        public DateTime? Fecha_Reg { get; set; }
    }
}
