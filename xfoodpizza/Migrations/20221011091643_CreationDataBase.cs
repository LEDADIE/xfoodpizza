using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xfoodpizza.Migrations
{
    public partial class CreationDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prix = table.Column<float>(type: "real", nullable: false),
                    vetarienne = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}