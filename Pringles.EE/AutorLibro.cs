using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{
   
    public class AutorLibro
    {
        [KeyTableColumn]
        public int Id { get; set; }
        public int Autor_Fk { get; set; }
        public int Libro_Fk { get; set; }
        [TransientColumn]
        public Autor Autor { get; set; }
        [TransientColumn]
        public Libro Libro { get; set; }
    }
}
