using Pringles.Utilities.Attributes;
using System;

namespace Pringles.EE
{
    
    public class RegistroCaja
    {
        [KeyTableColumn]
        public int Id { get; set; }

        public DateTime? Fecha_Calendario { get; set; }

        public DateTime? Fecha_Reg { get; set; }

        public decimal Monto_Inicial { get; set; }

        public bool Vigente { get; set; }

        public int Caja_Fk { get; set; }
        [TransientColumn]
        public Caja Caja { get; set; }
    }
}
