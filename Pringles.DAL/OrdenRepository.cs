using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class OrdenRepository : Repository<Orden>, IOrdenRepository
    {
        public IEnumerable<Orden> BuscarPedidosCliente(Cliente cliente)
        {
            var resultado = ExecuteSelectStatement($"SELECT * FROM Orden WHERE Cliente_FK = {cliente.Id}");

            foreach (var it in resultado)
            {
                it.DetallesOrdenes = ExecuteSelectStatement<DetalleOrden>($"SELECT * FROM DetalleOrden WHERE Orden_FK = {it.Id}").ToList();
                foreach (var it2 in it.DetallesOrdenes) 
                {
                    it2.Libro = ExecuteSelectStatement<Libro>($"SELECT * FROM Libro WHERE ID = {it2.Libro_Fk}").FirstOrDefault();
                }
            }

            return resultado;
        }
    }
}
