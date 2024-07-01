using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnioVehiculo",
                columns: table => new
                {
                    AnioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnioVehiculoDesde = table.Column<int>(type: "int", nullable: false),
                    AnioVehiculoHasta = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnioVehiculo", x => x.AnioId);
                });

            migrationBuilder.CreateTable(
                name: "GNC",
                columns: table => new
                {
                    GNCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasGNC = table.Column<bool>(type: "bit", nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GNC", x => x.GNCId);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    LocalidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.LocalidadId);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMarca = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "RangoEtario",
                columns: table => new
                {
                    EdadRangoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EdadDesde = table.Column<int>(type: "int", nullable: false),
                    EdadHasta = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangoEtario", x => x.EdadRangoId);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    ModeloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreModelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.ModeloId);
                    table.ForeignKey(
                        name: "FK_Modelo_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    VersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.VersionId);
                    table.ForeignKey(
                        name: "FK_Version_Modelo_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelo",
                        principalColumn: "ModeloId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnioVehiculo = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: false),
                    VersionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.VehiculoId);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Modelo_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelo",
                        principalColumn: "ModeloId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Version_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Version",
                        principalColumn: "VersionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AnioVehiculo",
                columns: new[] { "AnioId", "AnioVehiculoDesde", "AnioVehiculoHasta", "Peso" },
                values: new object[,]
                {
                    { 1, 1, 1989, "0.0007" },
                    { 2, 1990, 1999, "0.0005" },
                    { 3, 2000, 2009, "0.0004" },
                    { 4, 2010, 2019, "0.0003" },
                    { 5, 2020, 2024, "0.0001" }
                });

            migrationBuilder.InsertData(
                table: "GNC",
                columns: new[] { "GNCId", "HasGNC", "Peso" },
                values: new object[,]
                {
                    { 1, true, "0.0001" },
                    { 2, false, "0" }
                });

            migrationBuilder.InsertData(
                table: "Localidad",
                columns: new[] { "LocalidadId", "Nombre", "Peso" },
                values: new object[,]
                {
                    { 1, "Morón", "0.0005" },
                    { 2, "San Justo", "0.0006" },
                    { 3, "San Martín", "0.0004" },
                    { 4, "Quilmes", "0.0006" },
                    { 5, "Lanús", "0.0005" },
                    { 6, "Avellaneda", "0.0004" },
                    { 7, "Vicente López", "0.0003" },
                    { 8, "San Isidro", "0.0003" },
                    { 9, "Tigre", "0.0004" },
                    { 10, "San Fernando", "0.0003" },
                    { 11, "Pilar", "0.0004" },
                    { 12, "Escobar", "0.0002" },
                    { 13, "Moreno", "0.0002" },
                    { 14, "Lomas de Zamora", "0.0002" },
                    { 15, "Adrogué", "0.0003" },
                    { 16, "Banfield", "0.0003" },
                    { 17, "Temperley", "0.0002" },
                    { 18, "Hurlingham", "0.0004" },
                    { 19, "Ituzaingó", "0.0004" },
                    { 20, "Castelar", "0.0003" },
                    { 21, "Ramos Mejía", "0.0003" },
                    { 22, "Merlo", "0.0002" },
                    { 23, "Ezeiza", "0.0002" },
                    { 24, "Berazategui", "0.0003" },
                    { 25, "Florencio Varela", "0.0003" },
                    { 26, "General Rodríguez", "0.0002" },
                    { 27, "Villa Ballester", "0.0003" },
                    { 28, "Bella Vista", "0.0002" },
                    { 29, "Ciudadela", "0.0002" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "NombreMarca" },
                values: new object[,]
                {
                    { 1, "Fiat" },
                    { 2, "Ford" },
                    { 3, "BMW" },
                    { 4, "Peugeot" },
                    { 5, "Toyota" },
                    { 6, "Volkswagen" },
                    { 7, "Renault" }
                });

            migrationBuilder.InsertData(
                table: "RangoEtario",
                columns: new[] { "EdadRangoId", "EdadDesde", "EdadHasta", "Peso" },
                values: new object[,]
                {
                    { 1, 18, 40, "0.0005" },
                    { 2, 41, 60, "0.0006" },
                    { 3, 61, 90, "0.0008" }
                });

            migrationBuilder.InsertData(
                table: "Modelo",
                columns: new[] { "ModeloId", "MarcaId", "NombreModelo" },
                values: new object[,]
                {
                    { 1, 1, "Siena" },
                    { 2, 1, "Uno" },
                    { 3, 1, "Palio" },
                    { 4, 2, "Fiesta" },
                    { 5, 2, "Ranger" },
                    { 6, 2, "Focus" },
                    { 7, 3, "320" },
                    { 8, 3, "530" },
                    { 9, 3, "750" },
                    { 10, 4, "208" },
                    { 11, 4, "308" },
                    { 12, 4, "3008" },
                    { 13, 5, "Corolla" },
                    { 14, 5, "Hilux" },
                    { 15, 5, "Etios" },
                    { 16, 6, "Amarok" },
                    { 17, 6, "Taos" },
                    { 18, 7, "Kangoo II" },
                    { 19, 7, "Sandero" },
                    { 20, 7, "Stepway" }
                });

            migrationBuilder.InsertData(
                table: "Version",
                columns: new[] { "VersionId", "ModeloId", "NombreVersion", "PrecioBase" },
                values: new object[,]
                {
                    { 1, 1, "1.4 Fire", 5200000m },
                    { 2, 1, "1.4 Fire Way", 6700000m },
                    { 3, 1, "1.7 ELX TD L/N", 3600000m },
                    { 4, 2, "Cargo 1.3 Fire", 3200000m },
                    { 5, 2, "Fire 1.3 3P LN", 4500000m },
                    { 6, 2, "Fire 1.3 5P LN Pack C II", 8500000m },
                    { 7, 3, "WE 1.8 Adventure", 6487999m },
                    { 8, 3, "1.4 3P ELX Active", 8000000m },
                    { 9, 3, "WE 1.7 TD Adventure X-Treme", 4500000m },
                    { 10, 4, "1.6 5P Energy", 12900000m },
                    { 11, 4, "1.4 5P Edge TDCI", 5000000m },
                    { 12, 4, "Max 1.4 4P Ambiente TDCI", 5200000m },
                    { 13, 5, "2.3 DC 4X2 L/05 XL Plus", 12600000m },
                    { 14, 5, "3.0 TDI DC 4x2 L/06 XL", 58500000m },
                    { 15, 5, "3.0 Cd Xl Plus", 9800000m },
                    { 16, 6, "2.0 Se Plus At6", 8933000m },
                    { 17, 6, "1.6 S", 12000000m },
                    { 18, 6, "2.0 Se Plus At", 10610000m },
                    { 19, 7, "2.0 320i Sedan 184cv", 34900000m },
                    { 20, 7, "2.0 320i Sedan Executive", 19900000m },
                    { 21, 7, "2.0 Sdrive 20i Sportline 192cv", 45000000m },
                    { 22, 8, "3.0 530ia Sportline Sedan", 82900000m },
                    { 23, 8, "3.0 530ia Executive 258cv", 17000000m },
                    { 24, 8, "3.0 530ia Sportline", 47900000m },
                    { 25, 9, "Serie 7 4.8 750i Premium 407cv", 38000000m },
                    { 26, 9, "Serie 7 4.8 750ia Premium Stept", 38000000m },
                    { 27, 9, "750i", 150000000m },
                    { 28, 10, "New Like", 20629500m },
                    { 29, 10, "Active Pk", 22987100m },
                    { 30, 10, "Feline AT", 27530600m },
                    { 31, 11, "2.0 Feline 143cv", 11000000m },
                    { 32, 11, "1.6 Cc Thp 156cv", 22000000m },
                    { 33, 11, "2.0 Feline 143cv Tiptronic", 10600000m },
                    { 34, 12, "GT Pack THP", 57592800m },
                    { 35, 13, "2.0 XLI CVT", 24447000m },
                    { 36, 13, "2.0 XEI CVT", 26468000m },
                    { 37, 13, "2.0 SEG CVT", 29625000m },
                    { 38, 14, "Cabina Simple DX 4x2", 28669000m },
                    { 39, 14, "Cabina Simple DX 4x4", 34566000m },
                    { 40, 14, "Cabina Doble DX 4x2", 32306000m },
                    { 41, 15, "X 6 M/T", 15500000m },
                    { 42, 15, "XLS Pack 6 M/T", 19500000m },
                    { 43, 15, "XLS Pack 4 A/T", 21900000m },
                    { 44, 16, "Trendline", 18900000m },
                    { 45, 16, "Comfortline", 34400000m },
                    { 46, 16, "Highline", 42300000m },
                    { 47, 17, "Comfortline", 32000000m },
                    { 48, 17, "Highline", 40060000m },
                    { 49, 17, "Hero", 39900000m },
                    { 50, 18, "ZEN 1.6 SCe", 27894900m },
                    { 51, 18, "STEPWAY 1.6 SCe", 28584120m },
                    { 52, 18, "STEPWAY 1.5 dCi", 29814964m },
                    { 53, 19, "Life 1.6", 23112016m },
                    { 54, 19, "Intens 1.6", 25036944m },
                    { 55, 19, "Intens 1.6 CVT", 25695754m },
                    { 56, 20, "Intens 1.6", 25120636m },
                    { 57, 20, "Intens 1.6 CVT", 26030524m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_MarcaId",
                table: "Modelo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_MarcaId",
                table: "Vehiculo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ModeloId",
                table: "Vehiculo",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_VersionId",
                table: "Vehiculo",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Version_ModeloId",
                table: "Version",
                column: "ModeloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnioVehiculo");

            migrationBuilder.DropTable(
                name: "GNC");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "RangoEtario");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
