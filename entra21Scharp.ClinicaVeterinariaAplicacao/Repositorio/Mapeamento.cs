using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio
{
    internal class Mapeamento : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.ToTable("racas");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.Especie)
                .HasColumnType("VARCHAR")
                .HasMaxLength(160)
                .IsRequired()
                .HasColumnName("especie");

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("nome");

            builder.HasData(new Raca
            {
                Id = 1,
                Nome = "Frajola",
                Especie = "Gato"
            },
            new Raca
            {
                Id = 2,   
                Nome = "Piupiu",
                Especie = "Capivara"
            });

        }
    }
}
