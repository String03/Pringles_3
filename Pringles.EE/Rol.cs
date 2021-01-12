using Pringles.Utilities.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pringles.EE
{
   
    public class Rol
    {
       

        [KeyTableColumn]
        public int Id { get; set; }

        public int? Codigo_Rol { get; set; }

        [StringLength(120)]
        public string Descripcion { get; set; }

        

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
