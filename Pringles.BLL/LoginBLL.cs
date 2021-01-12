using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pringles.Contracts.Repositories;
using Pringles.EE;

namespace Pringles.BLL
{
    public class LoginBLL
    {
        private readonly ISeguridadRepository _seguridadRepository;
        private readonly IRolesRepository _rolesRepository;

        public LoginBLL(ISeguridadRepository seguridadRepository, IRolesRepository rolesRepository)
        {
            _seguridadRepository = seguridadRepository;
            _rolesRepository = rolesRepository;
        }

        /// <summary>
        /// Revisa si existen por lo menos un rol y un usuario cuando inicializa el sistema.
        /// </summary>
        public void InitialCheck()
        {
            if (!_rolesRepository.CheckRolesExists())
            {
                try
                {
                    _rolesRepository.CreateDefaultRole();
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo crear rol por defecto: " + ex.Message);
                }
            }

            if (!_seguridadRepository.CheckUserExists())
            {
                try
                {
                    _seguridadRepository.CreateDefaultAdmin();
                }
                catch (Exception ex)
                {
                    throw new Exception("No se pudo crear usuario por defecto: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Realiza el login y revisa si el usuario puede entrar al sistema.
        /// </summary>
        /// <param name="user">Usuario para el login.</param>
        /// <param name="password">Contrasena para el login.</param>
        /// <returns></returns>
        public bool Authenticate(string user, string password)
        {
            return _seguridadRepository.AuthenticateUser(user, password);
        }

        /// <summary>
        /// Obtiene el objeto rol del usuario logeado.
        /// </summary>
        /// <param name="userId">ID del usuario usado en la consulta.</param>
        /// <returns></returns>
        public Rol GetUserRoles(int userId)
        {
            Usuario usuario = _seguridadRepository.Find(userId);
            Rol rol = _rolesRepository.Find(usuario.Rol_Id);
            return rol;
        }
    }
}
