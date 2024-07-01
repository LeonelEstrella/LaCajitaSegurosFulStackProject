using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class LocalidadConfiguracion : IEntityTypeConfiguration<Localidad>
    {
        public void Configure(EntityTypeBuilder<Localidad> builder)
        {
            builder.HasData(
                new Localidad { LocalidadId = 1, Nombre = "Morón", Peso = "0.0005" },
                new Localidad { LocalidadId = 2, Nombre = "San Justo", Peso = "0.0006" },
                new Localidad { LocalidadId = 3, Nombre = "San Martín", Peso = "0.0004" },
                new Localidad { LocalidadId = 4, Nombre = "Quilmes", Peso = "0.0006" },
                new Localidad { LocalidadId = 5, Nombre = "Lanús", Peso = "0.0005" },
                new Localidad { LocalidadId = 6, Nombre = "Avellaneda", Peso = "0.0004" },
                new Localidad { LocalidadId = 7, Nombre = "Vicente López", Peso = "0.0003" },
                new Localidad { LocalidadId = 8, Nombre = "San Isidro", Peso = "0.0003" },
                new Localidad { LocalidadId = 9, Nombre = "Tigre", Peso = "0.0004" },
                new Localidad { LocalidadId = 10, Nombre = "San Fernando", Peso = "0.0003" },
                new Localidad { LocalidadId = 11, Nombre = "Pilar", Peso = "0.0004" },
                new Localidad { LocalidadId = 12, Nombre = "Escobar", Peso = "0.0002" },
                new Localidad { LocalidadId = 13, Nombre = "Moreno", Peso = "0.0002" },
                new Localidad { LocalidadId = 14, Nombre = "Lomas de Zamora", Peso = "0.0002" },
                new Localidad { LocalidadId = 15, Nombre = "Adrogué", Peso = "0.0003" },
                new Localidad { LocalidadId = 16, Nombre = "Banfield", Peso = "0.0003" },
                new Localidad { LocalidadId = 17, Nombre = "Temperley", Peso = "0.0002" },
                new Localidad { LocalidadId = 18, Nombre = "Hurlingham", Peso = "0.0004" },
                new Localidad { LocalidadId = 19, Nombre = "Ituzaingó", Peso = "0.0004" },
                new Localidad { LocalidadId = 20, Nombre = "Castelar", Peso = "0.0003" },
                new Localidad { LocalidadId = 21, Nombre = "Ramos Mejía", Peso = "0.0003" },
                new Localidad { LocalidadId = 22, Nombre = "Merlo", Peso = "0.0002" },
                new Localidad { LocalidadId = 23, Nombre = "Ezeiza", Peso = "0.0002" },
                new Localidad { LocalidadId = 24, Nombre = "Berazategui", Peso = "0.0003" },
                new Localidad { LocalidadId = 25, Nombre = "Florencio Varela", Peso = "0.0003" },
                new Localidad { LocalidadId = 26, Nombre = "General Rodríguez", Peso = "0.0002" },
                new Localidad { LocalidadId = 27, Nombre = "Villa Ballester", Peso = "0.0003" },
                new Localidad { LocalidadId = 28, Nombre = "Bella Vista", Peso = "0.0002" },
                new Localidad { LocalidadId = 29, Nombre = "Ciudadela", Peso = "0.0002" });
        }
    }
}
