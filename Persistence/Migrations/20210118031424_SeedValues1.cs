﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValues1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Value 101");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Value 102");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Value 103");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Value 01");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Value 02");

            migrationBuilder.UpdateData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Value 03");
        }
    }
}
