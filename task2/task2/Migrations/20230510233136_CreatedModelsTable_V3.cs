using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task2.Migrations
{
    public partial class CreatedModelsTable_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarId1",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Models_CarId1",
                table: "Models",
                column: "CarId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Cars_CarId1",
                table: "Models",
                column: "CarId1",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Cars_CarId1",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_CarId1",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "CarId1",
                table: "Models");
        }
    }
}
