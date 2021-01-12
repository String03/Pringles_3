using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class DireccionRepository : Repository<Direccion>, IDireccionRepository
    {
        public IEnumerable<Direccion> BuscarDireccionCliente(int cliente_id)
        {
            return ExecuteSelectStatement(@"SELECT * FROM  DireccionCliente  WHERE cliente_fk =" + cliente_id);
        }
    }
}
