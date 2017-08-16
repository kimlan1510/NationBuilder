using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationBuilder.Migrations
{
    public partial class AddNationNameAndWorkers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Nations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Workers",
                table: "Nations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Nations");

            migrationBuilder.DropColumn(
                name: "Workers",
                table: "Nations");
        }
    }
}
