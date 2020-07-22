using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "EconomicStudies",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "EconomicStudies",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
