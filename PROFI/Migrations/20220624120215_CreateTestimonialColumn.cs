using Microsoft.EntityFrameworkCore.Migrations;

namespace PROFI.Migrations
{
    public partial class CreateTestimonialColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Members",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Members");
        }
    }
}
