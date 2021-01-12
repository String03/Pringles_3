using Pringles.EE;
using System.Linq;

namespace Pringles.Contracts.Repositories
{
    public interface IRolesRepository: IRepository<Rol>
    {
        /// <summary>
        /// Revisa si existe por lo menos un rol.
        /// </summary>
        /// <returns></returns>
        bool CheckRolesExists();
        /// <summary>
        /// Crea un rol por determinado.
        /// </summary>
        void CreateDefaultRole();
    }
}
