using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Pringles.Utilities.Extensions
{
    /// <summary>
    /// Clase static que contiene las extensiones para poder obtener datos de los atributos de la
    /// capa de datos.
    /// </summary>
    public static class RepositoryExtensions
    {
        /// <summary>
        /// Retorna el nombre de la tabla de un tipo.
        /// </summary>
        /// <param name="obj">Objeto el cual se le va a extraer las columnas delimitadas por coma (,).</param>
        /// <returns></returns>
        public static string GetTableColumns(this Type type)
        {
            try
            {
                //Para obtener las propiedades del tipo que no sean transcient
                var props = type
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance) //Solamente la propiedad pública y la instancia
                    .Where(t => IsNotTransient(t));

                return string.Join(",", props.Select(t => t.Name));
            }
            catch
            {
                return "*"; //Para devolver todo
            }
        }

        /// <summary>
        /// Retorna si una propiedad no es Transient (No debe de aparecer en query)
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static bool IsNotTransient(this PropertyInfo propertyInfo)
        {
            try
            {
                return !propertyInfo
                    .GetCustomAttributes()
                    .Any(t => t.GetType() == typeof(TransientColumnAttribute));
            }
            catch
            {
                return true;
            }
        }

        /// <summary>
        /// Retorna el nombre de la propiedad.
        /// </summary>
        /// <param name="type">Propiedad a la cual se le va a extraer el nombre.</param>
        /// <returns></returns>
        //public static string GetColumnName(this PropertyInfo propertyInfo) //Para obtener el nombre de las columnas(atributos) en el query autogenerado
        //{
        //    try
        //    {
        //        var attr = propertyInfo;
        //            //.GetCustomAttributes();
        //            //.Where(t => t.GetType() == typeof(TableColumnAttribute))
        //            //.FirstOrDefault() as TableColumnAttribute; //Si tiene el atributo tablecolumn
        //        return attr.Name;
        //    }
        //    catch
        //    {
        //        return propertyInfo.Name;
        //    }
        //}

        /// <summary>
        /// Extrae el nombre de la tabla para el tipo T. Da el nombre de la tabla para el tipo
        /// </summary>
        /// <param name="type">Tipo al cual se le va a extraer el nombre de la tabla</param>
        /// <returns></returns>
        //public static string GetTableName(this Type type)
        //{
        //    string result = type.Name;
        //    if (result == null)
        //        result = type.Name;
        //    return result;
        //}

        /// <summary>
        /// Saca el nombre de la tabla si el tipo T tiene el atributo Table.
        /// </summary>
        /// <param name="type">Tipo al cual se le extrae el nombre de la tabla.</param>
        /// <returns>Nombre de la tabla si tiene el atributo table, null en el caso contrario.</returns>
        //private static string GetTableNameFromAttribute(Type type)//Se necesitan los atributos para obtener el query
        //{
        //    try
        //    {
        //        TableAttribute attr = (TableAttribute)type //Se saca el nombre de la tabla del query a partir del nombre de la clase o el atributo table
        //            .GetCustomAttributes(false) //Devuelve todos los atributos que se crearon, que tienen puestos el tipo.
        //            .FirstOrDefault(t => t.GetType() == typeof(TableAttribute));//Devuelve un conjunto de atributos
        //        return attr.Name;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        /// <summary>
        /// Obtiene los valores de las columnas insertables de un tipo.
        /// </summary>
        /// <param name="type">Tipo al cual se le van a sacar las columnas insertables.</param>
        /// <returns></returns>
        public static string GetInsertableColumnsValues(this object obj)//Saca el valor de la propiedad y crea el valor apropiado en el query
        {
            try
            {
                Type type = obj.GetType();
                var result = type
                    .GetProperties()
                    .Where(x => IsNotTransient(x) && !IsKeyColumn(x))
                    .Select(p =>
                    {
                        object value = type.GetProperty(p.Name).GetValue(obj);
                        return CreateRightOperandValue(value);
                    });
                return string.Join(",", result);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene las expresiones para asignar los valores en el SET
        /// del UPDATE.
        /// </summary>
        /// <param name="obj">Referencia al objeto del cual que van a obtener los valores.</param>
        /// <returns></returns>
        public static string GetUpdatableColumnsValues(this object obj)
        {
            try
            {
                Type type = obj.GetType();
                var result = type
                    .GetProperties()
                    .Where(x => IsNotTransient(x) && !IsKeyColumn(x))
                    .Select(p =>
                    {
                        object value = type.GetProperty(p.Name).GetValue(obj);
                        return p.Name + " = " + CreateRightOperandValue(value); //Crear el query de update
                    });
                return string.Join(", ", result);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Determina si una propiedad tiene el atributo
        /// de llave primaria.
        /// </summary>
        /// <returns></returns>
        public static bool IsKeyColumn(this PropertyInfo propertyInfo)
        {
            try
            {
                return propertyInfo
                    .GetCustomAttributes()
                    .Any(t => t.GetType() == typeof(KeyTableColumnAttribute)); //Se requiere la clave primaria
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Crear la parte del WHERE con los campos que son PRIMARY
        /// KEY con sus valores
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetPrimaryKeyComparator(this object obj)
        {
            try
            {
                Type type = obj.GetType();
                var result = type
                    .GetProperties()
                    .Where(IsKeyColumn)
                    .Select(p =>
                        CreateWhereExpression(p, obj)
                    );
                return string.Join(" AND ", result);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Prepara lo que va en el where
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <param name="objectReference"></param>
        /// <returns></returns>
        private static string CreateWhereExpression(PropertyInfo propertyInfo, object objectReference) ///Para crear la expresión where del query
        {
            try
            {
                object value = objectReference.GetType().GetProperty(propertyInfo.Name).GetValue(objectReference);
                // OJO, esto no contempla bien las fechas, solo los VARCHAR Y LOS INT.
                // TAMBIEN MANEJA LOS NULLABLES.
                return propertyInfo.Name + CreateWhereRigthOperand(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Crea la parte de los parámetros
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string CreateWhereRigthOperand(object value)
        {
            try
            {
                if (value.GetType() == typeof(Nullable))
                {
                    if (value == null)
                    {
                        return " IS NULL";
                    }
                }

                return " = " + CreateRightOperandValue(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Encapsula la sección del value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string CreateRightOperandValue(object value)
        {
            try
            {
                if (value == null)
                    return "NULL";

                Type propertyType = value.GetType();

                IEnumerable<Type> intNumeralTypes = new Type[] //colecciones de tipos de numeros enteros
                {
                    typeof(int),
                    typeof(short),
                    typeof(long)
                };

                IEnumerable<Type> decimalNumeralTypes = new Type[] //colecciones de tipos de numeros decimales
                {
                    typeof(double),
                    typeof(float),
                    typeof(decimal)
                };

                // Maneja los numeros enteros sin las comas en la centena.
                if (intNumeralTypes.Contains(propertyType))
                {
                    return Convert.ToInt64(value).ToString("0", CultureInfo.InvariantCulture);
                }
                // Maneja los numeros decimales sin coma en la centena, punto como punto flotante, y dos cifras significativas.
                else if (decimalNumeralTypes.Contains(propertyType))
                {
                    return Convert.ToDecimal(value).ToString("0.00", CultureInfo.InvariantCulture);
                }
                // Maneja la fecha como ISO-8601.
                else if (value.GetType() == typeof(DateTime)) 
                {
                    return "'" + ((DateTime)value).ToString("s", CultureInfo.InvariantCulture) + "'";
                }
                // Maneja el bool como 1 para true y 0 para false.
                else if (value.GetType() == typeof(bool))
                {
                    return ((bool)value) ? "1" : "0";
                }
                // Maneja cualquier otra cosa como un string con las comillas.
                else
                {
                    return $"'{value.ToString()}'";
                }
            }
            catch
            {
                return "'0'";
            }
        }

        /// <summary>
        /// Obtiene las columnas insertables de un tipo.
        /// </summary>
        /// <param name="type">Tipo al cual se le van a sacar las columnas insertables.</param>
        /// <returns></returns>
        public static string GetInsertableColumns(this Type type)
        {
            try
            {
                return string.Join(",", type.GetProperties()
                    .Where(x => IsNotTransient(x) && !IsKeyColumn(x))
                    .Select(x => x.Name));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
