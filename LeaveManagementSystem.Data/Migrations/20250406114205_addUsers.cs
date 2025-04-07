using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class addUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1662c23d-0375-4a1f-b8a3-f0c4644ea30e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ff31925-54de-43aa-b5f6-88e43e91f522", "AQAAAAIAAYagAAAAEJHStP7bmJkE9Crn0aFu1TNHfH0Zw9AuC4oYesiyAm2qmeVip0j9DKtyX8ZJNFpg2A==", "83ee7e08-4168-493d-bf4e-0f59b01c8374" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e9c2dec-4e44-430c-9c02-5778c01cc986", "AQAAAAIAAYagAAAAELIBbg59dMBIIl0Aa2L/OF+zKf2jDfgFHXjLDm4FUf+u903XWSHk0609XYe9HhEsug==", "dcf50390-723e-423f-8754-7970cccf5315" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce781dc3-4c3c-44e9-a426-70820115356c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3610d8f9-2e42-4bf5-8266-6759a4e63e2d", "AQAAAAIAAYagAAAAEIdBEwAlsR8vU3S4vjx8HG1Njh++U27rs5HGfqof12JQ2yiD8D6vcQ9G8ovnqBNTSg==", "479d3766-6e11-4cee-9aa5-c95fd8db8ba3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1662c23d-0375-4a1f-b8a3-f0c4644ea30e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a795b022-6510-4851-b32d-1f644c9a07be", "AQAAAAIAAYagAAAAEEJXkNEGZHcBC+EWfuHTweqVp0LIHt58ylCCnEghEMv3wBtOVysmVoyX0OBYCEN+Zg==", "4b0028b8-c02d-48db-b2a8-a1a6f529c686" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc4417a3-ce72-4052-b979-d5d3ad7340ac", "AQAAAAIAAYagAAAAEH7ETeafbJKY7b9WyYwYul55ubmMWbjuNfHEmprFV0AGpW0Zkq5JHIl9mt3WZJeqeg==", "273ed786-e537-4f97-adbc-1541c3afca8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce781dc3-4c3c-44e9-a426-70820115356c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b433055-5277-4636-a571-dcc982132441", "AQAAAAIAAYagAAAAEMt1GvyhDq2yonpGqRK9ckouc+mKR5sGe9NuH7eRfgSwc7Tqil7m+iUhyQyiqa9NuQ==", "e781b6f9-39d6-4d88-80cd-1922295c4eb7" });
        }
    }
}
