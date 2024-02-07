using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exo4WebAPI.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    birth_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "id", "Avatar", "birth_date", "lastname", "firstname", "gender" },
                values: new object[] { 1, "http://localhost:port/Avatars/force.png", new DateTime(1997, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fontaine", "Benjamin", "M" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "id", "Avatar", "birth_date", "lastname", "firstname", "gender" },
                values: new object[] { 2, "http://localhost:port/Avatars/avatar2.png", new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dupont", "Alice", "F" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
