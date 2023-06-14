using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenListanco.BaseDatos
{
    public class UnitOfWork
    {

        private AlmacenContext context = new AlmacenContext();
        private bool disposed = false;

        private RepositorioArreglo repositorioArreglo;
        private RepositorioCoche repositorioCoche;
        private RepositorioCompra repositorioCompra;
        private RepositorioEmpresa repositorioEmpresa;
        private RepositorioFactura repositorioFactura;
        private RepositorioPieza repositorioPieza;
        private RepositorioPropietario repositorioPropietario;


        public RepositorioArreglo RepositorioArreglo
        {
            get
            {
                if (this.repositorioArreglo == null)
                {
                    this.repositorioArreglo = new RepositorioArreglo(context);
                }

                return repositorioArreglo;
            }
        }
        public RepositorioCoche RepositorioCoche
        {
            get
            {
                if (this.repositorioCoche == null)
                {
                    this.repositorioCoche = new RepositorioCoche(context);
                }

                return repositorioCoche;
            }
        }
        public RepositorioCompra RepositorioCompra
        {
            get
            {
                if (this.repositorioCompra == null)
                {
                    this.repositorioCompra = new RepositorioCompra(context);
                }

                return repositorioCompra;
            }
        }
        public RepositorioEmpresa RepositorioEmpresa
        {
            get
            {
                if (this.repositorioEmpresa == null)
                {
                    this.repositorioEmpresa = new RepositorioEmpresa(context);
                }

                return repositorioEmpresa;
            }
        }
        public RepositorioFactura RepositorioFactura
        {
            get
            {
                if (this.repositorioFactura == null)
                {
                    this.repositorioFactura = new RepositorioFactura(context);
                }

                return repositorioFactura;
            }
        }
        public RepositorioPieza RepositorioPieza
        {
            get
            {
                if (this.repositorioPieza == null)
                {
                    this.repositorioPieza = new RepositorioPieza(context);
                }

                return repositorioPieza;
            }
        }
        public RepositorioPropietario RepositorioPropietario
        {
            get
            {
                if (this.repositorioPropietario == null)
                {
                    this.repositorioPropietario = new RepositorioPropietario(context);
                }

                return repositorioPropietario;
            }
        }



        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

