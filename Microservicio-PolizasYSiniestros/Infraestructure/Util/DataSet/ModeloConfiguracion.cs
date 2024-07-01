using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class ModeloConfiguracion : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.HasData(
                new Modelo { ModeloId = 1, NombreModelo = "Siena", MarcaId = 1 },
                new Modelo { ModeloId = 2, NombreModelo = "Uno", MarcaId = 1 },
                new Modelo { ModeloId = 3, NombreModelo = "Palio", MarcaId = 1 },
                new Modelo { ModeloId = 4, NombreModelo = "Fiesta", MarcaId = 2 },
                new Modelo { ModeloId = 5, NombreModelo = "Ranger", MarcaId = 2 },
                new Modelo { ModeloId = 6, NombreModelo = "Focus", MarcaId = 2 },
                new Modelo { ModeloId = 7, NombreModelo = "320", MarcaId = 3 },
                new Modelo { ModeloId = 8, NombreModelo = "530", MarcaId = 3 },
                new Modelo { ModeloId = 9, NombreModelo = "750", MarcaId = 3 },
                new Modelo { ModeloId = 10, NombreModelo = "208", MarcaId = 4 },
                new Modelo { ModeloId = 11, NombreModelo = "308", MarcaId = 4 },
                new Modelo { ModeloId = 12, NombreModelo = "3008", MarcaId = 4 },
                new Modelo { ModeloId = 13, NombreModelo = "Corolla", MarcaId = 5 },
                new Modelo { ModeloId = 14, NombreModelo = "Hilux", MarcaId = 5 },
                new Modelo { ModeloId = 15, NombreModelo = "Etios", MarcaId = 5 },
                new Modelo { ModeloId = 16, NombreModelo = "Amarok", MarcaId = 6 },
                new Modelo { ModeloId = 17, NombreModelo = "Taos", MarcaId = 6 },
                new Modelo { ModeloId = 18, NombreModelo = "Kangoo II", MarcaId = 7 },
                new Modelo { ModeloId = 19, NombreModelo = "Sandero", MarcaId = 7 },
                new Modelo { ModeloId = 20, NombreModelo = "Stepway", MarcaId = 7 }
                );
        }
    }
}
