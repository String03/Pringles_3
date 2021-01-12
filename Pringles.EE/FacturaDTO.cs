using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{
    public class FacturaDTO
    {
        public int id { get; set; }
        public string texto { get; set; }
        public DateTime fecha_reg { get; set; }
        public string nombres { get; set; }
        public string apellido { get; set; }
    }
}
