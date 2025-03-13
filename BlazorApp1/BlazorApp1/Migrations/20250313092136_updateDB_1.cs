using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class updateDB_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_account",
                table: "user_account");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "user_account",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "user_account",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "user_account",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "user_account",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "user_account",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "user_account",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "user_account",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_account",
                table: "user_account",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_account",
                table: "user_account");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "user_account",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "user_account",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user_account",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "user_account",
                newName: "user_name");

            migrationBuilder.AlterColumn<string>(
                name: "role",
                table: "user_account",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "user_account",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "user_account",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_account",
                table: "user_account",
                column: "guid");
        }
    }
}
