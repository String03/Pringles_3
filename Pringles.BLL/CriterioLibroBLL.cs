using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class CriterioLibroBLL
    {
        private readonly IRepository<CriterioLibro> _criterioLibroRepository;

        public CriterioLibroBLL(IRepository<CriterioLibro> criterioLibroRepository)
        {
            _criterioLibroRepository = criterioLibroRepository;
        }

       
        public IEnumerable<CriterioLibro> ListarCriterioLibros()
        {
            return _criterioLibroRepository.GetAll();
        }

        public void AltaCriterioLibro(CriterioLibro criterioLibro)
        {
            _criterioLibroRepository.Save(criterioLibro);
        }

      
        public void BajaCriterioLibro(CriterioLibro criterioLibro)
        {
            _criterioLibroRepository.Delete(criterioLibro);
        }

     
        public void ModificarCriterioLibro(CriterioLibro criterioLibro)
        {
            _criterioLibroRepository.Update(criterioLibro);
        }
    }
}
