﻿// <auto-generated />
using System;
using DataCore.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataCore.Core.Migrations
{
    [DbContext(typeof(FutbolContext))]
    [Migration("20181002191813_addEquipoViewIndex")]
    partial class addEquipoViewIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataCore.Core.Entities.Division", b =>
                {
                    b.Property<int>("DivisionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.HasKey("DivisionId");

                    b.ToTable("Division");
                });

            modelBuilder.Entity("DataCore.Core.Entities.Equipo", b =>
                {
                    b.Property<long>("EquipoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DivisionId");

                    b.Property<DateTime?>("FechaInaguracion");

                    b.Property<string>("Nombre");

                    b.Property<int>("PaisId");

                    b.HasKey("EquipoId");

                    b.HasIndex("DivisionId");

                    b.HasIndex("PaisId");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("DataCore.Core.Entities.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("PaisId");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("DataCore.Core.Entities.Equipo", b =>
                {
                    b.HasOne("DataCore.Core.Entities.Division", "Division")
                        .WithMany("Equipo")
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataCore.Core.Entities.Pais", "Pais")
                        .WithMany("Equipo")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
