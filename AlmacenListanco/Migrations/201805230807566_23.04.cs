namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2304 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facturas", "Kilometros", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Facturas", "Kilometros");
        }
    }
}
