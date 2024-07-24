using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class RenameColumnStackTrace : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropColumn(
              name: "StackTrace",
              table: "ErrorLogs");

          migrationBuilder.AddColumn<string>(
              name: "Description",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropColumn(
              name: "Description",
              table: "ErrorLogs");

          migrationBuilder.AddColumn<string>(
              name: "StackTrace",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: true);
      }
  }
