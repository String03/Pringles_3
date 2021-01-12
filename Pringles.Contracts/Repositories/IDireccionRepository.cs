using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.Repositories
{
    public interface IDireccionRepository : IRepository<Direccion>
    {
        /// <summary>
        /// Devuelve las direcciones de un cliente
        /// </summary>
        /// <param name="cliente_id">id del cliente</param>
        /// <returns>IEnumerable de dirección</returns>
        IEnumerable<Direccion> BuscarDireccionCliente(int cliente_id);
    }
}
