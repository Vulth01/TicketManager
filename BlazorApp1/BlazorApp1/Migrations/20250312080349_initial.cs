using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentDetails",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Campus = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserContactNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrimaryContact = table.Column<bool>(type: "bit", nullable: false),
                    TroubleshooterName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TroubleshooterEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TroubleshooterContactNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SiteAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EquipmentMake = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EquipmentModel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EquipmentProductNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EquipmentSerialNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FaultDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentDetails");
        }
    }
}
