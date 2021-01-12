using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.Repositories
{
    public interface IProveedorRepository : IRepository<Proveedor>
    {
        /// <summary>
        /// Busca el proveedor por el número de cuil
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns>Devuelve un proveedor</returns>
        Proveedor BuscarProveedorPorCuil(string cuil);
              
        /// <summary>
        /// Lista los proveedores según más rápido envía el pedido
        /// </summary>
        /// <returns>IEnumerable de un DTO de mayor rapidez</returns>
        IEnumerable<MayorRapidezDTO> BuscarProveedorMayorRapidez();
    }
}
