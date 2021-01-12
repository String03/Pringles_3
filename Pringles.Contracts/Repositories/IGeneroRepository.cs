using Pringles.EE;

namespace Pringles.Contracts.Repositories
{
    public interface IGeneroRepository : IRepository<Genero>
    {
        /// <summary>
        /// Busca el genero con la mayor cantidad de ventas.
        /// </summary>
        /// <returns>Devuelve un género literario</returns>
        Genero BuscarGeneroMasVendido();

        /// <summary>
        /// Busca el genero con la mayor cantidad de ventas de un cliente.
        /// </summary>
        /// <param name="cliente">Cliente a consultar</param>
        /// <returns>Devuelve un género literario</returns>
        Genero BuscarGeneroMasVendido(Cliente cliente);

        /// <summary>
        /// Busca el género más comprado al proveedor.
        /// </summary>
        /// <returns>Devuelve un género literario</returns>
        Genero BuscarGeneroMasVendidoPorProveedor();

        /// <summary>
        /// Busca el género más comprado al proveedor
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns>Devuelve un género literario</returns>
        Genero BuscarGeneroMasVendidoPorProveedor(Proveedor proveedor);
    }
}
