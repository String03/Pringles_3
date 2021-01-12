using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        /// <summary>
        /// Se encarga de buscar un cliente por el número de dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve el dni de un cliente</returns>
        Cliente BuscarClientePorDni(string dni);

        /// <summary>
        /// Se encarga de buscar el cliente con más compras
        /// </summary>
        /// <returns>Devuelve el cliente con más compras realizadas</returns>
        Cliente BuscarMejorCliente();
    }
}
