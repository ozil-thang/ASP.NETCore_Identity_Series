using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentitySeries.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f831a98f-b52f-4971-b3df-afabd358cb3c", "ccf181e9-7e72-4e7f-971d-6ae7ce6d5bee", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f30d700c-2802-461e-b7b5-3c71b41d34d4", "1fd70b61-8521-4b7f-804b-2d05ac6f7d7f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f30d700c-2802-461e-b7b5-3c71b41d34d4", "1fd70b61-8521-4b7f-804b-2d05ac6f7d7f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f831a98f-b52f-4971-b3df-afabd358cb3c", "ccf181e9-7e72-4e7f-971d-6ae7ce6d5bee" });
        }
    }
}
