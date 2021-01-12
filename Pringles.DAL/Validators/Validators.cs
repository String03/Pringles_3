using Pringles.EE;
using System;
using System.Linq;

namespace Pringles.DAL.Validators
{
    /// <summary>
    /// Clase que contiene los metodos de extension para validar los modelos.
    /// </summary>
    public static class Validators
    {
        /// <summary>
        /// Valida que el modelo de genero sea valido.
        /// </summary>
        /// <param name="genero">Genero a Evaluar.</param>
        /// <returns></returns>
        public static bool ValidarGenero(this Genero genero)
        {
            return !string.IsNullOrEmpty(genero.Nombre);
        }

        /// <summary>
        /// Valida que el modelo de autor sea valido.
        /// </summary>
        /// <param name="autor">Autor a Evaluar.</param>
        /// <returns></returns>
        public static bool ValidarAutor(this Autor autor)
        {
            return !string.IsNullOrEmpty(autor.Nombres) && !string.IsNullOrEmpty(autor.Apellido);
        }

        /// <summary>
        /// Valida que el modelo de usuario sea valido.
        /// </summary>
        /// <param name="usuario">Usuario a Evaluar.</param>
        /// <returns></returns>
        public static bool ValidarUsuario(this Usuario usuario)
        {
            return !string.IsNullOrEmpty(usuario.Nombres) && !string.IsNullOrEmpty(usuario.Apellido) && !string.IsNullOrEmpty(usuario.Nombre_Usuario) && !string.IsNullOrEmpty(usuario.Contrasenia);
        }

        /// <summary>
        /// Valida que el modelo de rol sea valido.
        /// </summary>
        /// <param name="rol">Rol a Evaluar.</param>
        /// <returns></returns>
        public static bool ValidarRol(this Rol rol)
        {
            return !string.IsNullOrEmpty(rol.Codigo_Rol.ToString()) && !string.IsNullOrEmpty(rol.Descripcion);
        }

        /// <summary>
        /// Valida que el modelo de libro sea valido.
        /// </summary>
        /// <param name="libro">Libro a Evaluar.</param>
        /// <returns></returns>
        public static bool ValidarLibro(this Libro libro)
        {
            return !string.IsNullOrEmpty(libro.Isbn) && !string.IsNullOrEmpty(libro.Titulo) && !string.IsNullOrEmpty(libro.Cantidad_Stock.ToString());
        }

        /// <summary>
        /// Valida que el modelo de cliente sea valido.
        /// </summary>
        /// <param name="libro">Libro a Evaluar.</param>
        /// <returns></returns>
        public static bool ValidarCliente(this Cliente cliente)
        {
            return !new string[] { cliente.Dni, cliente.Nombres, cliente.Apellido }.Any(string.IsNullOrEmpty) && !(cliente.Fecha_Nacimiento == null);
        }



        /// <summary>
        /// Valida que el modelo de descuento sea valido.
        /// </summary>
        /// <param name="detalleDescuento">Descuento a evaluar.</param>
        /// <returns></returns>
        public static bool ValidarDetalleDescuento(this DetalleDescuento detalleDescuento) 
        {
            if (string.IsNullOrEmpty(detalleDescuento.Descripcion)) 
            {
                return false;
            }

            if (!(detalleDescuento.Aplica_Autor ?? false) && !(detalleDescuento.Aplica_Genero ?? false))
            {
                return false;
            }

            if (detalleDescuento.Descuento < 1.0m || detalleDescuento.Descuento > 99.0m)
            {
                return false;
            }

            if (detalleDescuento.Aplica_Autor.Value && (detalleDescuento.Autor_Fk ?? 0) == 0)
            {
                return false;
            }

            if (detalleDescuento.Aplica_Genero.Value && (detalleDescuento.Genero_Fk ?? 0) == 0)
            {
                return false;
            }

            if (detalleDescuento.Fecha_Fin.GetValueOrDefault().Date < DateTime.Now.Date)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida que el modelo de proveedor sea valido.
        /// </summary>
        /// <param name="proveedor">Proveedor a evaluar.</param>
        /// <returns></returns>

        public static bool ValidarProveedor(this Proveedor proveedor)
        {
            return !string.IsNullOrEmpty(proveedor.Cuil) && !string.IsNullOrEmpty(proveedor.Razon_Social);
        }

    }
}
