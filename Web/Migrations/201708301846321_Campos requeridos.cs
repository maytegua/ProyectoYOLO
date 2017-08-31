namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Camposrequeridos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nombres", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Apellidos", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "FechaNacimiento", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Biografia", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Biografia");
            DropColumn("dbo.AspNetUsers", "FechaNacimiento");
            DropColumn("dbo.AspNetUsers", "Apellidos");
            DropColumn("dbo.AspNetUsers", "Nombres");
        }
    }
}
