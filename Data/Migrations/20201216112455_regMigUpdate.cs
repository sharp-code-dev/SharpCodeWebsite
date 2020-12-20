using Microsoft.EntityFrameworkCore.Migrations;

namespace SharpCodeWebsite.Data.Migrations
{
    public partial class regMigUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Registration");

            migrationBuilder.AlterColumn<string>(
                name: "Program",
                table: "Registration",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Program",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Registration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
