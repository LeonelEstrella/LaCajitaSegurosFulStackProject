using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class LocalidadConfiguracion : IEntityTypeConfiguration<Localidad>
    {
        public void Configure(EntityTypeBuilder<Localidad> builder)
        {
            builder.HasData(
                new Localidad { LocalidadId = 1, Nombre = "Morón" },
                new Localidad { LocalidadId = 2, Nombre = "San Justo" },
                new Localidad { LocalidadId = 3, Nombre = "San Martín" },
                new Localidad { LocalidadId = 4, Nombre = "Quilmes" },
                new Localidad { LocalidadId = 5, Nombre = "Lanús" },
                new Localidad { LocalidadId = 6, Nombre = "Avellaneda" },
                new Localidad { LocalidadId = 7, Nombre = "Vicente López" },
                new Localidad { LocalidadId = 8, Nombre = "San Isidro" },
                new Localidad { LocalidadId = 9, Nombre = "Tigre" },
                new Localidad { LocalidadId = 10, Nombre = "San Fernando" },
                new Localidad { LocalidadId = 11, Nombre = "Pilar" },
                new Localidad { LocalidadId = 12, Nombre = "Escobar" },
                new Localidad { LocalidadId = 13, Nombre = "Moreno" },
                new Localidad { LocalidadId = 14, Nombre = "Lomas de Zamora" },
                new Localidad { LocalidadId = 15, Nombre = "Adrogué" },
                new Localidad { LocalidadId = 16, Nombre = "Banfield" },
                new Localidad { LocalidadId = 17, Nombre = "Temperley" },
                new Localidad { LocalidadId = 18, Nombre = "Hurlingham" },
                new Localidad { LocalidadId = 19, Nombre = "Ituzaingó" },
                new Localidad { LocalidadId = 20, Nombre = "Castelar" },
                new Localidad { LocalidadId = 21, Nombre = "Ramos Mejía" },
                new Localidad { LocalidadId = 22, Nombre = "Merlo" },
                new Localidad { LocalidadId = 23, Nombre = "Ezeiza" },
                new Localidad { LocalidadId = 24, Nombre = "Berazategui" },
                new Localidad { LocalidadId = 25, Nombre = "Florencio Varela" },
                new Localidad { LocalidadId = 26, Nombre = "General Rodríguez" },
                new Localidad { LocalidadId = 27, Nombre = "Villa Ballester" },
                new Localidad { LocalidadId = 28, Nombre = "Bella Vista" },
                new Localidad { LocalidadId = 29, Nombre = "Ciudadela" }
           );
        }
    }
}

