using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.EE
{
    
    public class Email
    {
        [KeyTableColumn]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cliente_fk { get; set; }
    }
}
