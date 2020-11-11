using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrgApp.Migrations
{
    public partial class Org : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTypes_Organizations_OrganizationId",
                table: "JobTypes");

            migrationBuilder.DropIndex(
                name: "IX_JobTypes_OrganizationId",
                table: "JobTypes");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "JobTypes");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "OrgJobType",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrgJobType_OrganizationId",
                table: "OrgJobType",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_JobTypeId",
                table: "Organizations",
                column: "JobTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_JobTypes_JobTypeId",
                table: "Organizations",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgJobType_Organizations_OrganizationId",
                table: "OrgJobType",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_JobTypes_JobTypeId",
                table: "Organizations");

            migrationBuilder.DropForeignKey(
                name: "FK_OrgJobType_Organizations_OrganizationId",
                table: "OrgJobType");

            migrationBuilder.DropIndex(
                name: "IX_OrgJobType_OrganizationId",
                table: "OrgJobType");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_JobTypeId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "OrgJobType");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "JobTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobTypes_OrganizationId",
                table: "JobTypes",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTypes_Organizations_OrganizationId",
                table: "JobTypes",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
