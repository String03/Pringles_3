using Pringles.EE;
using System.Collections.Generic;

namespace Pringles.Contracts.Repositories
{
    public interface IOrdenRepository : IRepository<Orden>
    {
        /// <summary>
        /// Busca las ordenes hechas por un cliente.
        /// </summary>
        /// <param name="cliente">Cliente a utilizar en la consulta.</param>
        /// <returns></returns>
        IEnumerable<Orden> BuscarPedidosCliente(Cliente cliente);
    }
}
