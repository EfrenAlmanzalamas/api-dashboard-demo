using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalAPIDemo.Migrations
{
    public partial class UserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Barnch",
                table: "Employees",
                newName: "Branch");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Branch",
                table: "Employees",
                newName: "Barnch");
        }
    }
}
