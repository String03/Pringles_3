using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class CompraBLL
    {
        private readonly IRepository<Compra> _compraRepository;

        public CompraBLL(IRepository<Compra> compraRepository)
        {
            _compraRepository = compraRepository;
        }

     
        public void GuardarCompra(Compra compra)
        {
            try
            {
                _compraRepository.Save(compra);
            }
            catch (Exception ex)
            {

                ThrowExceptionCompra("Error guardando compra " + ex.Message);
            }
        }

        public void EliminarCompra(Compra compra)
        {
            try
            {
                Compra temp = _compraRepository.Find(compra.Id);
                if (temp == null)
                    ThrowExceptionCompra("La compra a eliminar no existe");
                _compraRepository.Delete(compra);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Compra> ListarCompras()
        {
            return _compraRepository.GetAll();
        }

        public void ModificarCompra(Compra compra)
        {
            _compraRepository.Update(compra);
        }

        private void ThrowExceptionCompra(string message)
        {
            Exception ex = new Exception(message);
            throw ex;
        }
    }
}
