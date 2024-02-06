﻿// <auto-generated />
using System;
using Exo4WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exo4WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240206101804_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Exo4WebAPI.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomComplet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexe1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "http://localhost:port/Avatars/force.png",
                            DateDeNaissance = new DateTime(1997, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom = "Benjamin",
                            NomComplet = "Benjamin Fontaine",
                            Prenom = "Fontaine",
                            Sexe1 = 0
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "http://localhost:port/Avatars/avatar2.png",
                            DateDeNaissance = new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom = "Alice",
                            NomComplet = "Alice Dupont",
                            Prenom = "Dupont",
                            Sexe1 = 1
                        },
                        new
                        {
                            Id = 3,
                            Avatar = "http://localhost:port/Avatars/avatar3.png",
                            DateDeNaissance = new DateTime(1985, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom = "Louis",
                            NomComplet = "Louis Lefevre",
                            Prenom = "Lefevre",
                            Sexe1 = 0
                        },
                        new
                        {
                            Id = 4,
                            Avatar = "http://localhost:port/Avatars/avatar4.png",
                            DateDeNaissance = new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom = "Sophie",
                            NomComplet = "Sophie Martin",
                            Prenom = "Martin",
                            Sexe1 = 1
                        },
                        new
                        {
                            Id = 5,
                            Avatar = "http://localhost:port/Avatars/avatar5.png",
                            DateDeNaissance = new DateTime(1980, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom = "Luc",
                            NomComplet = "Luc Robert",
                            Prenom = "Robert",
                            Sexe1 = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
