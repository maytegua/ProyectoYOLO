namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model_TipoVehiculo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoVehiculo",
                c => new
                    {
                        TipoVehiculoId = c.Int(nullable: false, identity: true),
                        NombreTipoVehiculo = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TipoVehiculoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoVehiculo");
        }
    }
}
