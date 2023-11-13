﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tareas_1_Hasta_la_4.Server.DAL;

#nullable disable

namespace Tareas_1_Hasta_la_4.Server.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Tareas_1_Hasta_la_4.Shared.Prioridades", b =>
                {
                    b.Property<int>("PrioridadesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DiasCompromiso")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrioridadesId");

                    b.ToTable("Prioridades");
                });
#pragma warning restore 612, 618
        }
    }
}
