using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class DetalleOrdenBLL
    {
        private readonly IRepository<DetalleOrden> _detalleOrdenRepository;

        public DetalleOrdenBLL(IRepository<DetalleOrden> detalleOrdenRepository)
        {
            _detalleOrdenRepository = detalleOrdenRepository;
        }

       
        public IEnumerable<DetalleOrden> ListarDetalleOrdenes()
        {
            return _detalleOrdenRepository.GetAll();
        }

        public void AltaDetalleOrden(DetalleOrden detalleOrden)
        {
            _detalleOrdenRepository.Save(detalleOrden);
        }

        public void BajaDetalleOrden(DetalleOrden detalleOrden)
        {
            _detalleOrdenRepository.Delete(detalleOrden);
        }

        public void ModificarDetalleOrden(DetalleOrden detalleOrden)
        {
            _detalleOrdenRepository.Update(detalleOrden);
        }
    }
}
