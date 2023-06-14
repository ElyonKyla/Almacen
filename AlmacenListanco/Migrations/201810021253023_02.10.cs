namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0210 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Compras", "Precio", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Compras", "Precio");
        }
    }
}
