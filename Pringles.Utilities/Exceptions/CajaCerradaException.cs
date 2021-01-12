using System;

namespace Pringles.Utilities.Exceptions
{
    public sealed class CajaCerradaException : Exception
    {
        public CajaCerradaException() : base("CAJA CERRADA")
        {
        }
    }
}
