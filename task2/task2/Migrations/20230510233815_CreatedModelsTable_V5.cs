using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task2.Migrations
{
    public partial class CreatedModelsTable_V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Markas_MarkaId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_MarkaId",
                table: "Models");

            migrationBuilder.AddColumn<int>(
                name: "MarkaId1",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Markas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Models_MarkaId1",
                table: "Models",
                column: "MarkaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Markas_MarkaId1",
                table: "Models",
                column: "MarkaId1",
                principalTable: "Markas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Markas_MarkaId1",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_MarkaId1",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "MarkaId1",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Markas");

            migrationBuilder.CreateIndex(
                name: "IX_Models_MarkaId",
                table: "Models",
                column: "MarkaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Markas_MarkaId",
                table: "Models",
                column: "MarkaId",
                principalTable: "Markas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
