using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EconomicStudies_Evaluators_EvaluatorId",
                table: "EconomicStudies");

            migrationBuilder.DropIndex(
                name: "IX_EconomicStudies_EvaluatorId",
                table: "EconomicStudies");

            migrationBuilder.DropColumn(
                name: "EvaluatorId",
                table: "EconomicStudies");

            migrationBuilder.AddColumn<int>(
                name: "EconomicStudyId",
                table: "Visits",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_EconomicStudyId",
                table: "Visits",
                column: "EconomicStudyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_EconomicStudies_EconomicStudyId",
                table: "Visits",
                column: "EconomicStudyId",
                principalTable: "EconomicStudies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_EconomicStudies_EconomicStudyId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_EconomicStudyId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "EconomicStudyId",
                table: "Visits");

            migrationBuilder.AddColumn<int>(
                name: "EvaluatorId",
                table: "EconomicStudies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EconomicStudies_EvaluatorId",
                table: "EconomicStudies",
                column: "EvaluatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_EconomicStudies_Evaluators_EvaluatorId",
                table: "EconomicStudies",
                column: "EvaluatorId",
                principalTable: "Evaluators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
