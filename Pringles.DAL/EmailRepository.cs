using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class EmailRepository : Repository<Email>,IEmailRepository
    {

        public IEnumerable<Email> BuscarEmailCliente(int cliente_id)
        {
            return ExecuteSelectStatement(@"SELECT * FROM  EmailCliente WHERE cliente_fk =" + cliente_id);
        }
    }
}
