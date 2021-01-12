using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.Repositories
{
    public interface IEmailRepository : IRepository<Email>
    {
        /// <summary>
        /// Devuelve los e-mail de un cliente
        /// </summary>
        /// <param name="cliente_id">id del cliente</param>
        /// <returns>IEnumerable de Email</returns>
        IEnumerable<Email> BuscarEmailCliente(int cliente_id);
    }
}
