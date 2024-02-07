﻿// <auto-generated />
using System;
using Exo4WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exo4WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateDeNaissance")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("birth_date");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lastname");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("firstname");

                    b.Property<string>("Sexe1")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("gender");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "http://localhost:port/Avatars/force.png",
                            DateDeNaissance = new DateTime(1997, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom = "Fontaine",
                            Prenom = "Benjamin",
                            Sexe1 = "M"
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "http://localhost:port/Avatars/avatar2.png",
                            DateDeNaissance = new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nom = "Dupont",
                            Prenom = "Alice",
                            Sexe1 = "F"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
