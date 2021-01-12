using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class RegistroCajaBLL
    {
        private readonly IRepository<RegistroCaja> _registroCajaRepository;

        public RegistroCajaBLL(IRepository<RegistroCaja> registroCajaRepository)
        {
            _registroCajaRepository = registroCajaRepository;
        }

    
        public IEnumerable<RegistroCaja> ListarCajas()
        {
            return _registroCajaRepository.GetAll();
        }

        public void AltaRegistroCaja(RegistroCaja registroCaja)
        {
            _registroCajaRepository.Save(registroCaja);
        }

        public void BajaRegistroCaja(RegistroCaja registroCaja)
        {
            _registroCajaRepository.Delete(registroCaja);
        }

        public void ModificarRegistroCaja(RegistroCaja registroCaja)
        {
            _registroCajaRepository.Update(registroCaja);
        }
    }
}
