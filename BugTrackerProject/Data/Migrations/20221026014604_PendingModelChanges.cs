using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTrackerProject.Data.Migrations
{
    public partial class PendingModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 26, 1, 46, 4, 112, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 26, 1, 46, 4, 112, DateTimeKind.Utc).AddTicks(5731));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 25, 22, 42, 23, 907, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 25, 22, 42, 23, 907, DateTimeKind.Utc).AddTicks(71));
        }
    }
}
