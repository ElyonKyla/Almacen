using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco.BaseDatos
{
    public class RepositorioArreglo : GenericRepository<Arreglo>
    {
        public RepositorioArreglo(AlmacenContext context)
            : base(context)
        {
        }

        public IEnumerable<Arreglo> GetFiltrado(String buscado)
        {
            if (!string.IsNullOrWhiteSpace(buscado))
            {
                return Get(filter: (c => c.Tipo.ToUpper().Equals(buscado.ToUpper())
                                            ));
            }
            else return Get();
        }
    }
}
