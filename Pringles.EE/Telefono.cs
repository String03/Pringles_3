using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{

    public class Telefono
    {
        [KeyTableColumn]
        public int Id { get; set; }
        public int Tipo_telefono_fk { get; set; }
        public string Numero { get; set; }
    }
}
