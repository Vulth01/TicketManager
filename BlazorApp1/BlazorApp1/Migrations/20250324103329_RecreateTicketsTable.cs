using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    public partial class RecreateTicketsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create the Tickets table based on the Ticket model
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketGuid = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),  // Unique Identifier with default GUID
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Primary key with auto-increment
                    TicketType = table.Column<string>(nullable: true),  // TicketType
                    Username = table.Column<string>(maxLength: 50, nullable: true),  // Username with length constraint
                    UserContactNo = table.Column<string>(maxLength: 50, nullable: true),  // User Contact Number
                    UserEmail = table.Column<string>(maxLength: 100, nullable: true),  // Email
                    SiteAddress = table.Column<string>(maxLength: 200, nullable: true),  // Site Address
                    Description = table.Column<string>(maxLength: 200, nullable: true),  // Description

                    // Laptop Repair Template Fields
                    LaptopSerial = table.Column<string>(maxLength: 50, nullable: true),
                    LaptopMake = table.Column<string>(maxLength: 50, nullable: true),
                    LaptopModel = table.Column<string>(maxLength: 50, nullable: true),

                    // Printer Repair Template Fields
                    PrinterSerial = table.Column<string>(maxLength: 50, nullable: true),
                    PrinterMake = table.Column<string>(maxLength: 50, nullable: true),
                    PrinterModel = table.Column<string>(maxLength: 50, nullable: true),

                    // Template 3 Fields
                    Template3Field1 = table.Column<string>(maxLength: 50, nullable: true),
                    Template3Field2 = table.Column<string>(maxLength: 50, nullable: true),
                    Template3Field3 = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);  // Primary Key on Id
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the Tickets table if rolling back the migration
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
