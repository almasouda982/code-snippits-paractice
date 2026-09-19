using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppInClass.Migrations
{
    /// <inheritdoc />
    public partial class UserModel_IsLocked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isLocked",
                table: "Users",
                newName: "IsLocked");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsLocked",
                table: "Users",
                newName: "isLocked");
        }
    }
}
