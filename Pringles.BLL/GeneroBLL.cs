using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class GeneroBLL
    {
        private readonly IRepository<Genero> _generoRepository;

        public GeneroBLL(IRepository<Genero> generoRepository)
        {
            _generoRepository = generoRepository;
        }

        /// <summary>
        /// Retorna los generos de los libros
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Genero> ListarGeneros()
        {
            return _generoRepository.GetAll();
        }

        /// <summary>
        /// Guarda un género en la base de datos
        /// </summary>
        /// <param name="genero"></param>
        public void AltaGenero(Genero genero)
        {
            _generoRepository.Save(genero);
        }

        /// <summary>
        /// Elimina un género
        /// </summary>
        /// <param name="genero"></param>
        public void BajaGenero(Genero genero)
        {
            _generoRepository.Delete(genero);
        }

        /// <summary>
        /// Modifica el género seleccionado
        /// </summary>
        /// <param name="genero"></param>
        public void ModificarGenero(Genero genero)
        {
            _generoRepository.Update(genero);
        }
    }
}
