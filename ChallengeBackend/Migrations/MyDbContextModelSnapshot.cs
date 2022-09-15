﻿// <auto-generated />
using System;
using ChallengeBackend.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChallengeBackend.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChallengeBackend.Género", b =>
                {
                    b.Property<int>("GéneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GéneroId"), 1L, 1);

                    b.Property<byte[]>("Imagen")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GéneroId");

                    b.ToTable("Género");
                });

            modelBuilder.Entity("ChallengeBackend.PelículaOSerie", b =>
                {
                    b.Property<int>("PelículaOSerieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PelículaOSerieId"), 1L, 1);

                    b.Property<int>("Calificación")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDeCreación")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GéneroId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Imagen")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Título")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PelículaOSerieId");

                    b.HasIndex("GéneroId");

                    b.ToTable("PelículaOSerie");
                });

            modelBuilder.Entity("ChallengeBackend.Personaje", b =>
                {
                    b.Property<int>("PersonajeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonajeId"), 1L, 1);

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Historia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Imagen")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("PersonajeId");

                    b.ToTable("Personaje");
                });

            modelBuilder.Entity("PelículaOSeriePersonaje", b =>
                {
                    b.Property<int>("PelículaOSerieId")
                        .HasColumnType("int");

                    b.Property<int>("PersonajeId")
                        .HasColumnType("int");

                    b.HasKey("PelículaOSerieId", "PersonajeId");

                    b.HasIndex("PersonajeId");

                    b.ToTable("PelículaOSeriePersonaje");
                });

            modelBuilder.Entity("ChallengeBackend.PelículaOSerie", b =>
                {
                    b.HasOne("ChallengeBackend.Género", null)
                        .WithMany("PelículaOSerie")
                        .HasForeignKey("GéneroId");
                });

            modelBuilder.Entity("PelículaOSeriePersonaje", b =>
                {
                    b.HasOne("ChallengeBackend.PelículaOSerie", null)
                        .WithMany()
                        .HasForeignKey("PelículaOSerieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChallengeBackend.Personaje", null)
                        .WithMany()
                        .HasForeignKey("PersonajeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChallengeBackend.Género", b =>
                {
                    b.Navigation("PelículaOSerie");
                });
#pragma warning restore 612, 618
        }
    }
}
