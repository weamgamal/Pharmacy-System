using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CompanyPrice",
                table: "Medicine",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Profit",
                table: "Medicine",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalProfit",
                table: "MedBills",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CompanyPrice", "Profit" },
                values: new object[] { 40.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CompanyPrice", "Profit" },
                values: new object[] { 15.0, 5.0 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CompanyPrice", "Profit" },
                values: new object[] { 80.0, 20.0 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CompanyPrice", "Profit" },
                values: new object[] { 8.9499999999999993, 2.0 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CompanyPrice", "Profit", "UnitPrice" },
                values: new object[] { 120.0, 30.0, 150.0 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CompanyPrice", "Profit", "UnitPrice" },
                values: new object[] { 65.0, 15.0, 80.0 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CompanyPrice", "Profit", "UnitPrice" },
                values: new object[] { 36.5, 3.0, 39.5 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CompanyPrice", "Profit", "UnitPrice" },
                values: new object[] { 85.0, 15.0, 100.0 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CompanyPrice", "Profit" },
                values: new object[] { 85.0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CompanyPrice", "Profit" },
                values: new object[] { 8.5, 1.5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyPrice",
                table: "Medicine");

            migrationBuilder.DropColumn(
                name: "Profit",
                table: "Medicine");

            migrationBuilder.DropColumn(
                name: "TotalProfit",
                table: "MedBills");

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 5,
                column: "UnitPrice",
                value: 150000.0);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 6,
                column: "UnitPrice",
                value: 20000.0);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 7,
                column: "UnitPrice",
                value: 80.0);

            migrationBuilder.UpdateData(
                table: "Medicine",
                keyColumn: "ID",
                keyValue: 8,
                column: "UnitPrice",
                value: 39.5);
        }
    }
}
