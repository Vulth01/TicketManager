using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Campus",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CompanyTelNo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EquipmentMake",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EquipmentModel",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EquipmentProductNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EquipmentSerialNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "FaultDescription",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PhysicalDamage",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PrimaryContact",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PrimeReporter",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PrimeReporterContact",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PrimeReporterEmail",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TroubleshooterContactNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TroubleshooterEmail",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TroubleshooterName",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "UnderWarranty",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "WarrantyPackNumber",
                table: "Tickets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyTelNo",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentMake",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentModel",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentProductNumber",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentSerialNumber",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FaultDescription",
                table: "Tickets",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PhysicalDamage",
                table: "Tickets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PrimaryContact",
                table: "Tickets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PrimeReporter",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrimeReporterContact",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrimeReporterEmail",
                table: "Tickets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductID",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PurchaseOrderNumber",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TroubleshooterContactNumber",
                table: "Tickets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TroubleshooterEmail",
                table: "Tickets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TroubleshooterName",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "UnderWarranty",
                table: "Tickets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "WarrantyPackNumber",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
