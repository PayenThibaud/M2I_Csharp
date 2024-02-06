using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exo4WebAPI.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexe1 = table.Column<int>(type: "int", nullable: false),
                    DateDeNaissance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Avatar", "DateDeNaissance", "Nom", "Prenom", "Sexe1" },
                values: new object[,]
                {
                    { 1, "http://localhost:port/Avatars/force.png", new DateTime(1997, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Benjamin", "Fontaine", 0 },
                    { 2, "http://localhost:port/Avatars/avatar2.png", new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", "Dupont", 1 },
                    { 3, "http://localhost:port/Avatars/avatar3.png", new DateTime(1985, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louis", "Lefevre", 0 },
                    { 4, "http://localhost:port/Avatars/avatar4.png", new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophie", "Martin", 1 },
                    { 5, "http://localhost:port/Avatars/avatar5.png", new DateTime(1980, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luc", "Robert", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
