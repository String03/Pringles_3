using System.Collections.Generic;
using System.Data;

namespace Pringles.Contracts.ClassMappers
{
    /// <summary>
    /// Interfaz a utilizar para transformar el resultado de una consulta en una colección de T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IClassMapper<T>
    {
        /// <summary>
        /// Mapea un dataset a un Ienumerable de T. Se usa para ADO desconectado junto con DataAdapter.
        /// </summary>
        /// <param name="dataSet">Dataset a transformar</param>
        /// <returns>IEnumerable de tipo T</returns>
        IEnumerable<T> Map(DataSet dataSet);
    }
}
