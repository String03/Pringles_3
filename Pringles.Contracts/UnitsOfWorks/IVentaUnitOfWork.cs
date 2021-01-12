using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Contracts.UnitsOfWorks
{
    public interface IVentaUnitOfWork
    {
        /// <summary>
        /// Realiza la venta.
        /// </summary>
        /// <param name="orden">Orden a procesar.</param>
        /// <param name="detallesOrden">La orden a vender.</param>
        /// <param name="registroCaja">Registro de caja que contiene la venta.</param>
        void RealizarVenta(Orden orden, IEnumerable<DetalleOrden> detallesOrden, RegistroCaja registroCaja);
    }
}
