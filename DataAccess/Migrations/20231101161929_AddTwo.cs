using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Users_Id",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salads_Users_Id",
                table: "Salads");

            migrationBuilder.DropForeignKey(
                name: "FK_Sushis_Users_Id",
                table: "Sushis");

            migrationBuilder.AddColumn<int>(
                name: "UserCredentialsId",
                table: "Sushis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserCredentialsId",
                table: "Salads",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserCredentialsId",
                table: "Pizzas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sushis_UserCredentialsId",
                table: "Sushis",
                column: "UserCredentialsId");

            migrationBuilder.CreateIndex(
                name: "IX_Salads_UserCredentialsId",
                table: "Salads",
                column: "UserCredentialsId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_UserCredentialsId",
                table: "Pizzas",
                column: "UserCredentialsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Users_UserCredentialsId",
                table: "Pizzas",
                column: "UserCredentialsId",
                principalTable: "Users",
                principalColumn: "CredentialsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salads_Users_UserCredentialsId",
                table: "Salads",
                column: "UserCredentialsId",
                principalTable: "Users",
                principalColumn: "CredentialsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sushis_Users_UserCredentialsId",
                table: "Sushis",
                column: "UserCredentialsId",
                principalTable: "Users",
                principalColumn: "CredentialsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Users_UserCredentialsId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salads_Users_UserCredentialsId",
                table: "Salads");

            migrationBuilder.DropForeignKey(
                name: "FK_Sushis_Users_UserCredentialsId",
                table: "Sushis");

            migrationBuilder.DropIndex(
                name: "IX_Sushis_UserCredentialsId",
                table: "Sushis");

            migrationBuilder.DropIndex(
                name: "IX_Salads_UserCredentialsId",
                table: "Salads");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_UserCredentialsId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "UserCredentialsId",
                table: "Sushis");

            migrationBuilder.DropColumn(
                name: "UserCredentialsId",
                table: "Salads");

            migrationBuilder.DropColumn(
                name: "UserCredentialsId",
                table: "Pizzas");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Users_Id",
                table: "Pizzas",
                column: "Id",
                principalTable: "Users",
                principalColumn: "CredentialsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salads_Users_Id",
                table: "Salads",
                column: "Id",
                principalTable: "Users",
                principalColumn: "CredentialsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sushis_Users_Id",
                table: "Sushis",
                column: "Id",
                principalTable: "Users",
                principalColumn: "CredentialsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
