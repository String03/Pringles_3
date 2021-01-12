using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Pringles.DAL
{
    public class CajaRepository : Repository<Caja>, ICajaRepository
    {
        public Caja BuscarCajaPorNombre(string nombreCaja)
        {
            string query = "SELECT * FROM CAJA WHERE UPPER(DESCRIPCION) = UPPER(@DESCRIPCION)";
            IDictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("@DESCRIPCION", nombreCaja);
            return ExecuteSelectStatement(query, parametros).FirstOrDefault();
        }

        public void CrearCajaDefault()
        {
            string hostname = Environment.MachineName;
            var caja = new Caja
            {
                Descripcion = hostname
            };
            Save(caja);
        }

        public bool RevisarRegistrosCaja()
        {
            string hostname = Environment.MachineName;
            Caja caja = BuscarCajaPorNombre(hostname);
            return caja != null;
        }
    }
}
