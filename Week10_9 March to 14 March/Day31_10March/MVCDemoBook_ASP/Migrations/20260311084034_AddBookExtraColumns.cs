using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDemoBook_ASP.Migrations
{
    /// <inheritdoc />
    public partial class AddBookExtraColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "tblBook",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pages",
                table: "tblBook",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "tblBook");

            migrationBuilder.DropColumn(
                name: "Pages",
                table: "tblBook");
        }
    }
}
