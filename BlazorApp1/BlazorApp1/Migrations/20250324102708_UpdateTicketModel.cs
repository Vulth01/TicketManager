using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTicketModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Make",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Tickets",
                newName: "PrinterSerial");

            migrationBuilder.RenameColumn(
                name: "DesktopSerial",
                table: "Tickets",
                newName: "PrinterModel");

            migrationBuilder.AddColumn<string>(
                name: "LaptopModel",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrinterMake",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaptopModel",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PrinterMake",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "PrinterSerial",
                table: "Tickets",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "PrinterModel",
                table: "Tickets",
                newName: "DesktopSerial");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Tickets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
