using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroK8s.Api.Migrations
{
    public partial class CountryDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Mdm",
                table: "Countries",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "Mdm",
                table: "Countries",
                nullable: false,
                defaultValueSql: "GetDate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Mdm",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "Mdm",
                table: "Countries");
        }
    }
}
