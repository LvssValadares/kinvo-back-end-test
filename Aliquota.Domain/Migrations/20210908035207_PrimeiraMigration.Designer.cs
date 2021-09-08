﻿// <auto-generated />
using Aliquota.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aliquota.Domain.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210908035207_PrimeiraMigration")]
    partial class PrimeiraMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aliquota.Domain.Investimento", b =>
                {
                    b.Property<int>("investimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("aplicação")
                        .HasColumnType("real");

                    b.Property<string>("dataEntrada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataRetirada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("impostoDeRenda")
                        .HasColumnType("real");

                    b.Property<float>("jurosImpostoDeRenda")
                        .HasColumnType("real");

                    b.Property<float>("lucroTotal")
                        .HasColumnType("real");

                    b.Property<float>("redimentoPorMes")
                        .HasColumnType("real");

                    b.HasKey("investimentoId");

                    b.ToTable("Investimentos");
                });

            modelBuilder.Entity("Aliquota.Domain.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("saldo")
                        .HasColumnType("real");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
