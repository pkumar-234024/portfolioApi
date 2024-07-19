using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class Asdf : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AlterColumn<string>(
              name: "StackTrace",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: true,
              oldClrType: typeof(string),
              oldType: "nvarchar(max)");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AlterColumn<string>(
              name: "StackTrace",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "",
              oldClrType: typeof(string),
              oldType: "nvarchar(max)",
              oldNullable: true);
      }
  }
