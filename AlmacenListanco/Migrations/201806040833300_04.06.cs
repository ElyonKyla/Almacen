namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0406 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Piezas", "EmpresaId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Piezas", "EmpresaId");
        }
    }
}
