using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SushiIngridients",
                table: "SushiIngridients");

            migrationBuilder.DropIndex(
                name: "IX_SushiIngridients_SushiId",
                table: "SushiIngridients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaladIngridients",
                table: "SaladIngridients");

            migrationBuilder.DropIndex(
                name: "IX_SaladIngridients_SaladId",
                table: "SaladIngridients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaIngridients",
                table: "PizzaIngridients");

            migrationBuilder.DropIndex(
                name: "IX_PizzaIngridients_PizzaId",
                table: "PizzaIngridients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SushiIngridients",
                table: "SushiIngridients",
                columns: new[] { "SushiId", "IngridientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaladIngridients",
                table: "SaladIngridients",
                columns: new[] { "SaladId", "IngridientId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaIngridients",
                table: "PizzaIngridients",
                columns: new[] { "PizzaId", "IngridientId" });

            migrationBuilder.CreateIndex(
                name: "IX_SushiIngridients_IngridientId",
                table: "SushiIngridients",
                column: "IngridientId");

            migrationBuilder.CreateIndex(
                name: "IX_SaladIngridients_IngridientId",
                table: "SaladIngridients",
                column: "IngridientId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaIngridients_IngridientId",
                table: "PizzaIngridients",
                column: "IngridientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SushiIngridients",
                table: "SushiIngridients");

            migrationBuilder.DropIndex(
                name: "IX_SushiIngridients_IngridientId",
                table: "SushiIngridients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaladIngridients",
                table: "SaladIngridients");

            migrationBuilder.DropIndex(
                name: "IX_SaladIngridients_IngridientId",
                table: "SaladIngridients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaIngridients",
                table: "PizzaIngridients");

            migrationBuilder.DropIndex(
                name: "IX_PizzaIngridients_IngridientId",
                table: "PizzaIngridients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SushiIngridients",
                table: "SushiIngridients",
                columns: new[] { "IngridientId", "SushiId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaladIngridients",
                table: "SaladIngridients",
                columns: new[] { "IngridientId", "SaladId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaIngridients",
                table: "PizzaIngridients",
                columns: new[] { "IngridientId", "PizzaId" });

            migrationBuilder.CreateIndex(
                name: "IX_SushiIngridients_SushiId",
                table: "SushiIngridients",
                column: "SushiId");

            migrationBuilder.CreateIndex(
                name: "IX_SaladIngridients_SaladId",
                table: "SaladIngridients",
                column: "SaladId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaIngridients_PizzaId",
                table: "PizzaIngridients",
                column: "PizzaId");
        }
    }
}
