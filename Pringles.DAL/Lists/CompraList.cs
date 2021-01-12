using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.DAL.Lists
{
    /// <summary>
    /// Clase para manejar el listado de compras de libros.
    /// </summary>
    public class CompraList : List<DetalleCompra>, IList<DetalleCompra>
    {
        /// <summary>
        /// Agrega un registro de detalle compra. Si el libro ya existe le aumenta la cantidad que está a la venta.
        /// </summary>
        /// <param name="detalleCompra"></param>
        public new void Add(DetalleCompra detalleCompra)
        {
            if (Contains(detalleCompra))
            {
                int index = FindIndex(x => x.Equals(detalleCompra));
                if (index < 0)
                    base.Add(detalleCompra);
                else
                {
                    this[index].Cantidad += detalleCompra.Cantidad;
                }
            }
            else
            {
                base.Add(detalleCompra);
            }
        }
    }
}
