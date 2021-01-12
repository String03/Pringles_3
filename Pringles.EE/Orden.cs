using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;

namespace Pringles.EE
{
   
    public class Orden
    {
        public Orden()
        {
            DetallesOrdenes = new HashSet<DetalleOrden>();
        }

        public int Id { get; set; }

        public int? Cliente_Fk { get; set; }

        public DateTime? Fecha_Reg { get; set; }

        [TransientColumn]
        [XmlIgnore]
        public string Fecha_RegStr
        {
            get 
            {
                try
                {
                    return Fecha_Reg.GetValueOrDefault().ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                catch
                {
                    return "N/A";
                }
            } 
        }

        public bool Pago_Efectivo { get; set; }

        public bool Pago_Tarjeta { get; set; }

        public decimal Monto_Pago_Efectivo { get; set; }

        public decimal Monto_Pago_Tarjeta { get; set; }

        public int Caja_Fk { get; set; }

        public int Usuario_Fk { get; set; }

        public decimal Cambio_Dinero { get; set; }

        [TransientColumn]
        [XmlIgnore]
        public virtual Caja Caja { get; set; }

        [TransientColumn]
        [XmlIgnore]
        public virtual Cliente Cliente { get; set; }

        [TransientColumn]
        [XmlIgnore]
        public virtual ICollection<DetalleOrden> DetallesOrdenes { get; set; }

        [TransientColumn]
        [XmlIgnore]
        public virtual Usuario Usuario { get; set; }
    }
}
