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
    [Migration("20230425170310_projet")]
    partial class projet
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("Client", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("Date", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Date");
                });

            modelBuilder.Entity("Planification", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("DateId")
                        .HasColumnType("int");

                    b.Property<int>("FilmidFilm")
                        .HasColumnType("int");

                    b.Property<int>("Salleid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("DateId");

                    b.HasIndex("FilmidFilm");

                    b.HasIndex("Salleid");

                    b.ToTable("planifications");
                });

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

            modelBuilder.Entity("PROJETNET.Model.ReservationDTO", b =>
                {
                    b.Property<int>("idRéservation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idRéservation"));

                    b.Property<int>("clientid")
                        .HasColumnType("int");

                    b.Property<int>("positionidPos")
                        .HasColumnType("int");

                    b.HasKey("idRéservation");

                    b.HasIndex("clientid");

                    b.HasIndex("positionidPos");

                    b.ToTable("reservationDTOs");
                });

            modelBuilder.Entity("PROJETNET.Model.salleDTO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("nombrePlaces")
                        .HasColumnType("int");

                    b.Property<string>("statut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("salleDTOs");
                });

            modelBuilder.Entity("positionDTO", b =>
                {
                    b.Property<int>("idPos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPos"));

                    b.HasKey("idPos");

                    b.ToTable("positionDTOs");
                });

            modelBuilder.Entity("Planification", b =>
                {
                    b.HasOne("Date", "Date")
                        .WithMany()
                        .HasForeignKey("DateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROJETNET.Model.FilmDTO", "Film")
                        .WithMany()
                        .HasForeignKey("FilmidFilm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROJETNET.Model.salleDTO", "Salle")
                        .WithMany()
                        .HasForeignKey("Salleid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Date");

                    b.Navigation("Film");

                    b.Navigation("Salle");
                });

            modelBuilder.Entity("PROJETNET.Model.ReservationDTO", b =>
                {
                    b.HasOne("Client", "client")
                        .WithMany()
                        .HasForeignKey("clientid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("positionDTO", "position")
                        .WithMany()
                        .HasForeignKey("positionidPos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");

                    b.Navigation("position");
                });
#pragma warning restore 612, 618
        }
    }
}
