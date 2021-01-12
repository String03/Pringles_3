using Pringles.EE;
using System.Collections.Generic;

namespace Pringles.Contracts.Repositories
{
    public interface ILibroRepository : IRepository<Libro>
    {
        /// <summary>
        /// Busca libros basado en genero y autor.
        /// </summary>
        /// <param name="genero">El genero a utilizar en la consulta.</param>
        /// <param name="autor">El autor a utilizar en la consulta.</param>
        /// <returns></returns>
        IEnumerable<Libro> BuscarLibros(string genero, string autor);

        /// <summary>
        /// Busca un libro por ISBN.
        /// </summary>
        /// <param name="isbn">ISBN utilizado en la consulta.</param>
        /// <returns></returns>
        Libro BuscarLibroPorISBN(string isbn);

        /// <summary>
        /// Busca los libros cuyo stock es menor o igual al criterio de libro.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Libro> BuscarLibrosCriterio();


        /// <summary>
        /// Devuelve los libros con todos sus datos
        /// </summary>
        /// <returns></returns>
        IEnumerable<Libro> BuscarLibros();

        /// <summary>
        /// Retorna el libro más comprado de cada proveedor, si no hay retorna null
        /// </summary>
        /// <returns></returns>
        IEnumerable<ConsultaLibroMasCompraDTO> BuscarLibroMasCompradoPorProveedor();

        /// <summary>
        /// Retorna la mayor compra de cada proveedor
        /// </summary>
        /// <returns></returns>
        IEnumerable<MayorCompraDTO> MayorCompraProveedor();

        /// <summary>
        /// Retorna el menor precio de cada proveedor
        /// </summary>
        /// <returns></returns>
        IEnumerable<MenorPrecioDTO> MenorPrecioProveedores();

        /// <summary>
        /// Retorna las ordenes pendientes.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ComprasPendientesDTO> BuscarComprasPendientes();
    }
}
