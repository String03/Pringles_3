using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.Repositories
{
    public interface ICompraRepository : IRepository<Compra>
    {
        /// <summary>
        /// Busca la cantidad de compras realizadas a x proveedor
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns>IEnumerable de compras</returns>
        IEnumerable<Compra> BuscarPedidosProveedor(Proveedor proveedor);
    }
}
