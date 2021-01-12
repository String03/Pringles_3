using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class LibroBLL 
    {
        private readonly ILibroRepository _libroRepository;

        public LibroBLL(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;
        }

        /// <summary>
        /// Devuelve todos los libros
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Libro> ListarLibros()
        {
            return _libroRepository.BuscarLibros();
        }

        /// <summary>
        /// Crea libros nuevos
        /// </summary>
        /// <param name="libro"></param>
        public void AltaLibros(Libro libro)
        {
            _libroRepository.Save(libro);
        }

        /// <summary>
        /// Elimina el registro de libro del inventario
        /// </summary>
        /// <param name="libro"></param>
        public void BajaLibros(Libro libro)
        {
            _libroRepository.Delete(libro);
        }

        /// <summary>
        /// Permite actualizar un libro
        /// </summary>
        /// <param name="libro"></param>
        public void ModificarLibros(Libro libro)
        {
            _libroRepository.Update(libro);
        }

        /// <summary>
        /// Busca los libros cuyo stock es menor o igual al criterio de libro.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Libro> BuscarLibrosCriterio() 
        {
            return _libroRepository.BuscarLibrosCriterio();
        }

      
        public IEnumerable<Libro> BuscarLibros(string genero, string autor)
        {
            return _libroRepository.BuscarLibros(genero, autor);
        }

        /// <summary>
        /// Busca un libro por ISBN.
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public Libro BuscarLibroPorISBN(string isbn)
        {
            return _libroRepository.BuscarLibroPorISBN(isbn);
        }

        public IEnumerable<Libro> BuscarLibros()
        {
            return _libroRepository.BuscarLibros();
        }

        public IQueryable<Libro> GetAll()
        {
            return _libroRepository.GetAll();
        }

        public void Save(Libro entity)
        {
            _libroRepository.Save(entity);
        }

        public void Update(Libro entity)
        {
            _libroRepository.Update(entity);
        }

        public void Delete(Libro entity)
        {
            _libroRepository.Delete(entity);
        }

        public Libro Find(params object[] id)
        {
            return _libroRepository.Find(id);
        }

        /// <summary>
        /// Retorna el libro más comprado de cada proveedor, si no hay retorna null
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ConsultaLibroMasCompraDTO> BuscarLibroMasCompradoPorProveedor()
        {
            return _libroRepository.BuscarLibroMasCompradoPorProveedor();
        }

        /// <summary>
        /// Retorna la mayor compra de cada proveedor
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MayorCompraDTO> MayorCompraProveedor()
        {
            return _libroRepository.MayorCompraProveedor();
        }

        /// <summary>
        /// Retorna el menor precio de cada proveedor
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MenorPrecioDTO> MenorPrecioProveedores()
        {
            return _libroRepository.MenorPrecioProveedores();
        }

      
        public IEnumerable<ComprasPendientesDTO> BuscarComprasPendientes()
        {
            return _libroRepository.BuscarComprasPendientes();
        }
    }
}
