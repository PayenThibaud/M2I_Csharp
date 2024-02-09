using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaApi.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ingredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descriptif = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredient", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pizza",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pizza_vegetarienne = table.Column<bool>(type: "bit", nullable: false),
                    pizza_piquante = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizza", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "utilisateur",
                columns: table => new
                {
                    id = table.Column<int>(name: "(id)", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utilisateur", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pizza_ingredient",
                columns: table => new
                {
                    pizza_id = table.Column<int>(type: "int", nullable: false),
                    ingredient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizza_ingredient", x => new { x.pizza_id, x.ingredient_id });
                    table.ForeignKey(
                        name: "FK_pizza_ingredient_ingredient_ingredient_id",
                        column: x => x.ingredient_id,
                        principalTable: "ingredient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pizza_ingredient_pizza_pizza_id",
                        column: x => x.pizza_id,
                        principalTable: "pizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "utilisateur",
                columns: new[] { "(id)", "adresse", "email", "IsAdmin", "nom", "numero", "prenom" },
                values: new object[] { 1, "rue de la rue, Rue", "Titi@gmail.com", true, "ROOT", "0606060606", "Root" });

            migrationBuilder.CreateIndex(
                name: "IX_pizza_ingredient_ingredient_id",
                table: "pizza_ingredient",
                column: "ingredient_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pizza_ingredient");

            migrationBuilder.DropTable(
                name: "utilisateur");

            migrationBuilder.DropTable(
                name: "ingredient");

            migrationBuilder.DropTable(
                name: "pizza");
        }
    }
}
