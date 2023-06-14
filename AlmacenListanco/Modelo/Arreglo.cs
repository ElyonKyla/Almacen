using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco
{
    [Table("Arreglos")]
   public class Arreglo
    {
        public Arreglo()
        {
            Piezas = new HashSet<Pieza>();
        }


        [Key, ForeignKey("Factura")]
        [Column(Order =1)]
        public int IdFactura { get; set; }


        [Key, ForeignKey("Factura")]
        [Column(Order =2)]
        public DateTime FechaExp { get; set; }



        [Key]
        [Column(Order =3)]
        public int IdAreglo { get; set; }
        

        public string Titulo { get; set; }
         public int Tiempo { get; set; }
        public string Tipo { get; set; } 
        
        public virtual Factura Factura { get; set; }
        
        public virtual ICollection<Pieza> Piezas { get; set; }

    }
}
