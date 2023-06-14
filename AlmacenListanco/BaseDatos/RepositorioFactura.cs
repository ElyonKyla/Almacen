using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco.BaseDatos
{
   public class RepositorioFactura : GenericRepository<Factura>
    {
        public RepositorioFactura(AlmacenContext context)
            : base(context)
        {
        }

       
        
    }
}
