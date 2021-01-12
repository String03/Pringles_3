using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{
   
    public class Proveedor
    {
        [KeyTableColumn]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
       
        public string Cuil { get; set; }

        [Required]
        [StringLength(200)]
    
        public string Razon_Social { get; set; }

        [TransientColumn]
        public ICollection<Libro> Libros { get; set; } = new List<Libro>();

        public override string ToString()
        {
            return Razon_Social;
        }
    }
}
