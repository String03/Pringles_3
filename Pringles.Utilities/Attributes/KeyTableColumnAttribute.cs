using System;

namespace Pringles.Utilities.Attributes
{
    /// <summary>
    /// Attribute utilizado para saber si la columna es PRIMARY KEY.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class KeyTableColumnAttribute : Attribute
    {
    }
}
