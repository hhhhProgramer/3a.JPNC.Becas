using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class Vist1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluators_Visits_VisitId",
                table: "Evaluators");

            migrationBuilder.DropIndex(
                name: "IX_Evaluators_VisitId",
                table: "Evaluators");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Evaluators");

            migrationBuilder.AddColumn<int>(
                name: "EvaluatorId",
                table: "Visits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_EvaluatorId",
                table: "Visits",
                column: "EvaluatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Evaluators_EvaluatorId",
                table: "Visits",
                column: "EvaluatorId",
                principalTable: "Evaluators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Evaluators_EvaluatorId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_EvaluatorId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "EvaluatorId",
                table: "Visits");

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Evaluators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Evaluators_VisitId",
                table: "Evaluators",
                column: "VisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluators_Visits_VisitId",
                table: "Evaluators",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
