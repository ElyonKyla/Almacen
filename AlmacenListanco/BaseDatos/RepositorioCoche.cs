using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco.BaseDatos
{
   public class RepositorioCoche : GenericRepository<Coche>
    {
        public RepositorioCoche(AlmacenContext context)
            : base(context)
        {
        }

      

    }
}
