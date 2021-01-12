using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class UsuarioBLL
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        /// <summary>
        /// Crea una instancia de UsuarioBLL.
        /// </summary>
        /// <param name="usuarioRepository"></param>
        public UsuarioBLL(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        /// <summary>
        /// Guarda un usuario nuevo en la base de datos.
        /// </summary>
        /// <param name="usuario">Usuario nuevo a guardar.</param>
        
        public void GuardarUsuarioNuevo(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Save(usuario);
            }
            catch (Exception ex)
            {

                ThrowExceptionUsuario("Error guardando usuario " + ex.Message);
            }
        }

        /// <summary>
        /// Eliminar un usuario.
        /// </summary>
        /// <param name="usuario">Usuario a eliminar.</param>
        public void EliminarUsuario(Usuario usuario)
        {
            try
            {
                Usuario temp = _usuarioRepository.Find(usuario.Id);
                if (temp == null)
                    ThrowExceptionUsuario("El autor a eliminar no existe");
                _usuarioRepository.Delete(usuario);

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Busca todos los usuarios de la base datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Usuario> ListarUsuarios()
        {
            return _usuarioRepository.GetAll();
        }

        /// <summary>
        /// Permite actualizar el registro de usuario
        /// </summary>
        /// <param name="usuario"></param>
        public void ModificarUsuario(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        private void ThrowExceptionUsuario(string message)
        {
            Exception ex = new Exception(message);
            throw ex;
        }
    }
}
