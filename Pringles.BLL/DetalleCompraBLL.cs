using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class DetalleCompraBLL
    {
        private readonly IRepository<DetalleCompra> _detalleCompraRepository;

        public DetalleCompraBLL(IRepository<DetalleCompra> detalleCompraRepository)
        {
            _detalleCompraRepository = detalleCompraRepository;
        }

        public void GuardarDetalleCompraNuevo(DetalleCompra detalleCompra)
        {
            try
            {
                _detalleCompraRepository.Save(detalleCompra);
            }
            catch (Exception ex)
            {

                ThrowExceptionDetalleCompra("Error guardando detalle de la compra " + ex.Message);
            }
        }

        private void ThrowExceptionDetalleCompra(string message)
        {
            Exception ex = new Exception(message);
            throw ex;
        }

        public void EliminarDetalleCompraNuevo(DetalleCompra detalleCompra)
        {
            try
            {
                DetalleCompra temp = _detalleCompraRepository.Find(detalleCompra.Id);
                if (temp == null)
                    ThrowExceptionDetalleCompra("El detalle de la compra a eliminar no existe");
                _detalleCompraRepository.Delete(detalleCompra);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<DetalleCompra> ListarDetalleCompras()
        {
            return _detalleCompraRepository.GetAll();
        }

        public void ModificarDetalleCompra(DetalleCompra detalleCompra)
        {
            _detalleCompraRepository.Update(detalleCompra);
        }

    }
}
