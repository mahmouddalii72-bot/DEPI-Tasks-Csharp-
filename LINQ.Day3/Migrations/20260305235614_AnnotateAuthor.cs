using Microsoft.EntityFrameworkCore.Migrations;

namespace LINQ.Day3.Migrations
{
    public partial class AnnotateAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors1",
                table: "Authors1");

            migrationBuilder.RenameTable(
                name: "Authors1",
                newName: "Writers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writers",
                table: "Writers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Writers",
                table: "Writers");

            migrationBuilder.RenameTable(
                name: "Writers",
                newName: "Authors1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors1",
                table: "Authors1",
                column: "Id");
        }
    }
}
