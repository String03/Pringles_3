using Pringles.Utilities.Consts;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Pringles.Utilities.Factories
{
    /// <summary>
    /// Clase static que se encarga de crear conexiones.
    /// </summary>
    public static class ConnectionFactory
    {
        /// <summary>
        /// Devuelve una conexión para el connectionstring "PringlesDB" Se puede poner también una conexión distinta
        /// </summary>
        /// <returns></returns>
        public static IDbConnection CreatePringlesMainConnection() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings[Connections.PRINGLE_DB].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
