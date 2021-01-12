using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;

namespace Pringles.DAL.Singletons
{
    public class CurrentUser
    {
        private static CurrentUser _instance;
        private readonly IRolesRepository _rolesRepository;

        private Rol _rol;
        private Usuario _usuario;

        public Rol Rol { get => _rol; }

        public Usuario Usuario { get => _usuario; }

        private CurrentUser(IRolesRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        public static CurrentUser GetCurrentInstance() 
        {
            if (_instance == null)
                _instance = new CurrentUser(new RolesRepository());

            return _instance;
        }

        public void SetRole(int roleId) 
        {
            Rol rol = _rolesRepository.Find(roleId);
            if (rol == null)
                throw new Exception("No se pudo asignar rol al usuario.");
            _rol = rol;
        }

        public void SetRole(Usuario user)
        {
            SetRole(user.Rol_Id.GetValueOrDefault());
        }

        public void SetUser(Usuario usuario) 
        {
            _usuario = usuario;
        }
    }
}
