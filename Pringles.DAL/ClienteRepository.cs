using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente BuscarClientePorDni(string dni)
        {
            string query = CrearQueryBusquedaDni();
            IDictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("@DNI", dni);

            return ExecuteSelectStatement(query, parametros).FirstOrDefault();
        }

        public Cliente BuscarMejorCliente()
        {
            try
            {
                string query = @"SELECT cliente.*
                    FROM   cliente cliente
                           INNER JOIN (SELECT cli.id, 
                                              Count(*) cantidad_cliente
                                              
                                       FROM   detalleorden do 
                                              INNER JOIN libro lib 
                                                      ON do.libro_fk = lib.id 
                                              inner join Orden o
                                                    on o.id = do.orden_fk
                                                inner join Cliente cli
                                                    on o.cliente_fk = cli.id
                                       GROUP  BY cli.id) cliente_cantidad 
                                   ON cliente.id = cliente_cantidad.id 
                    ORDER  BY cliente_cantidad.cantidad_cliente DESC  ";
                return ExecuteSelectStatement(query).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        private string CrearQueryBusquedaDni()
        {
            return @"SELECT * FROM Cliente WHERE DNI = @DNI";
        }
    }
}
