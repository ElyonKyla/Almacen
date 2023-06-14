using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlmacenListanco
{
    [Table("Piezas")]
    public class Pieza
    {
        public Pieza()
        {
            Compras = new HashSet<Compra>();
        }
        [Key]
        public string IdPieza { get; set; }
        public string Nombre { get; set; }
        public string Casa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Variante { get; set; }
        public string Uso { get; set; }
        public int Cantidad { get; set; }
        public string ArregloId { get; set; } //Foreing Key
        public string EmpresaId {get; set;}
        public virtual Arreglo Arreglo { get; set; }
        public virtual Empresa Prove { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }

    }
}
