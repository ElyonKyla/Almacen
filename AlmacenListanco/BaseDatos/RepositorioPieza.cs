using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco.BaseDatos
{
   public class RepositorioPieza : GenericRepository<Pieza>
    {
        public RepositorioPieza(AlmacenContext context)
            : base(context)
        {
        }

        

    }
}
