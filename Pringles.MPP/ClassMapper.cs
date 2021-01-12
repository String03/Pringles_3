using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using Pringles.Contracts.ClassMappers;
using Pringles.Utilities.Attributes;

namespace Pringles.MPP
{
    public class ClassMapper<T> : IClassMapper<T>
    {
        public IEnumerable<T> Map(DataSet dataSet)
        {
            List<T> result = new List<T>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                object instance = Activator.CreateInstance(typeof(T));//Activator es otra forma de declarar una instancia
                //instance = new T();
                var properties = instance.GetType().GetProperties();//Para obtener las propiedades

                foreach (var prop in properties)
                {
                    // Si tiene TransientColumn, entonces se ignora la propiedad.
                    // GetCustomAttributes se utiliza para obtener los atributos que pueda tener una propiedad (transientcolumn,table,keytable).
                    if (prop.GetCustomAttributes().Any(a => a.GetType() == typeof(TransientColumnAttribute)))
                        continue;

                    
                    object col = GetRowValue(row, prop);
                    prop.SetValue(instance, col);
                }

                result.Add((T)instance);
            }

            return result;
        }

        private object GetRowValue(DataRow row, PropertyInfo prop)
        {
            try
            {
                object result = row[prop.Name];
                if (result == DBNull.Value)
                    return null;
                return result;
            }
            catch (Exception ex)
            {
                if (prop.GetType().IsValueType) 
                {
                    return Activator.CreateInstance(prop.GetType());//devuelve un objeto nuevo
                    // return string.Empty; Devuelve un strng vacío
                }
                return null;
            }
        }
    }
}
