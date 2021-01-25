using Microsoft.EntityFrameworkCore.Migrations;

namespace TurkeyTimeAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Person = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    GlutenFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    Vegetarian = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "GlutenFree", "Name", "Person", "Vegetarian" },
                values: new object[] { 1, false, "Potato Chips", "Jeremy", false });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "GlutenFree", "Name", "Person", "Vegetarian" },
                values: new object[] { 2, false, "Green Bean Casserole", "Amber", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodItems");
        }
    }
}
