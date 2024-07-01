using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class GNCConfiguracion : IEntityTypeConfiguration<GNC>
    {
        public void Configure(EntityTypeBuilder<GNC> builder)
        {
            builder.HasData(
                new GNC { GNCId = 1 ,HasGNC = true, Peso = "0.0001" },
                new GNC { GNCId = 2, HasGNC = false, Peso = "0" }
                );
        }
    }
}
