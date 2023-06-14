using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlmacenListanco
{
    [Table("Coches")]
   public class Coche
    {
        public Coche()
        {
            Facturas = new HashSet<Factura>();
            F_venta = DateTime.Now;
        }
        [Key]

        public string Id_coche { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime F_venta { get; set; }
        [ForeignKey ("propietario")]
        public string PropietarioId { get; set; }
        public virtual Propietario propietario { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
