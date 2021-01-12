using Pringles.Contracts.Repositories;
using Pringles.EE;
using System.Linq;

namespace Pringles.DAL
{
    public class DetalleDescuentoRepository : Repository<DetalleDescuento>, IDetalleDescuentoRepository
    {

        public IQueryable<DetalleDescuento> BuscarDescuentosVigentes()
        {
            string query = "SELECT * FROM DetalleDescuento WHERE FECHA_FIN >= GETDATE() AND ESTATUS = 1";
            return ExecuteSelectStatement(query).AsQueryable();
        }
    }
}
