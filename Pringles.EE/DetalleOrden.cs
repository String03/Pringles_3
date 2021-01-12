using Pringles.Utilities.Attributes;
using Pringles.Utilities.Consts;
using System;
using System.Xml.Serialization;

namespace Pringles.EE
{
   
    public class DetalleOrden : IEquatable<DetalleOrden>
    {
        [KeyTableColumn]
        public int Id { get; set; }

        public int Orden_Fk { get; set; }

        public int Libro_Fk { get; set; }

        public decimal Precio_Unitario { get; set; }

        public decimal? Descuento { get; set; }

        public int Cantidad { get; set; }

        public int? Detalle_Descuento_Fk { get; set; }

        public int Registro_Caja_Fk { get; set; }

        [TransientColumn]
        [XmlIgnore]
        public string NombreLibro
        {
            get => Libro?.Titulo ?? "N/A";
        }

        [TransientColumn]
        [XmlIgnore]
        public Libro Libro { get; set; }

        [TransientColumn]
        [XmlIgnore]
        public decimal MontoTotal
        {
            get
            {
                try
                {
                    return Precio_Unitario * PorcentajeVentas.PORCENTAJE_GANANCIA * Cantidad * (Descuento == null ? 1.0m : (Descuento.Value / 100.0m));
                }
                catch (Exception)
                {
                    return 0m;
                }
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as DetalleOrden);
        }

        public bool Equals(DetalleOrden other)
        {
            return other != null &&
                   Libro_Fk == other.Libro_Fk;
        }
    }
}
