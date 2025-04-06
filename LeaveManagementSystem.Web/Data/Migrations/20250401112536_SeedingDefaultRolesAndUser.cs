using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27726be6-987a-4afa-8409-4360ec109238", null, "Supervisor", "SUPERVISOR" },
                    { "4060fb07-0659-4749-b140-c9f62627dc96", null, "Employee", "EMPLOYEE" },
                    { "f8ccf9e1-4ed7-43f3-b5d0-4d69e1204998", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bd3b9cf7-8c12-4050-a973-2b8e817c788b", 0, "516c8fbf-1331-43b5-adb2-012c9b5c25c2", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKU3OSKkEoVlP9zrA5Amkb/fm9g+0vFSrkcIv6hiU9DIBo76b6RjVSL46AnF21iqxw==", null, false, "87a1495f-636a-40be-b257-bc1218b3c805", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f8ccf9e1-4ed7-43f3-b5d0-4d69e1204998", "bd3b9cf7-8c12-4050-a973-2b8e817c788b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27726be6-987a-4afa-8409-4360ec109238");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4060fb07-0659-4749-b140-c9f62627dc96");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8ccf9e1-4ed7-43f3-b5d0-4d69e1204998", "bd3b9cf7-8c12-4050-a973-2b8e817c788b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8ccf9e1-4ed7-43f3-b5d0-4d69e1204998");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3b9cf7-8c12-4050-a973-2b8e817c788b");
        }
    }
}
