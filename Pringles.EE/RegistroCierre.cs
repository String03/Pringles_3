using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pringles.EE
{
    public class RegistroCierre
    {
        public int id { get; set; }

        public int registro_calendario_fk { get; set; }

        public DateTime? fecha_reg { get; set; }

        [Column(TypeName = "money")]
        public decimal monto_caja { get; set; }

        [Column(TypeName = "money")]
        public decimal monto_cierre { get; set; }

        public virtual RegistroCaja RegistrosCaja { get; set; }
    }
}
