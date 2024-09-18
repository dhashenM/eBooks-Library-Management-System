using Microsoft.EntityFrameworkCore.Migrations;

namespace eBooks.Migrations
{
    public partial class NameFixAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Prducers_AuthorId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prducers",
                table: "Prducers");

            migrationBuilder.RenameTable(
                name: "Prducers",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Prducers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prducers",
                table: "Prducers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Prducers_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Prducers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
