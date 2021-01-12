using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class FacturaRepository : Repository<Factura>,IFacturaRepository
    {
        public void GuardarFactura(int orden_fk, string factura)
        {
            var facturaNueva = new Factura
            {
               Orden_Fk = orden_fk,
               Texto = factura
               
            };
            Save(facturaNueva);
            

        }

        public IEnumerable<FacturaDTO> ListarFactura()
        {
            string query = CrearQueryBusquedaRapidaFactura();
            var execute = ExecuteSelectStatement<FacturaDTO>(query);
            return execute.AsEnumerable();
        }

        private string CrearQueryBusquedaRapidaFactura()
        {
            string query = @"SELECT F.id,F.texto,o.fecha_reg,cli.nombres,cli.apellido FROM Factura F
            INNER JOIN Orden o
            ON
            F.orden_fk = o.id
            LEFT JOIN Cliente cli
            ON
            o.cliente_fk = cli.id
            ORDER BY o.fecha_reg";
            return query;
        }
    }
}
