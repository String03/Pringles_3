using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class TelefonoRepository : Repository<Telefono>, ITelefonoRepository
    {
        public IEnumerable<TelefonoDTO> BuscarTelefono(string numero)
        {
            string query = CrearQueryBuscarTelefono();
            var execute = ExecuteSelectStatement<TelefonoDTO>(query,new Dictionary<string,object> { {"@numero",numero } });
            return execute.ToList();
        }

        private string CrearQueryBuscarTelefono()
        {
            string query = @"SELECT top 50 te.id,te.numero,tipo.descripcion FROM TELEFONO te
                INNER JOIN TIPOTELEFONO tipo
                ON te.tipo_telefono_fk = tipo.id
                WHERE te.numero like @numero + '%'";
            return query;
        }

        public IEnumerable<TelefonoClienteDTO> BuscarTelefonoCliente(int cliente_id)
        {
            var ejecutar = ExecuteSelectStatement<TelefonoClienteDTO>(@"SELECT tc.id, te.numero, tipo.descripcion FROM TELEFONOCLIENTE tc
                INNER JOIN TELEFONO te
                ON tc.telefono_fk = te.id
                INNER JOIN TipoTelefono tipo
                ON tipo.id = te.tipo_telefono_fk where cliente_fk =" + cliente_id);
            //foreach (var telefono in ejecutar)
            //{
            //    telefono.TipoTelefono = ExecuteSelectStatement<TipoTelefono>(@"SELECT * FROM TipoTelefono where id = " + telefono.Tipo_telefono_fk).FirstOrDefault();
            //}
            return ejecutar.ToList();
        }

    }
}
