namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model_Viaje_And_Relation_ApplicationUser_TipoVehiculo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Viaje",
                c => new
                    {
                        ViajeId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                        PuntoPartida = c.String(nullable: false),
                        PuntoDestino = c.String(nullable: false),
                        FechaSalida = c.String(nullable: false),
                        HoraSalida = c.String(nullable: false),
                        FechaRegreso = c.String(),
                        HoraRegreso = c.String(),
                        Tarifa = c.Double(nullable: false),
                        NumAsientos = c.Int(nullable: false),
                        DetallesViaje = c.String(),
                        TipoVehiculoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ViajeId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .ForeignKey("dbo.TipoVehiculo", t => t.TipoVehiculoId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId)
                .Index(t => t.TipoVehiculoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Viaje", "TipoVehiculoId", "dbo.TipoVehiculo");
            DropForeignKey("dbo.Viaje", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Viaje", new[] { "TipoVehiculoId" });
            DropIndex("dbo.Viaje", new[] { "ApplicationUserId" });
            DropTable("dbo.Viaje");
        }
    }
}
