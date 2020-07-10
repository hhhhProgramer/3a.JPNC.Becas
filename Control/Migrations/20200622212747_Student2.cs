using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class Student2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EconomicStudies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    Income = table.Column<int>(nullable: false),
                    Expenses = table.Column<int>(nullable: false),
                    Feeding = table.Column<int>(nullable: false),
                    Rcidence = table.Column<int>(nullable: false),
                    Services = table.Column<string>(nullable: true),
                    Fees = table.Column<int>(nullable: false),
                    Transport = table.Column<int>(nullable: false),
                    Other = table.Column<int>(nullable: false),
                    Distribution = table.Column<int>(nullable: false),
                    Place = table.Column<int>(nullable: false),
                    Material = table.Column<int>(nullable: false),
                    Furniture = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomicStudies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Names = table.Column<string>(nullable: true),
                    Curp = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    Suburb = table.Column<string>(nullable: true),
                    Municipality = table.Column<string>(nullable: true),
                    Locality = table.Column<string>(nullable: true),
                    Disability = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    Correo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tutors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Birthday = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Names = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutors_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    StudyEconomicId = table.Column<int>(nullable: false),
                    economicStudyId = table.Column<int>(nullable: true),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_EconomicStudies_economicStudyId",
                        column: x => x.economicStudyId,
                        principalTable: "EconomicStudies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evaluators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Names = table.Column<string>(nullable: true),
                    VisitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluators_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_StudentId",
                table: "Accounts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluators_VisitId",
                table: "Evaluators",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutors_StudentId",
                table: "Tutors",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_AccountId",
                table: "Visits",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_economicStudyId",
                table: "Visits",
                column: "economicStudyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluators");

            migrationBuilder.DropTable(
                name: "Tutors");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "EconomicStudies");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
