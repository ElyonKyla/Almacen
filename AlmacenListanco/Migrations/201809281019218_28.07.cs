namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2807 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facturas", "NumArreglos", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Facturas", "NumArreglos");
        }
    }
}
