using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;

namespace Pringles.EE
{
 
    public class Libro
    {
        [KeyTableColumn]
        public int Id { get; set; }

        //public int? Autor_Fk { get; set; }

        public string Isbn { get; set; }

        public DateTime? Fecha_Reg { get; set; }

        public int Cantidad_Stock { get; set; }

        public string Titulo { get; set; }

        public int? Genero_Fk { get; set; }

        public int? Proveedor_FK { get; set; }

        public int? Criterio_Acaba { get; set; }

        public decimal Monto_Unitario { get; set; }

        public bool Activo { get; set; }

        [TransientColumn]
        public ICollection<Autor> Autores { get; set; } = new List<Autor>();

        //[TransientColumn]
        //public Autor Autor { get; set; }

        [TransientColumn]
        public Genero Genero { get; set; }

        [TransientColumn]
        public Proveedor Proveedor { get; set; }

        [TransientColumn]
        public string Nombre_Proveedor { get => Proveedor?.ToString() ?? ""; }

        public bool Restringido { get; set; }

        public bool Prohibido { get; set; }

        [TransientColumn]
        public string RestringidoStr { get => Restringido ? "SI" : "NO"; }

        [TransientColumn]
        public string ProhibidoStr { get => Prohibido ? "SI" : "NO"; }

        public int? Criterio_Esperado { get; set; }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
