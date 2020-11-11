using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrgApp.Migrations
{
    public partial class JobTypeModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "JobTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "JobTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "JobTypes");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "JobTypes");
        }
    }
}
