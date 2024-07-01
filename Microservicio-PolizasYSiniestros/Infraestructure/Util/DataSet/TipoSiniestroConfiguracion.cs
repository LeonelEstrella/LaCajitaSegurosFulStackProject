using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructure.Util.DataSet
{
    public class TipoSiniestroConfiguracion : IEntityTypeConfiguration<TipoDeSiniestro>
    {
        public void Configure(EntityTypeBuilder<TipoDeSiniestro> builder)
        {
            builder.HasData(
                 new TipoDeSiniestro { TipoDeSiniestroId = 1, Nombre = "Accidente de transito" },
                 new TipoDeSiniestro { TipoDeSiniestroId = 2, Nombre = "Granizo" },
                 new TipoDeSiniestro { TipoDeSiniestroId = 3, Nombre = "Incendio" },
                 new TipoDeSiniestro { TipoDeSiniestroId = 4, Nombre = "Inundación" },
                 new TipoDeSiniestro { TipoDeSiniestroId = 5, Nombre = "Robo" },
                 new TipoDeSiniestro { TipoDeSiniestroId = 6, Nombre = "Rotura" }
                );
        }
    }
}
