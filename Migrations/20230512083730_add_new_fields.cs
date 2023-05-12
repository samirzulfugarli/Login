using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Login.Migrations
{
    /// <inheritdoc />
    public partial class add_new_fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "UserRegisters",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "UserRegisters");
        }
    }
}
