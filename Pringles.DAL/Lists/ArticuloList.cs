using Pringles.EE;
using System.Collections.Generic;

namespace Pringles.DAL.Lists
{
    /// <summary>
    /// Clase para manejar el listado de ventas de libros.
    /// </summary>
    public class ArticuloList : List<DetalleOrden>, IList<DetalleOrden>
    {
        /// <summary>
        /// Agrega un registro de detalle orden. Si el libro ya existe, le aumenta
        /// la cantidad que esta a la venta.
        /// </summary>
        /// <param name="detalleOrden"></param>
        public new void Add(DetalleOrden detalleOrden)
        {
            if (Contains(detalleOrden))
            {
                //FindIndex se usa para tener el índice de un elemento de una lista
                int index = FindIndex(x => x.Equals(detalleOrden));
                if (index < 0)
                    base.Add(detalleOrden);
                else
                {
                    this[index].Cantidad += detalleOrden.Cantidad;
                }
            }
            else
            {
                base.Add(detalleOrden);
            }
        }
    }
}
