using Pringles.Utilities.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pringles.EE
{
    
    public class Usuario
    {
        public Usuario()
        {
            Cajas = new HashSet<Caja>();
            
        }

        [KeyTableColumn]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Codigo_Empleado { get; set; }

        [Required]
        [StringLength(120)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(120)]
        public string Apellido { get; set; }

        public DateTime? Fecha_Reg { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre_Usuario { get; set; }

        [Required]
        [StringLength(256)]
        public string Contrasenia { get; set; }

        public int? Rol_Id { get; set; }

        public int? Caja_Fk { get; set; }

        [TransientColumn]
        public virtual ICollection<Caja> Cajas { get; set; }

      

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
            return Nombre_Usuario;
        }
    }
}
