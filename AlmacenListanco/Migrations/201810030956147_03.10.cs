namespace AlmacenListanco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0310 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresas", "Casa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresas", "Casa");
        }
    }
}
