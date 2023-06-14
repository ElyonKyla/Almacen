using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AlmacenListanco
{
    [Table("Propietarios")]
    public class Propietario
    {
        public Propietario()
        {
            Coches = new HashSet<Coche>();
        
    }
        [Key]
        public string Id_propietario { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get
            {
                if (!string.IsNullOrEmpty(Apellidos))
                    return Nombre + " " + Apellidos;
                else
                    {
                        return Nombre;
                    }
            }
        }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public virtual ICollection <Coche> Coches { get; set; }
    }
}
