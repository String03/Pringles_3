using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class OrdenBLL
    {
        private readonly IRepository<Orden> _ordenRepository;

        public OrdenBLL(IRepository<Orden> ordenRepository)
        {
            _ordenRepository = ordenRepository;
        }

       
        public IEnumerable<Orden> ListarOrdenes()
        {
            return _ordenRepository.GetAll();
        }

        public void AltaOrdenes(Orden orden)
        {
            _ordenRepository.Save(orden);
        }

        public void BajaOrdenes(Orden orden)
        {
            _ordenRepository.Delete(orden);
        }

        public void ModificarOrdenes(Orden orden)
        {
            _ordenRepository.Update(orden);
        }
    }
}
