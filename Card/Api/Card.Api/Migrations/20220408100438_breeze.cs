using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Card.Api.Migrations
{
    public partial class breeze : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "modals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_modals",
                table: "modals",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_modals",
                table: "modals");

            migrationBuilder.RenameTable(
                name: "modals",
                newName: "Cards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "id");
        }
    }
}
