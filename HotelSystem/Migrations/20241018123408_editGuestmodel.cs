using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelSystem.Migrations
{
    /// <inheritdoc />
    public partial class editGuestmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Guestts");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNum",
                table: "Guestts",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNum",
                table: "Guestts",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Guestts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
