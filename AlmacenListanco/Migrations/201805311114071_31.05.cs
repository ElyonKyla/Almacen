namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3105 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Piezas", "Prove_IdEmpresa", c => c.String(maxLength: 128));
            CreateIndex("dbo.Piezas", "Prove_IdEmpresa");
            AddForeignKey("dbo.Piezas", "Prove_IdEmpresa", "dbo.Empresas", "IdEmpresa");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Piezas", "Prove_IdEmpresa", "dbo.Empresas");
            DropIndex("dbo.Piezas", new[] { "Prove_IdEmpresa" });
            DropColumn("dbo.Piezas", "Prove_IdEmpresa");
        }
    }
}
