using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MicroK8s.Api.Migrations
{
    public partial class CountryDateSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            for (int i = 2; i < 258; i++)
            {
                migrationBuilder.UpdateData(
                    table: "Countries", 
                    keyColumn: "Id", 
                    keyValue: i, 
                    columns: new string[] { "CreatedDate", "ModifiedDate" }, 
                    values: new object[] { DateTime.UtcNow.AddDays(-10), DateTime.UtcNow.AddDays(-10) },
                    schema: "Mdm"
                    );
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}