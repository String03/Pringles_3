using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class RolBLL
    {
        private readonly IRepository<Rol> _rolRepository;

        /// <summary>
        /// Crea una instancia de RolBLL.
        /// </summary>
        /// <param name="rolRepository"></param>
        public RolBLL(IRepository<Rol> rolRepository)
        {
            _rolRepository = rolRepository;
        }

        /// <summary>
        /// Guarda un rol nuevo en la base de datos.
        /// </summary>
        /// <param name="rol">Rol nuevo a guardar.</param>
        public void GuardarRolNuevo(Rol rol)
        {
            try
            {
                _rolRepository.Save(rol);
            }
            catch (Exception ex)
            {

                ThrowExceptionRol("Error guardando rol " + ex.Message);
            }
        }

        /// <summary>
        /// Eliminar un rol.
        /// </summary>
        /// <param name="rol">Rol a eliminar.</param>
        public void EliminarRol(Rol rol)
        {
            try
            {
                Rol temp = _rolRepository.Find(rol.Id);
                if (temp == null)
                    ThrowExceptionRol("El autor a eliminar no existe");
                _rolRepository.Delete(rol);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// Busca todos los roles de la base datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Rol> ListarRoles()
        {
            return _rolRepository.GetAll();
        }

        /// <summary>
        /// Actualiza un rol seleccionado
        /// </summary>
        /// <param name="rol"></param>
        public void ModificarRoles(Rol rol)
        {
            _rolRepository.Update(rol);
        }

        private void ThrowExceptionRol(string message)
        {
            Exception ex = new Exception(message);
            throw ex;
        }
    }
}
