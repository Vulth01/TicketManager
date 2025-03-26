using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddSaltColumnToUserAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentDetails");

            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "user_account",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "user_account");

            migrationBuilder.CreateTable(
                name: "DocumentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Campus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EquipmentMake = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EquipmentModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EquipmentProductNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EquipmentSerialNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaultDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PrimaryContact = table.Column<bool>(type: "bit", nullable: false),
                    SiteAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TroubleshooterContactNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    TroubleshooterEmail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TroubleshooterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserContactNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentDetails", x => x.Id);
                });
        }
    }
}
