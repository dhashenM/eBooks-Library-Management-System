using Microsoft.EntityFrameworkCore.Migrations;

namespace eBooks.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TwoFillustratorEnabled",
                table: "AspNetUsers",
                newName: "TwoFactorEnabled");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                newName: "TwoFillustratorEnabled");
        }
    }
}
