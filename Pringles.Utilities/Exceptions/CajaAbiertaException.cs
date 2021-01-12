using System;

namespace Pringles.Utilities.Exceptions
{
    public sealed class CajaAbiertaException : Exception
    {
        public CajaAbiertaException() : base("CAJA ABIERTA")
        {
        }
    }
}
