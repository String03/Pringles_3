using Pringles.Utilities.Attributes;
using System;
using System.Globalization;

namespace Pringles.EE
{
   
    public partial class DetalleDescuento
    {
        [KeyTableColumn]
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public DateTime? Fecha_Reg { get; set; }

        public DateTime? Fecha_Fin { get; set; }

        public bool? Aplica_Genero { get; set; }

        public int? Genero_Fk { get; set; }

        public bool? Aplica_Autor { get; set; }

        public int? Autor_Fk { get; set; }

        public decimal Descuento { get; set; }

        public bool Estatus { get; set; }

        [TransientColumn]
        public virtual Autor Autor { get; set; }

        [TransientColumn]
        public virtual Genero Genero { get; set; }

        [TransientColumn]
        public string DescuentoStr { get => $"{Descuento}%"; }

        [TransientColumn]
        public string FechaVencimientoStr { get => Fecha_Fin?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) ?? "N/A"; }
    }
}
