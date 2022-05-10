using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCinema_BARS_GROUP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");
            
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Name");
        }
    }
}
