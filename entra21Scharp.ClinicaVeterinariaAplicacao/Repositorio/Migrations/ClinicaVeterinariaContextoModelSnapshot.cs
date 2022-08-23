﻿// <auto-generated />
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Repositorio.Migrations
{
    [DbContext(typeof(ClinicaVeterinariaContexto))]
    partial class ClinicaVeterinariaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades.Raca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("VARCHAR(160)")
                        .HasColumnName("especie");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("id");

                    b.ToTable("racas", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
