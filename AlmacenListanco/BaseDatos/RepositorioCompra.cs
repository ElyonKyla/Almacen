using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco.BaseDatos
{
   public class RepositorioCompra : GenericRepository<Compra>
    {
        public RepositorioCompra(AlmacenContext context)
            : base(context)
        {
        }

        

    }
}
