using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco
{
    [Table("Facturas")]
   public class Factura
    {
        public Factura()
        {
            Arreglos = new HashSet<Arreglo>();
            FechaExp = DateTime.Now;
        }
        [Key]
        [Column(Order = 1)]
        public int NumFactura { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime FechaExp { get; set; }
        [ForeignKey ("coche")]
        public string CocheId { get; set; }  //FDoreing key
        public string Kilometros { get; set; }
        public virtual Coche coche { get; set; } //objeto coche
        public virtual ICollection<Arreglo> Arreglos { get; set; }
        public int NumArreglos { get; set; }
    }
}
