using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBookingWeb.Data.Migrations
{
    public partial class Updateconstructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TravelTo",
                table: "Travel",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "People",
                table: "Travel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Travel",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "People",
                table: "Travel");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Travel");

            migrationBuilder.AlterColumn<int>(
                name: "TravelTo",
                table: "Travel",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
