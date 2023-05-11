using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task2.Migrations
{
    public partial class CreatedModelsTable_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Markas_MarkaId",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_MarkaId",
                table: "Models");
        }
    }
}
