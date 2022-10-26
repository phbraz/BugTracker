using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTrackerProject.Data.Migrations
{
    public partial class AddTicketNumberToIssues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TicketNumber",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "TicketNumber" },
                values: new object[] { new DateTime(2022, 10, 25, 22, 42, 23, 907, DateTimeKind.Utc).AddTicks(70), "BT-01" });

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "TicketNumber" },
                values: new object[] { new DateTime(2022, 10, 25, 22, 42, 23, 907, DateTimeKind.Utc).AddTicks(71), "BT-02" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketNumber",
                table: "Issues");

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
