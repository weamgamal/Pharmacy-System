using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "exist",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "exist",
                table: "MedBills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "exist",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "exist",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "exist",
                table: "Bill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 2,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 3,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 4,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 5,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 6,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 1,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 2,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 3,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 4,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 1,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 2,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 3,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 4,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 5,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 6,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 7,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 8,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 9,
                column: "exist",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 10,
                column: "exist",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "exist",
                table: "Medicine");

            migrationBuilder.DropColumn(
                name: "exist",
                table: "MedBills");

            migrationBuilder.DropColumn(
                name: "exist",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "exist",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "exist",
                table: "Bill");
        }
    }
}
