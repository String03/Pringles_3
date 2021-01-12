using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class CajaBLL
    {
        private readonly IRepository<Caja> _cajaRepository;


        public CajaBLL(IRepository<Caja> cajaRepository)
        {
            _cajaRepository = cajaRepository;
        }

        /// <summary>
        /// Retorna todas las cajas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Caja> ListarCaja()
        {
            return _cajaRepository.GetAll();
        }

        /// <summary>
        /// Crea una nueva caja
        /// </summary>
        /// <param name="caja"></param>
        public void AltaCaja(Caja caja)
        {
            _cajaRepository.Save(caja);
        }


        /// <summary>
        /// Elimina una caja
        /// </summary>
        /// <param name="caja"></param>
        public void BajaCaja(Caja caja)
        {
            _cajaRepository.Delete(caja);
        }

        /// <summary>
        /// Modifica una caja
        /// </summary>
        /// <param name="caja"></param>
        public void ModificarCaja(Caja caja)
        {
            _cajaRepository.Update(caja);
        }
    }
}
