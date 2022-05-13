using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCinema_BARS_GROUP.Migrations
{
    public partial class IntialNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Time",
                table: "Reviews",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Reviews");
        }
    }
}
