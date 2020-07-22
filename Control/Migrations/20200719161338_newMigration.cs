using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rcidence",
                table: "EconomicStudies");

            migrationBuilder.AlterColumn<string>(
                name: "Place",
                table: "EconomicStudies",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Material",
                table: "EconomicStudies",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Recidence",
                table: "EconomicStudies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recidence",
                table: "EconomicStudies");

            migrationBuilder.AlterColumn<int>(
                name: "Place",
                table: "EconomicStudies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Material",
                table: "EconomicStudies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rcidence",
                table: "EconomicStudies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
