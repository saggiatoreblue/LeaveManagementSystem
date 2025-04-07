using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePeriodMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Periods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3b9cf7-8c12-4050-a973-2b8e817c788b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e4468ca-b8c4-4f8a-bd56-23865a58fe9f", "AQAAAAIAAYagAAAAEBydp5bIeLHjaYhZFOmu2L04zWqlCpwVTzeUf2nJBvmNdkEvnWXAXx7mzynmLUEulA==", "bc483b1b-14a0-40fd-bd0d-9314c10e4fe4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Periods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3b9cf7-8c12-4050-a973-2b8e817c788b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e234a53-6750-4ab3-b57a-e1a879e13290", "AQAAAAIAAYagAAAAEO4koQUd3fkahbVNRDJrp5Vj9WTNqf8B/Ttn8HcAtSKJcl4n2b/n5mGes/S394o82g==", "e1995ac6-770c-4d53-a073-5bc31d800ebb" });
        }
    }
}
