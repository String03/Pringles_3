using Pringles.EE;
using System.Linq;

namespace Pringles.Contracts.Repositories
{
    public interface IDetalleDescuentoRepository : IRepository<DetalleDescuento>
    {
        /// <summary>
        /// Busca los descuentos que se encuentran vigentes
        /// </summary>
        /// <returns>IQueryable de Detalle Descuento</returns>
        IQueryable<DetalleDescuento> BuscarDescuentosVigentes();
    }
}
