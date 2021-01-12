using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.Repositories
{
    public interface ITelefonoClienteRepository : IRepository<TelefonoCliente>
    {
        /// <summary>
        /// Busca un teléfono específico de un cliente
        /// </summary>
        /// <param name="cliente_id">id del cliente</param>
        /// <param name="telefono_fk">fk de teléfono</param>
        /// <returns>Un dto de telefono cliente</returns>
        TelefonoClienteDTO BuscarTelefonoCliente(int cliente_id, int telefono_fk);
    }
}
