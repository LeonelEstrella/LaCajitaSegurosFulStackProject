using Domain.Entities;
using Infraestructure.Util.DataSet;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculo {  get; set; }
        public DbSet<Marca> Marca {  get; set; }
        public DbSet<Modelo> Modelo {  get; set; }
        public DbSet<VersionVehiculo> Version {  get; set; }
        public DbSet<GNC> GNC { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<RangoEtario> RangoEtario { get; set; }
        public DbSet<AnioVehiculo> AnioVehiculo { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>()
                .HasOne<Marca>(v => v.Marca)
                .WithMany(m => m.Vehiculos)
                .HasForeignKey(v => v.MarcaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehiculo>()
                .HasOne<Modelo>(v => v.Modelo)
                .WithMany(mod => mod.Vehiculos)
                .HasForeignKey(v => v.ModeloId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehiculo>()
                .HasOne<VersionVehiculo>(v => v.VersionVehiculo)
                .WithMany(vv => vv.Vehiculos)
                .HasForeignKey(v => v.VersionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VersionVehiculo>()
                .HasOne<Modelo>(vv => vv.Modelo)
                .WithMany(mod => mod.vehiculoVersiones)
                .HasForeignKey(vv => vv.ModeloId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Modelo>()
                .HasOne<Marca>(mod => mod.Marca)
                .WithMany(marc => marc.Modelos)
                .HasForeignKey(mod => mod.MarcaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfiguration(new AnioVehiculoConfiguracion());
            modelBuilder.ApplyConfiguration(new GNCConfiguracion());
            modelBuilder.ApplyConfiguration(new LocalidadConfiguracion());
            modelBuilder.ApplyConfiguration(new RangoEtarioConfiguracion());
            modelBuilder.ApplyConfiguration(new MarcaConfiguracion());
            modelBuilder.ApplyConfiguration(new ModeloConfiguracion());
            modelBuilder.ApplyConfiguration(new VersionConfiguracion());
        }

    }
}
