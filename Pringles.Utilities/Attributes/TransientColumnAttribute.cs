using System;

namespace Pringles.Utilities.Attributes
{
    /// <summary>
    /// Attribute utilizado para ignorar columnas.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class TransientColumnAttribute : Attribute
    {
    }
}
