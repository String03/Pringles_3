using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class ProveedorRepository : Repository<Proveedor>, IProveedorRepository
    {
  

      

        public Proveedor BuscarProveedorPorCuil(string cuil)
        {
            string query = CrearQueryBusquedaCuil();
            IDictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("@CUIL", cuil);

            return ExecuteSelectStatement(query, parametros).FirstOrDefault();
        }

        public IEnumerable<MayorRapidezDTO> BuscarProveedorMayorRapidez()
        {
            string query = CrearQueryBusquedaRapidezProveedor();
            var execute = ExecuteSelectStatement<MayorRapidezDTO>(query);
            return execute.AsEnumerable();
        }

        private string CrearQueryBusquedaRapidezProveedor()
        {
            string query = @"SELECT sub.razon_social,avg(sub.diferenciadias) diferencia_dias from
            (SELECT pro.razon_social, DATEDIFF(DAY,com.fecha_reg,com.fecha_de_recepcion) diferenciadias FROM Compra com
            INNER JOIN DetalleCompra det
            ON com.id = det.compras_fk
            INNER JOIN Libro li
            ON li.id = det.libro_fk
            INNER JOIN Proveedor pro
            ON pro.id = li.proveedor_fk
            WHERE com.fecha_de_recepcion is not null AND com.recibido = 1) sub
            group by sub.razon_social
            ORDER BY 2";
            return query;
        }

        private string CrearQueryBusquedaCuil()
        {
            return @"SELECT * FROM Proveedor WHERE CUIL = @CUIL";
        }

        

    }
}
