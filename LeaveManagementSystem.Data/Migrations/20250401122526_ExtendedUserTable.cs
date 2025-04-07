using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3b9cf7-8c12-4050-a973-2b8e817c788b",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dbad36e-5e59-438b-a2dd-0a85b9333b6a", new DateOnly(1980, 6, 30), "Michael", "Botelho", "AQAAAAIAAYagAAAAEErNX7NCk0JtyhfoEgGWF23T97bxhVMztN3wzoLp96A9GG4C/R1F08kt6aRVOb7ocw==", "e7a6e0e9-ea8f-4b6d-9c18-cc926047bf5e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3b9cf7-8c12-4050-a973-2b8e817c788b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516c8fbf-1331-43b5-adb2-012c9b5c25c2", "AQAAAAIAAYagAAAAEKU3OSKkEoVlP9zrA5Amkb/fm9g+0vFSrkcIv6hiU9DIBo76b6RjVSL46AnF21iqxw==", "87a1495f-636a-40be-b257-bc1218b3c805" });
        }
    }
}
