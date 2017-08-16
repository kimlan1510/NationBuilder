using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationBuilder.Migrations
{
    public partial class AddWealth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weath",
                table: "Nations");

            migrationBuilder.AddColumn<int>(
                name: "Wealth",
                table: "Nations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wealth",
                table: "Nations");

            migrationBuilder.AddColumn<string>(
                name: "Weath",
                table: "Nations",
                nullable: true);
        }
    }
}
