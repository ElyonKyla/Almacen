namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2105 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Coches", new[] { "propietario_Id_propietario" });
            DropColumn("dbo.Coches", "PropietarioId");
            RenameColumn(table: "dbo.Coches", name: "propietario_Id_propietario", newName: "PropietarioId");
            AlterColumn("dbo.Coches", "PropietarioId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Coches", "PropietarioId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Coches", new[] { "PropietarioId" });
            AlterColumn("dbo.Coches", "PropietarioId", c => c.String());
            RenameColumn(table: "dbo.Coches", name: "PropietarioId", newName: "propietario_Id_propietario");
            AddColumn("dbo.Coches", "PropietarioId", c => c.String());
            CreateIndex("dbo.Coches", "propietario_Id_propietario");
        }
    }
}
