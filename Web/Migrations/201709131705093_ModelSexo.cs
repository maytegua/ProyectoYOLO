namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelSexo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sexo",
                c => new
                    {
                        SexoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.SexoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sexo");
        }
    }
}
