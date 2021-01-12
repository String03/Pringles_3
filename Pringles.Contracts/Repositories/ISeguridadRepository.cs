using Pringles.EE;

namespace Pringles.Contracts.Repositories
{
    public interface ISeguridadRepository : IRepository<Usuario>
    {
        /// <summary>
        /// Revisa si la tabla esta vacia.
        /// </summary>
        /// <returns></returns>
        bool CheckUserExists();

        /// <summary>
        /// Crea un usuario por con poder de administrador por default.
        /// </summary>
        void CreateDefaultAdmin();

        /// <summary>
        /// Autentica a un usuario para permitir dejarlo pasar.
        /// </summary>
        /// <param name="username">Usuario a utilizar en el login.</param>
        /// <param name="password">Credencial a utilizar para el login.</param>
        /// <returns></returns>
        bool AuthenticateUser(string username, string password);

        /// <summary>
        /// Actualiza las credenciales de un usuario.
        /// </summary>
        /// <param name="username">Usuario a utilizar en el login.</param>
        /// <param name="oldPassword">Credencial vieja a utilizar para autenticar.</param>
        /// <param name="newPassword">Credencial nueva a utilizar para cambiar la vieja.</param>
        void UpdateUserPassword(string username, string oldPassword, string newPassword);
    }
}
