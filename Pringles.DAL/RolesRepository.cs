using Pringles.Contracts.Repositories;
using Pringles.EE;
using Pringles.Utilities.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class RolesRepository : Repository<Rol>, IRolesRepository
    {
        public bool CheckRolesExists()
        {
            return GetAll().Count() > 0;
        }

        public void CreateDefaultRole()
        {
            string query = CreateDefaultRoleQuery();
            IDictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@CODIGO_ROL", UserRoles.ADMIN },
                { "@DESCRIPCION", UserRoles.ADMIN_DESCRIPCION}
            };
            ExecuteNonQueryStatement(query, parameters);
        }

        public string CreateDefaultRoleQuery()
        {
            return "INSERT INTO ROL(CODIGO_ROL, DESCRIPCION) VALUES(@CODIGO_ROL, @DESCRIPCION)";
        }
    }
}
