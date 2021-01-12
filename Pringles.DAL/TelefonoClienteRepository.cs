using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class TelefonoClienteRepository : Repository<TelefonoCliente>,ITelefonoClienteRepository
    {
        public TelefonoClienteDTO BuscarTelefonoCliente(int cliente_id, int telefono_fk)
        {
            string query = CrearQueryBuscarTelefonoCliente();
            var execute = ExecuteSelectStatement<TelefonoClienteDTO>(query, new Dictionary<string, object>
            {
                {
                    "@cliente_fk",cliente_id
                },
                {
                    "@telefono_fk",telefono_fk
                }
            });
            return execute.FirstOrDefault();
        }

        private string CrearQueryBuscarTelefonoCliente()
        {
            string query = @"SELECT tc.id,te.numero,tipo.descripcion FROM TELEFONOCLIENTE tc
                INNER JOIN TELEFONO te
                ON tc.telefono_fk = te.id
                INNER JOIN TipoTelefono tipo
                ON tipo.id = te.tipo_telefono_fk
                WHERE cliente_fk = @cliente_fk and telefono_fk = @telefono_fk";
            return query;
        }
    }
}
