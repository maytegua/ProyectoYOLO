namespace Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Web.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //Agregando Campos Al crear la Tabla Sexo
            context.Sexo.AddOrUpdate(s => s.Nombre,
                new Sexo { Nombre = "Masculino" },
                new Sexo { Nombre = "Femenino" }
                );

            //Agregando Campos Al crear la Tabla TipoVehiculo
            context.TipoVehiculo.AddOrUpdate(t => t.NombreTipoVehiculo,
                new TipoVehiculo { NombreTipoVehiculo = "Seda 4 Puertas"},
                new TipoVehiculo { NombreTipoVehiculo = "Sedan 2 Puertas" },
                new TipoVehiculo { NombreTipoVehiculo = "Pick-Up Sencillo" },
                new TipoVehiculo { NombreTipoVehiculo = "Pick-Up Doble Cabina" },
                new TipoVehiculo { NombreTipoVehiculo = "Minivan" },
                new TipoVehiculo { NombreTipoVehiculo = "Microbus" },
                new TipoVehiculo { NombreTipoVehiculo = "Pick-Up" },
                new TipoVehiculo { NombreTipoVehiculo = "Camioneta Familiar" },
                new TipoVehiculo { NombreTipoVehiculo = "Camioneta Agricola" },
                new TipoVehiculo { NombreTipoVehiculo = "Camión Pequeño" }                
                );
        }
    }
}
