using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Pringles.Contracts.Repositories;
using Pringles.Contracts.ClassMappers;
using Pringles.MPP;
using Pringles.Utilities.Factories;
using Pringles.Utilities.Extensions;
using System.Collections.Generic;

namespace Pringles.DAL
{
    public class Repository<T> : IRepository<T>
    {
        public virtual void Save(T entity)
        {
            string query = CreateInsertQuery(entity);
            ExecuteNonQueryStatement(query);
        }

        public virtual void Delete(T entity)
        {
            string query = CreateDeleteQuery(entity);
            ExecuteNonQueryStatement(query);
        }

        public virtual T Find(params object[] id)
        {
            int idParam;
            try { int.TryParse(id[0].ToString(), out idParam); } catch { idParam = 0; }
            string query = CreateSelectQuery() + " WHERE 1 = 1 AND ID = " + $"{idParam}";
            return ExecuteSelectStatement<T>(query).FirstOrDefault();
        }

        public virtual IQueryable<T> GetAll()
        {
            string query = CreateSelectQuery();
            return ExecuteSelectStatement<T>(query);
        }

        /// <summary>
        /// Método que facilita la ejecución de un query de select
        /// </summary>
        /// <typeparam name="Q">Es el tipo que quiero mapear</typeparam>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected virtual IQueryable<Q> ExecuteSelectStatement<Q>(string query, IDictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                IDbCommand command = GetDbCommand(query, connection);

                if (parameters != null) 
                {
                    foreach (var it in parameters)
                    {
                        IDbDataParameter parameter = command.CreateParameter();//Agregar parámetros al query
                        parameter.ParameterName = it.Key;//Es el hash de hashtable, el string
                        parameter.Value = it.Value;
                        command.Parameters.Add(parameter);
                    }
                }

                IDbDataAdapter sqlDataAdapter = GetDataAdapter(command);
                return FetchData<Q>(sqlDataAdapter);
            }
        }

        /// <summary>
        /// Método que facilita la ejecución de un query de select
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected virtual IQueryable<T> ExecuteSelectStatement(string query, IDictionary<string, object> parameters = null) 
        {
            return ExecuteSelectStatement<T>(query, parameters);//Genera un ExecuteSelectStatement genérico para el genérico de la clase
        }

        /// <summary>
        /// Método utilizado para ejecutar queries sin esperar el resultado
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        protected virtual void ExecuteNonQueryStatement(string query, IDictionary<string, object> parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                IDbCommand command = GetDbCommand(query, connection);

                if (parameters != null) 
                {
                    foreach (KeyValuePair<string, object> it in parameters)
                    {
                        IDbDataParameter parameter = command.CreateParameter();
                        parameter.ParameterName = it.Key;
                        parameter.Value = it.Value;
                        command.Parameters.Add(parameter);
                    }
                }

                command.ExecuteNonQuery();
            }
        }

        protected virtual IDbCommand GetDbCommand(string query, IDbConnection connection)
        {
            return new SqlCommand(query, (SqlConnection)connection);
        }

        //protected virtual IDbDataAdapter GetDataAdapter(string query, IDbConnection connection)
        //{
        //    return new SqlDataAdapter(query, (SqlConnection)connection);
        //}

        protected virtual IDbDataAdapter GetDataAdapter(IDbCommand command)
        {
            return new SqlDataAdapter((SqlCommand)command);
        }

        /// <summary>
        /// Encapsula la ejecución del query (ADO desconectado)
        /// </summary>
        /// <typeparam name="Q"></typeparam>
        /// <param name="dbDataAdapter"></param>
        /// <returns></returns>
        protected virtual IQueryable<Q> FetchData<Q>(IDbDataAdapter dbDataAdapter) //Q es el genérico propio de esta clase
        {
            DataSet dataSet = new DataSet();
            IClassMapper<Q> classMapper = new ClassMapper<Q>();
            dbDataAdapter.Fill(dataSet);
            return classMapper.Map(dataSet).AsQueryable<Q>();
        }

        /// <summary>
        /// Crea el query SELECT del tipo T.
        /// </summary>
        /// <returns></returns>
        protected virtual string CreateSelectQuery()
        {
            return $"SELECT {typeof(T).GetTableColumns()} FROM " + typeof(T).Name;
        }

        /// <summary>
        /// Crea el query INSERT del tipo T
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected virtual string CreateInsertQuery(T entity)
        {
            return CreateInsertQuery<T>(entity);
        }

        /// <summary>
        /// Crea el query INSERT del tipo Q
        /// </summary>
        /// <typeparam name="Q">generic distinto al generic de la clase</typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected virtual string CreateInsertQuery<Q>(Q entity)
        {
            return $"INSERT INTO {typeof(Q).Name} ({typeof(Q).GetInsertableColumns()}) VALUES ({entity.GetInsertableColumnsValues()})"; //entity es para tener los valores de la instancia
        }

        /// <summary>
        /// Crea el query de insert preparado para devolver el id (para asociar detalleOrden con Orden)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected virtual string CreateInsertQueryOutputId(T entity)
        {
            return CreateInsertQueryOutputId<T>(entity);
        }

        protected virtual string CreateInsertQueryOutputId<Q>(Q entity)
        {
            return $"INSERT INTO {typeof(Q).Name} ({typeof(Q).GetInsertableColumns()}) OUTPUT INSERTED.ID VALUES ({entity.GetInsertableColumnsValues()})"; //entity es para tener los valores de la instancia
        }

        /// <summary>
        /// Devuelve el query de DELETE
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected virtual string CreateDeleteQuery(T entity)
        {
            return $"DELETE FROM {typeof(T).Name} WHERE 1=1 AND {entity.GetPrimaryKeyComparator()}"; //1=1 para luego poder agregar AND
        }

       
        public virtual void Update(T entity)
        {
            string query = CreateUpdateQuery(entity);
            ExecuteNonQueryStatement(query);
        }

        /// <summary>
        /// Devuelve el query de UPDATE del tipo T
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected virtual string CreateUpdateQuery(T entity)
        {
            return $"UPDATE {typeof(T).Name} SET {entity.GetUpdatableColumnsValues()} WHERE 1 = 1 AND {entity.GetPrimaryKeyComparator()}";
        }

        /// <summary>
        /// Retorna la colección predeterminada del sistema.
        /// </summary>
        /// <returns></returns>
        protected virtual IDbConnection GetConnection()
        {
            return ConnectionFactory.CreatePringlesMainConnection();
        }

    }
}
