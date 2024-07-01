using Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class ProvinciaConfiguracion : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {
            builder.HasData(
                new Provincia { ProvinciaId = 1, Nombre = "Buenos Aires" }
            );
        }
    }
}



