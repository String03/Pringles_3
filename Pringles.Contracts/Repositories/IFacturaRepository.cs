using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.Repositories
{
    public interface IFacturaRepository: IRepository<Factura>
    {
        /// <summary>
        /// Guarda la factura en la base de datos.
        /// </summary>
        /// <param name="orden_fk">fk de orden</param>
        /// <param name="factura">Contenido de la factura</param>
        void GuardarFactura(int orden_fk, string factura);

        /// <summary>
        /// Muestra el listado de facturas emitidas.
        /// </summary>
        /// <returns>IEnumerable de un DTO (data transfer object) de factura</returns>
        IEnumerable<FacturaDTO> ListarFactura();
    }
}
