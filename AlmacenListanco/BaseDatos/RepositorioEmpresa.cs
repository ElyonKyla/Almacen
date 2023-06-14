using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco.BaseDatos
{
   public class RepositorioEmpresa : GenericRepository<Empresa>
    {
        public RepositorioEmpresa(AlmacenContext context)
            : base(context)
        {
        }

       

    }
    
}
