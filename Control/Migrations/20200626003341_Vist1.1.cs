using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class Vist11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_EconomicStudies_economicStudyId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "StudyEconomicId",
                table: "Visits");

            migrationBuilder.RenameColumn(
                name: "economicStudyId",
                table: "Visits",
                newName: "EconomicStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_economicStudyId",
                table: "Visits",
                newName: "IX_Visits_EconomicStudyId");

            migrationBuilder.AlterColumn<int>(
                name: "EconomicStudyId",
                table: "Visits",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_EconomicStudies_EconomicStudyId",
                table: "Visits",
                column: "EconomicStudyId",
                principalTable: "EconomicStudies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_EconomicStudies_EconomicStudyId",
                table: "Visits");

            migrationBuilder.RenameColumn(
                name: "EconomicStudyId",
                table: "Visits",
                newName: "economicStudyId");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_EconomicStudyId",
                table: "Visits",
                newName: "IX_Visits_economicStudyId");

            migrationBuilder.AlterColumn<int>(
                name: "economicStudyId",
                table: "Visits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "StudyEconomicId",
                table: "Visits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_EconomicStudies_economicStudyId",
                table: "Visits",
                column: "economicStudyId",
                principalTable: "EconomicStudies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
