using Pringles.Contracts.Repositories;
using Pringles.EE;
using Pringles.Utilities;
using Pringles.Utilities.Consts;
using System.Collections.Generic;
using System.Linq;

namespace Pringles.DAL
{
    public class SeguridadRepository : Repository<Usuario>, ISeguridadRepository
    {
        private const string DEFAULT_USER = "ADMIN";
        private const string DEFAULT_EMPLOYEE_CODE = "ADMIN";
        private const string DEFAULT_PASSWORD = "ADMIN";
        private const int DEFAULT_ROLE = UserRoles.ADMIN;

        public bool AuthenticateUser(string username, string password)
        {
            string query = CreateLoginQuery();
            var parameters = new Dictionary<string, object>
            {
                { "@NOMBRE_USUARIO", username },
                { "@CONTRASENIA", MD5PasswordHash.HashPassword(password) }
            };
            return ExecuteSelectStatement(query, parameters).Count() > 0;
        }

        private string CreateLoginQuery()
        {
            return "SELECT ID FROM USUARIO WHERE UPPER(NOMBRE_USUARIO) = UPPER(@NOMBRE_USUARIO) AND CONTRASENIA = @CONTRASENIA";
        }

        public bool CheckUserExists()
        {
            string query = CreateCheckUsersExistsQuery();
            var result = ExecuteSelectStatement(query);
            return result.Count() > 0;
        }

        public void CreateDefaultAdmin()
        {
            string query = CreateCreateDefaultUserQuery();
            IDictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "@NOMBRES", DEFAULT_USER },
                { "@APELLIDO", DEFAULT_USER },
                { "@NOMBRE_USUARIO", DEFAULT_USER },
                { "@CONTRASENIA", MD5PasswordHash.HashPassword(DEFAULT_PASSWORD) },
                { "@ROL_ID", DEFAULT_ROLE },
                { "@CODIGO_EMPLEADO", DEFAULT_EMPLOYEE_CODE }
            };
            ExecuteNonQueryStatement(query, parameters);
        }

        private string CreateCreateDefaultUserQuery()
        {
            return $"INSERT INTO USUARIO(CODIGO_EMPLEADO, NOMBRES, APELLIDO, NOMBRE_USUARIO, CONTRASENIA, ROL_ID, CAJA_FK) VALUES(@CODIGO_EMPLEADO, @NOMBRES, @APELLIDO, @NOMBRE_USUARIO, @CONTRASENIA, @ROL_ID, (SELECT TOP 1 ID FROM CAJA))";
        }

        public void UpdateUserPassword(string username, string oldPassword, string newPassword)
        {
            string query = CreateUpdatePasswordQuery();
            var parameters = new Dictionary<string, object>
            {
                { "@NOMBRE_USUARIO", username },
                { "@CONTRASENIA_VIEJA", MD5PasswordHash.HashPassword(oldPassword) },
                { "@CONTRASENIA_NUEVA", MD5PasswordHash.HashPassword(newPassword) }
            };
            ExecuteNonQueryStatement(query, parameters);
        }

        private string CreateUpdatePasswordQuery()
        {
            return "UPDATE USUARIO SET CONTRASENIA = @CONTRASENIA_NUEVA WHERE UPPER(NOMBRE_USUARIO) = UPPER(@NOMBRE_USUARIO) AND CONTRASENIA = @CONTRASENIA_VIEJA";
        }

        private string CreateCheckUsersExistsQuery()
        {
            return "SELECT ID FROM USUARIO";
        }
    }
}
