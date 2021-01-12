using Pringles.EE;
using System.Collections.Generic;

namespace Pringles.Contracts.TextBuilders
{
    public interface IGeneradorFactura
    {
        /// <summary>
        /// Crea un string equivalente a la factura del sistema.
        /// </summary>
        /// <param name="articulos"></param>
        /// <returns></returns>
        string CrearFactura(IEnumerable<DetalleOrden> articulos);

        /// <summary>
        /// Crea el objeto serializado de factura
        /// </summary>
        /// <param name="orden"></param>
        /// <param name="articulos"></param>
        /// <returns></returns>
        FacturaXML CrearFacturaObjeto(Orden orden,IEnumerable<DetalleOrden> articulos);
    }
}
