namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arreglos",
                c => new
                    {
                        IdFactura = c.Int(nullable: false),
                        FechaExp = c.DateTime(nullable: false),
                        IdAreglo = c.Int(nullable: false),
                        Tiempo = c.Int(nullable: false),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => new { t.IdFactura, t.FechaExp, t.IdAreglo })
                .ForeignKey("dbo.Facturas", t => new { t.IdFactura, t.FechaExp }, cascadeDelete: true)
                .Index(t => new { t.IdFactura, t.FechaExp });
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        NumFactura = c.Int(nullable: false),
                        FechaExp = c.DateTime(nullable: false),
                        CocheId = c.String(),
                        coche_Id_coche = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.NumFactura, t.FechaExp })
                .ForeignKey("dbo.Coches", t => t.coche_Id_coche)
                .Index(t => t.coche_Id_coche);
            
            CreateTable(
                "dbo.Coches",
                c => new
                    {
                        Id_coche = c.String(nullable: false, maxLength: 128),
                        Matricula = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        F_venta = c.DateTime(nullable: false),
                        PropietarioId = c.String(),
                        propietario_Id_propietario = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id_coche)
                .ForeignKey("dbo.Propietarios", t => t.propietario_Id_propietario)
                .Index(t => t.propietario_Id_propietario);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        Id_propietario = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                        Telefono = c.String(),
                        Direccion = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id_propietario);
            
            CreateTable(
                "dbo.Piezas",
                c => new
                    {
                        IdPieza = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                        Casa = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Variante = c.String(),
                        Uso = c.String(),
                        Cantidad = c.Int(nullable: false),
                        ArregloId = c.String(),
                        Arreglo_IdFactura = c.Int(),
                        Arreglo_FechaExp = c.DateTime(),
                        Arreglo_IdAreglo = c.Int(),
                    })
                .PrimaryKey(t => t.IdPieza)
                .ForeignKey("dbo.Arreglos", t => new { t.Arreglo_IdFactura, t.Arreglo_FechaExp, t.Arreglo_IdAreglo })
                .Index(t => new { t.Arreglo_IdFactura, t.Arreglo_FechaExp, t.Arreglo_IdAreglo });
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        EmpresaId = c.String(maxLength: 128),
                        PiezaId = c.String(maxLength: 128),
                        CompraId = c.Int(nullable: false, identity: true),
                        FechaEntrada = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompraId)
                .ForeignKey("dbo.Empresas", t => t.EmpresaId)
                .ForeignKey("dbo.Piezas", t => t.PiezaId)
                .Index(t => t.EmpresaId)
                .Index(t => t.PiezaId);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        IdEmpresa = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                        Telf1 = c.String(),
                        Telf2 = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.IdEmpresa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "PiezaId", "dbo.Piezas");
            DropForeignKey("dbo.Compras", "EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.Piezas", new[] { "Arreglo_IdFactura", "Arreglo_FechaExp", "Arreglo_IdAreglo" }, "dbo.Arreglos");
            DropForeignKey("dbo.Arreglos", new[] { "IdFactura", "FechaExp" }, "dbo.Facturas");
            DropForeignKey("dbo.Coches", "propietario_Id_propietario", "dbo.Propietarios");
            DropForeignKey("dbo.Facturas", "coche_Id_coche", "dbo.Coches");
            DropIndex("dbo.Compras", new[] { "PiezaId" });
            DropIndex("dbo.Compras", new[] { "EmpresaId" });
            DropIndex("dbo.Piezas", new[] { "Arreglo_IdFactura", "Arreglo_FechaExp", "Arreglo_IdAreglo" });
            DropIndex("dbo.Coches", new[] { "propietario_Id_propietario" });
            DropIndex("dbo.Facturas", new[] { "coche_Id_coche" });
            DropIndex("dbo.Arreglos", new[] { "IdFactura", "FechaExp" });
            DropTable("dbo.Empresas");
            DropTable("dbo.Compras");
            DropTable("dbo.Piezas");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Coches");
            DropTable("dbo.Facturas");
            DropTable("dbo.Arreglos");
        }
    }
}
