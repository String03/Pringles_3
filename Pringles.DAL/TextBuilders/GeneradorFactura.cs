using Pringles.Contracts.TextBuilders;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL.TextBuilders
{
    public class GeneradorFactura : IGeneradorFactura
    {
        public string CrearFactura(IEnumerable<DetalleOrden> articulos)
        {
            string baseStr = "\t\tPRINGLES\nLIBRO\t\tPRECIO UNITARIO\tCANTIDAD\tTOTAL\t\t\n";
            StringBuilder sb = new StringBuilder();

            foreach (var articulo in articulos)
            {
                sb
                    .Append(articulo.Libro.Titulo.Length > 15 ? articulo.Libro.Titulo.Substring(0, 15) : articulo.Libro.Titulo)
                    .Append("\t\t")
                    .Append(articulo.Precio_Unitario)
                    .Append("\t\t")
                    .Append(articulo.Cantidad)
                    .Append("\t\t")
                    .Append(articulo.MontoTotal.ToString("0.00", CultureInfo.InvariantCulture))
                    .Append("\n");
            }

            string resultado = baseStr + sb.ToString();
            return resultado;
        }

        public FacturaXML CrearFacturaObjeto(Orden orden, IEnumerable<DetalleOrden> articulos)
        {
            return new FacturaXML
            {
                DetalleOrdenes = articulos.ToList(),
                ordenes = orden
            };
        }
    }
}
