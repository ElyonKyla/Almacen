namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0706 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Arreglos", "Titulo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Arreglos", "Titulo");
        }
    }
}
