using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class AnioVehiculoConfiguracion : IEntityTypeConfiguration<AnioVehiculo>
    {
        public void Configure(EntityTypeBuilder<AnioVehiculo> builder)
        {
            builder.HasData(
                new AnioVehiculo { AnioId = 1 ,AnioVehiculoDesde = 1, AnioVehiculoHasta = 1989, Peso = "0.0007" },
                new AnioVehiculo { AnioId = 2, AnioVehiculoDesde = 1990, AnioVehiculoHasta = 1999, Peso = "0.0005" },
                new AnioVehiculo { AnioId = 3, AnioVehiculoDesde = 2000, AnioVehiculoHasta = 2009, Peso = "0.0004" },
                new AnioVehiculo { AnioId = 4, AnioVehiculoDesde = 2010, AnioVehiculoHasta = 2019, Peso = "0.0003" },
                new AnioVehiculo { AnioId = 5, AnioVehiculoDesde = 2020, AnioVehiculoHasta = 2024, Peso = "0.0001" }
                );
        }
    }
}
