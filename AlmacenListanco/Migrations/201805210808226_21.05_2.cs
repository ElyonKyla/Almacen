namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2105_2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Facturas", new[] { "coche_Id_coche" });
            DropColumn("dbo.Facturas", "CocheId");
            RenameColumn(table: "dbo.Facturas", name: "coche_Id_coche", newName: "CocheId");
            AlterColumn("dbo.Facturas", "CocheId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Facturas", "CocheId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Facturas", new[] { "CocheId" });
            AlterColumn("dbo.Facturas", "CocheId", c => c.String());
            RenameColumn(table: "dbo.Facturas", name: "CocheId", newName: "coche_Id_coche");
            AddColumn("dbo.Facturas", "CocheId", c => c.String());
            CreateIndex("dbo.Facturas", "coche_Id_coche");
        }
    }
}
