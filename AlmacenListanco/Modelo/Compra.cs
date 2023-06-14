using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco
{
    [Table("Compras")]
   public class Compra

    {
        public Compra()
        {
            FechaEntrada = DateTime.Now;
        }
        [Key]
        public int CompraId { get; set; }

        [ForeignKey("empresa")]
        [Column(Order = 1)]
        public string EmpresaId { get; set; }

        [ ForeignKey("pieza")]
        [Column(Order = 2)]
        public string PiezaId { get; set; }
        public float Precio { get; set; }
        public DateTime FechaEntrada { get; set; }
        public virtual Empresa empresa { get; set; }
        public virtual Pieza pieza { get; set; }
    }
}
