﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projet.data;

#nullable disable

namespace projet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230422173549_initcreate")]
    partial class initcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PROJETNET.Model.FilmDTO", b =>
                {
                    b.Property<int>("idFilm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idFilm"));

                    b.Property<string>("categorie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idFilm");

                    b.ToTable("FilmDTOs");
                });
#pragma warning restore 612, 618
        }
    }
}