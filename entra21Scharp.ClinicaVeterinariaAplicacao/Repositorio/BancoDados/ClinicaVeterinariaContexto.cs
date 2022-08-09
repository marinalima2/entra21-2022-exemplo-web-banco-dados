using Microsoft.EntityFrameworkCore;
using Repositorio.Entidades;

namespace Repositorio.BancoDados
{
    public class ClinicaVeterinariaContexto : DbContext
    {
        public DbSet<Raca> Racas { get; set; }

        public ClinicaVeterinariaContexto(
            DbContextOptions<ClinicaVeterinariaContexto> options) : base(options)
        { }
            

            

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Raca>().ToTable("racas");
        }
    }
}
