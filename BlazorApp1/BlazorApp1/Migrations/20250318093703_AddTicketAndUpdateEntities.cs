using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketAndUpdateEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyTelNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimeReporter = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimeReporterContact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimeReporterEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PurchaseOrderNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserContactNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SiteAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnderWarranty = table.Column<bool>(type: "bit", nullable: false),
                    WarrantyPackNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaultDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhysicalDamage = table.Column<bool>(type: "bit", nullable: false),
                    Campus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryContact = table.Column<bool>(type: "bit", nullable: false),
                    TroubleshooterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TroubleshooterEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TroubleshooterContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentMake = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentProductNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
