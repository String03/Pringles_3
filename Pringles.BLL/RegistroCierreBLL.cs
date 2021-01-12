using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class RegistroCierreBLL
    {
        private readonly IRepository<RegistroCierre> _registroCierreRepository;

        public RegistroCierreBLL(IRepository<RegistroCierre> registroCierreRepository)
        {
            _registroCierreRepository = registroCierreRepository;
        }

        public IEnumerable<RegistroCierre> ListarRegistroCierres()
        {
            return _registroCierreRepository.GetAll();
        }

        public void AltaRegistroCierre(RegistroCierre registroCierre)
        {
            _registroCierreRepository.Save(registroCierre);
        }

        public void BajaRegistroCierre(RegistroCierre registroCierre)
        {
            _registroCierreRepository.Delete(registroCierre);
        }

        public void ModificarRegistroCierre(RegistroCierre registroCierre)
        {
            _registroCierreRepository.Update(registroCierre);
        }
    }
}
