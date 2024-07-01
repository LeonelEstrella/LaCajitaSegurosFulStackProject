using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class RangoEtarioConfiguracion : IEntityTypeConfiguration<RangoEtario>
    {
        public void Configure(EntityTypeBuilder<RangoEtario> builder)
        {
            builder.HasData(
                new RangoEtario { EdadRangoId = 1, EdadDesde = 18, EdadHasta = 40, Peso = "0.0005" },
                new RangoEtario { EdadRangoId = 2, EdadDesde = 41, EdadHasta = 60, Peso = "0.0006" },
                new RangoEtario { EdadRangoId = 3, EdadDesde = 61, EdadHasta = 90, Peso = "0.0008" }
                );
        }
    }
}
