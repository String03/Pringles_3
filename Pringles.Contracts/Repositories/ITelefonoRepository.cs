using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.Repositories
{
    public interface ITelefonoRepository : IRepository<Telefono>
    {
        /// <summary>
        /// devuelve el listado de teléfonos de un cliente
        /// </summary>
        /// <param name="cliente_id">id del cliente</param>
        /// <returns>un dto de Telefono Cliente</returns>
        IEnumerable<TelefonoClienteDTO> BuscarTelefonoCliente(int cliente_id);

        /// <summary>
        /// Lista los números de teléfono que coinciden con x número
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>un dto de telefono</returns>
        IEnumerable<TelefonoDTO> BuscarTelefono(string numero);
    }
}
