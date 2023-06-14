using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco.BaseDatos
{
    public class RepositorioPropietario : GenericRepository<Propietario>
    {
        public RepositorioPropietario(AlmacenContext context)
            : base(context)
        {
        }
    }
}
