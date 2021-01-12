using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class CriterioBLL
    {
        private readonly IRepository<Criterio> _criterioRepository;

        /// <summary>
        /// Crea una instancia de CriterioBLL.
        /// </summary>
        /// <param name="criterioRepository"></param>
        public CriterioBLL(IRepository<Criterio> criterioRepository)
        {
            _criterioRepository = criterioRepository;
        }

        /// <summary>
        /// Guarda un criterio nuevo en la base de datos.
        /// </summary>
        /// <param name="criterio">Criterio nuevo a guardar.</param>
        public void GuardarCriterioNuevo(Criterio criterio)
        {
            try
            {
                _criterioRepository.Save(criterio);
            }
            catch (Exception ex)
            {

                ThrowExceptionCriterio("Error guardando criterio " + ex.Message);
            }
        }

        /// <summary>
        /// Eliminar un criterio.
        /// </summary>
        /// <param name="criterio">Criterio a eliminar.</param>
        public void EliminarCriterio(Criterio criterio)
        {
            try
            {
                Criterio temp = _criterioRepository.Find(criterio.id);
                if (temp == null)
                    ThrowExceptionCriterio("El criterio a eliminar no existe");
                _criterioRepository.Delete(criterio);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Busca todos los criterios de la base datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Criterio> ListarCriterios()
        {
            return _criterioRepository.GetAll();
        }

        /// <summary>
        /// Permite actualizar el criterio
        /// </summary>
        /// <param name="criterio"></param>
        public void ModificarCriterio(Criterio criterio)
        {
            _criterioRepository.Update(criterio);
        }


        private void ThrowExceptionCriterio(string message)
        {
            Exception ex = new Exception(message);
            throw ex;
        }
    }
}
