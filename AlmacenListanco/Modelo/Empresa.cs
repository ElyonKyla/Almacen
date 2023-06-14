using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlmacenListanco
{
    [Table("Empresas")]
    public class Empresa
    {
        public Empresa()
        {
            Compras = new HashSet<Compra>();
        }
        [Key]

        public string IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Telf1 { get; set; }
        public string Casa { get; set; }
        public string Telf2 { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Pieza> ventas { get; set; }
    }
}
