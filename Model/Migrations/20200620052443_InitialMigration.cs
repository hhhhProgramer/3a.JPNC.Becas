using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Curp = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    Suburb = table.Column<int>(nullable: false),
                    Municipality = table.Column<int>(nullable: false),
                    Locality = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                });

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
                name: "Evaluators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Names = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluators", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");

            migrationBuilder.DropTable(
                name: "EconomicStudies");

            migrationBuilder.DropTable(
                name: "Evaluators");
        }
    }
}
