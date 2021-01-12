using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL
{
    public class CompraRepository : Repository<Compra>, ICompraRepository
    {   

        public IEnumerable<Compra> BuscarPedidosProveedor(Proveedor proveedor)
        {
            var resultado = ExecuteSelectStatement($"SELECT * FROM Compra WHERE Proveedor_FK = {proveedor.Id}");

            foreach (var it in resultado)
            {
                it.DetallesCompra = ExecuteSelectStatement<DetalleCompra>($"SELECT * FROM DetalleCompra WHERE Compras_FK = {it.Id}").ToList();
                foreach (var it2 in it.DetallesCompra)
                {
                    it2.Libro = ExecuteSelectStatement<Libro>($"SELECT * FROM Libro WHERE ID = {it2.Libro_Fk}").FirstOrDefault();
                }
            }

            return resultado;
        }
    }
}
