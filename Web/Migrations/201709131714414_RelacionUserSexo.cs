namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelacionUserSexo : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.AspNetUsers", "SexoId");
            AddForeignKey("dbo.AspNetUsers", "SexoId", "dbo.Sexo", "SexoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "SexoId", "dbo.Sexo");
            DropIndex("dbo.AspNetUsers", new[] { "SexoId" });
        }
    }
}
