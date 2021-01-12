using System.Linq;

namespace Pringles.Contracts.Repositories
{
    /// <summary>
    /// Interfaz utilizada para trabajar con los datos del patrón de diseño repository. Se utiliza para el crud
    /// </summary>
    /// <typeparam name="T">Génerico a utilizar en el repository</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Retorna listado de todos los elementos del repository.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
        
        /// <summary>
        /// Guarda una entidad en el repository.
        /// </summary>
        /// <param name="entity">Entidad a guardar</param>
        void Save(T entity);

        /// <summary>
        /// Actualiza una entidad en el repository.
        /// </summary>
        /// <param name="entity">Entidad a actualizar</param>
        void Update(T entity);

        /// <summary>
        /// Elimina una entidad en el respository
        /// </summary>
        /// <param name="entity">Entidad a eliminar</param>
        void Delete(T entity);

        /// <summary>
        /// Busca una entidad en específico
        /// </summary>
        /// <param name="id">Valor a utilizar en la consulta</param>
        /// <returns></returns>
        T Find(params object[] id); 
    }
}
