using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;

namespace Pringles.BLL
{
    public class AutorBLL
    {
        private readonly IRepository<Autor> _autorRepository;

        /// <summary>
        /// Crea una instancia de AutorBLL.
        /// </summary>
        /// <param name="autorRepository"></param>
        public AutorBLL(IRepository<Autor> autorRepository)
        {
            _autorRepository = autorRepository;
        }

        /// <summary>
        /// Guarda un autor nuevo en la base de datos.
        /// </summary>
        /// <param name="autor">Autor nuevo a guardar.</param>
        public void GuardarAutorNuevo(Autor autor)
        {
            try
            {
                _autorRepository.Save(autor);
            }
            catch (Exception ex)
            {
                ThrowExceptionAutor("Error guardando autor " + ex.Message);
            }
        }

        /// <summary>
        /// Eliminar un autor.
        /// </summary>
        /// <param name="autor">Autor a eliminar.</param>
        public void EliminarAutor(Autor autor) 
        {
            try
            {
                Autor temp = _autorRepository.Find(autor.Id);
                if (temp == null)
                    ThrowExceptionAutor("El autor a eliminar no existe");
                _autorRepository.Delete(autor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Modifica el autor seleccionado
        /// </summary>
        /// <param name="autor"></param>
        public void ModificarAutor(Autor autor)
        {
            _autorRepository.Update(autor);
        }

        /// <summary>
        /// Lista los libros mas vendidos de un autor.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Libro> ListarLibrosMasVendidos(Autor autor)
        {
            return null;
        }

        /// <summary>
        /// Busca todos los autores de la base datos.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Autor> ListarAutores() 
        {
            return _autorRepository.GetAll();
        }

     
        private void ThrowExceptionAutor(string message)
        {
            Exception ex = new Exception(message);
            throw ex;
        }
    }
}
