using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.UnitsOfWorks
{
    public interface ICompraUnitOfWork
    {
        /// <summary>
        /// Realiza la compra a proveedor
        /// </summary>
        /// <param name="compra"></param>
        /// <param name="detallesCompra"></param>
        void RealizarCompra(Compra compra, IEnumerable<DetalleCompra> detallesCompra);
    }
}
