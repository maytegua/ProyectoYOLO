namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoSexoIdApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SexoId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SexoId");
        }
    }
}
