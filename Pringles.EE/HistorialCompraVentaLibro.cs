using Pringles.Utilities.Attributes;
using System;

namespace Pringles.EE
{
    
    public class HistorialCompraVentaLibro
    {
        [KeyTableColumn]
        public int Id { get; set; }

        public int Libro_Fk { get; set; }

        public decimal Precio_Unitario_Compra { get; set; }

        public decimal Precio_Unitario_Venta { get; set; }

        public DateTime? Fecha_Reg { get; set; }

        public int Cantidad_Compra { get; set; }

        public DateTime? Fecha_Compra { get; set; }

        [TransientColumn]
        public virtual Libro Libro { get; set; }
    }
}
