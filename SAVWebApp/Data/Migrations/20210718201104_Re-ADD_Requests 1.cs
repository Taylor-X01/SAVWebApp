using Microsoft.EntityFrameworkCore.Migrations;

namespace SAVWebApp.Data.Migrations
{
    public partial class ReADD_Requests1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "passwd",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "passwd",
                table: "Client");
        }
    }
}
