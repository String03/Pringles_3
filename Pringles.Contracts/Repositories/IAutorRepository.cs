using Pringles.EE;

namespace Pringles.Contracts.Repositories
{
    public interface IAutorRepository: IRepository<Autor>
    {
        /// <summary>
        /// Retorna el autor con mas ventas.
        /// </summary>
        /// <returns></returns>
        Autor BuscarAutorMasVendido();

        /// <summary>
        /// Retorna el autor con mas ventas de un cliente.
        /// </summary>
        /// <param name="cliente">Cliente a consultar</param>
        /// <returns></returns>
        Autor BuscarAutorMasVendido(Cliente cliente);

        /// <summary>
        /// Se encarga de buscar el autor más vendido por el proveedor.
        /// </summary>
        /// <returns>devuelve un autor</returns>
        Autor BuscarAutorMasVendidoPorProveedor();

        /// <summary>
        /// Se encarga de buscar el autor más vendido por el proveedor.
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns>devuelve un proveedor</returns>
        Autor BuscarAutorMasVendidoPorProveedor(Proveedor proveedor);
    }
}
