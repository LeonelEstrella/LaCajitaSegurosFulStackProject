using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Util.DataSet
{
    public class VersionConfiguracion : IEntityTypeConfiguration<VersionVehiculo>
    {
        public void Configure(EntityTypeBuilder<VersionVehiculo> builder)
        {
            builder.HasData(
                new VersionVehiculo { VersionId = 1, NombreVersion = "1.4 Fire", PrecioBase = 5200000, ModeloId = 1 },
                new VersionVehiculo { VersionId = 2, NombreVersion = "1.4 Fire Way", PrecioBase = 6700000, ModeloId = 1 },
                new VersionVehiculo { VersionId = 3, NombreVersion = "1.7 ELX TD L/N", PrecioBase = 3600000, ModeloId = 1 },
                new VersionVehiculo { VersionId = 4, NombreVersion = "Cargo 1.3 Fire", PrecioBase = 3200000, ModeloId = 2 },
                new VersionVehiculo { VersionId = 5, NombreVersion = "Fire 1.3 3P LN", PrecioBase = 4500000, ModeloId = 2 },
                new VersionVehiculo { VersionId = 6, NombreVersion = "Fire 1.3 5P LN Pack C II", PrecioBase = 8500000, ModeloId = 2 },
                new VersionVehiculo { VersionId = 7, NombreVersion = "WE 1.8 Adventure", PrecioBase = 6487999, ModeloId = 3 },
                new VersionVehiculo { VersionId = 8, NombreVersion = "1.4 3P ELX Active", PrecioBase = 8000000, ModeloId = 3 },
                new VersionVehiculo { VersionId = 9, NombreVersion = "WE 1.7 TD Adventure X-Treme", PrecioBase = 4500000, ModeloId = 3 },
                new VersionVehiculo { VersionId = 10, NombreVersion = "1.6 5P Energy", PrecioBase = 12900000, ModeloId = 4 },
                new VersionVehiculo { VersionId = 11, NombreVersion = "1.4 5P Edge TDCI", PrecioBase = 5000000, ModeloId = 4 },
                new VersionVehiculo { VersionId = 12, NombreVersion = "Max 1.4 4P Ambiente TDCI", PrecioBase = 5200000, ModeloId = 4 },
                new VersionVehiculo { VersionId = 13, NombreVersion = "2.3 DC 4X2 L/05 XL Plus", PrecioBase = 12600000, ModeloId = 5 },
                new VersionVehiculo { VersionId = 14, NombreVersion = "3.0 TDI DC 4x2 L/06 XL", PrecioBase = 58500000, ModeloId = 5 },
                new VersionVehiculo { VersionId = 15, NombreVersion = "3.0 Cd Xl Plus", PrecioBase = 9800000, ModeloId = 5 },
                new VersionVehiculo { VersionId = 16, NombreVersion = "2.0 Se Plus At6", PrecioBase = 8933000, ModeloId = 6 },
                new VersionVehiculo { VersionId = 17, NombreVersion = "1.6 S", PrecioBase = 12000000, ModeloId = 6 },
                new VersionVehiculo { VersionId = 18, NombreVersion = "2.0 Se Plus At", PrecioBase = 10610000, ModeloId = 6 },
                new VersionVehiculo { VersionId = 19, NombreVersion = "2.0 320i Sedan 184cv", PrecioBase = 34900000, ModeloId = 7 },
                new VersionVehiculo { VersionId = 20, NombreVersion = "2.0 320i Sedan Executive", PrecioBase = 19900000, ModeloId = 7 },
                new VersionVehiculo { VersionId = 21, NombreVersion = "2.0 Sdrive 20i Sportline 192cv", PrecioBase = 45000000, ModeloId = 7 },
                new VersionVehiculo { VersionId = 22, NombreVersion = "3.0 530ia Sportline Sedan", PrecioBase = 82900000, ModeloId = 8 },
                new VersionVehiculo { VersionId = 23, NombreVersion = "3.0 530ia Executive 258cv", PrecioBase = 17000000, ModeloId = 8 },
                new VersionVehiculo { VersionId = 24, NombreVersion = "3.0 530ia Sportline", PrecioBase = 47900000, ModeloId = 8 },
                new VersionVehiculo { VersionId = 25, NombreVersion = "Serie 7 4.8 750i Premium 407cv", PrecioBase = 38000000, ModeloId = 9 },
                new VersionVehiculo { VersionId = 26, NombreVersion = "Serie 7 4.8 750ia Premium Stept", PrecioBase = 38000000, ModeloId = 9 },
                new VersionVehiculo { VersionId = 27, NombreVersion = "750i", PrecioBase = 150000000, ModeloId = 9 },
                new VersionVehiculo { VersionId = 28, NombreVersion = "New Like", PrecioBase = 20629500, ModeloId = 10 },
                new VersionVehiculo { VersionId = 29, NombreVersion = "Active Pk", PrecioBase = 22987100, ModeloId = 10 },
                new VersionVehiculo { VersionId = 30, NombreVersion = "Feline AT", PrecioBase = 27530600, ModeloId = 10 },
                new VersionVehiculo { VersionId = 31, NombreVersion = "2.0 Feline 143cv", PrecioBase = 11000000, ModeloId = 11 },
                new VersionVehiculo { VersionId = 32, NombreVersion = "1.6 Cc Thp 156cv", PrecioBase = 22000000, ModeloId = 11 },
                new VersionVehiculo { VersionId = 33, NombreVersion = "2.0 Feline 143cv Tiptronic", PrecioBase = 10600000, ModeloId = 11 },
                new VersionVehiculo { VersionId = 34, NombreVersion = "GT Pack THP", PrecioBase = 57592800, ModeloId = 12 },
                new VersionVehiculo { VersionId = 35, NombreVersion = "2.0 XLI CVT", PrecioBase = 24447000, ModeloId = 13 },
                new VersionVehiculo { VersionId = 36, NombreVersion = "2.0 XEI CVT", PrecioBase = 26468000, ModeloId = 13 },
                new VersionVehiculo { VersionId = 37, NombreVersion = "2.0 SEG CVT", PrecioBase = 29625000, ModeloId = 13 },
                new VersionVehiculo { VersionId = 38, NombreVersion = "Cabina Simple DX 4x2", PrecioBase = 28669000, ModeloId = 14 },
                new VersionVehiculo { VersionId = 39, NombreVersion = "Cabina Simple DX 4x4", PrecioBase = 34566000, ModeloId = 14 },
                new VersionVehiculo { VersionId = 40, NombreVersion = "Cabina Doble DX 4x2", PrecioBase = 32306000, ModeloId = 14 },
                new VersionVehiculo { VersionId = 41, NombreVersion = "X 6 M/T", PrecioBase = 15500000, ModeloId = 15 },
                new VersionVehiculo { VersionId = 42, NombreVersion = "XLS Pack 6 M/T", PrecioBase = 19500000, ModeloId = 15 },
                new VersionVehiculo { VersionId = 43, NombreVersion = "XLS Pack 4 A/T", PrecioBase = 21900000, ModeloId = 15 },
                new VersionVehiculo { VersionId = 44, NombreVersion = "Trendline", PrecioBase = 18900000, ModeloId = 16 },
                new VersionVehiculo { VersionId = 45, NombreVersion = "Comfortline", PrecioBase = 34400000, ModeloId = 16 },
                new VersionVehiculo { VersionId = 46, NombreVersion = "Highline", PrecioBase = 42300000, ModeloId = 16 },
                new VersionVehiculo { VersionId = 47, NombreVersion = "Comfortline", PrecioBase = 32000000, ModeloId = 17 },
                new VersionVehiculo { VersionId = 48, NombreVersion = "Highline", PrecioBase = 40060000, ModeloId = 17 },
                new VersionVehiculo { VersionId = 49, NombreVersion = "Hero", PrecioBase = 39900000, ModeloId = 17 },
                new VersionVehiculo { VersionId = 50, NombreVersion = "ZEN 1.6 SCe", PrecioBase = 27894900, ModeloId = 18 },
                new VersionVehiculo { VersionId = 51, NombreVersion = "STEPWAY 1.6 SCe", PrecioBase = 28584120, ModeloId = 18 },
                new VersionVehiculo { VersionId = 52, NombreVersion = "STEPWAY 1.5 dCi", PrecioBase = 29814964, ModeloId = 18 },
                new VersionVehiculo { VersionId = 53, NombreVersion = "Life 1.6", PrecioBase = 23112016, ModeloId = 19 },
                new VersionVehiculo { VersionId = 54, NombreVersion = "Intens 1.6", PrecioBase = 25036944, ModeloId = 19 },
                new VersionVehiculo { VersionId = 55, NombreVersion = "Intens 1.6 CVT", PrecioBase = 25695754, ModeloId = 19 },
                new VersionVehiculo { VersionId = 56, NombreVersion = "Intens 1.6", PrecioBase = 25120636, ModeloId = 20 },
                new VersionVehiculo { VersionId = 57, NombreVersion = "Intens 1.6 CVT", PrecioBase = 26030524, ModeloId = 20 }
                );
        }
    }
}
