using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AlmacenListanco.Migrations;

namespace AlmacenListanco.BaseDatos
{
   public  class AlmacenContext : DbContext
    {


        public AlmacenContext()
        : base("name=AlmacenContext")
        {
            if (Database.Exists())
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<AlmacenContext, Configuration>());
            }
           
        }
  
        public virtual DbSet<Propietario> Propietarios { get; set; }
        public virtual DbSet<Coche> Coches { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Arreglo> Arreglos { get; set; }
        public virtual DbSet<Pieza> Piezas { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }

		 protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

    
}
