using Pringles.Utilities.Attributes;
using System;

namespace Pringles.EE
{
    
    public class Cliente
    {
        [KeyTableColumn]
        public int Id { get; set; }

        public string Dni { get; set; }

        public string Nombres { get; set; }

        public string Apellido { get; set; }

        //public string Telefono { get; set; }

        //public string Celular { get; set; }

        //public string Email { get; set; }

        //public string Direccion { get; set; }

        public DateTime Fecha_Nacimiento { get; set; }

        public DateTime? Fecha_Reg { get; set; }

        public DateTime? Fecha_Modificacion { get; set; }

        public bool Activo { get; set; } = true;

        [TransientColumn]
        public string NombreCompleto 
        {
            get 
            {
                try
                {
                    return $"{Nombres} {Apellido}".Trim();
                }
                catch
                {
                    return null;
                }
            } 
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
