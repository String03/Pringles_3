using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Pringles.Utilities.Attributes;

namespace Pringles.EE
{
   
    public class Autor
    {
        [KeyTableColumn]
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
       
        public string Nombres { get; set; }

        [Required]
        [StringLength(120)]
       
        public string Apellido { get; set; }

        [TransientColumn]
        public DateTime? Fecha_reg { get; set; }

        [TransientColumn]
        public ICollection<DetalleDescuento> DetallesDescuentos { get; set; } = new List<DetalleDescuento>();

        [TransientColumn]
        public ICollection<Libro> Libros { get; set; } = new List<Libro>();

        [TransientColumn]
        public string NombreCompleto 
        {
            get 
            {
                try
                {
                    return $"{Nombres} {Apellido}".Trim();
                }
                catch
                {
                    return null;
                }
            } 
        }

        //Equals se usa para comparación
        public override bool Equals(object obj)
        {
            var autor = obj as Autor;
            return autor != null &&
                   Id == autor.Id;
        }

        public override string ToString()
        {
            return NombreCompleto;
        }


    }
}
