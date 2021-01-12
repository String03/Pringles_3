using Pringles.EE;

namespace Pringles.Contracts.Repositories
{
    public interface ICajaRepository : IRepository<Caja>
    {
        /// <summary>
        /// Revisa si existe por lo menos un registro de caja.
        /// </summary>
        /// <returns></returns>
        bool RevisarRegistrosCaja();

        /// <summary>
        /// Crea una caja por default.
        /// </summary>
        void CrearCajaDefault();

        /// <summary>
        /// Busca una caja por nombre.
        /// </summary>
        /// <param name="nombreCaja">Nombre de la caja a utilizar en la consulta.</param>
        /// <returns></returns>
        Caja BuscarCajaPorNombre(string nombreCaja);
    }
}
