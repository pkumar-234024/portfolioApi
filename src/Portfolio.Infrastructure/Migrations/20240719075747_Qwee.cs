using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class Qwee : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AlterColumn<string>(
              name: "Message",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: true,
              oldClrType: typeof(string),
              oldType: "nvarchar(max)");

          migrationBuilder.AlterColumn<string>(
              name: "InnerMessage",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: true,
              oldClrType: typeof(string),
              oldType: "nvarchar(max)");

          migrationBuilder.AlterColumn<string>(
              name: "ContollerName",
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
              name: "Message",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "",
              oldClrType: typeof(string),
              oldType: "nvarchar(max)",
              oldNullable: true);

          migrationBuilder.AlterColumn<string>(
              name: "InnerMessage",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "",
              oldClrType: typeof(string),
              oldType: "nvarchar(max)",
              oldNullable: true);

          migrationBuilder.AlterColumn<string>(
              name: "ContollerName",
              table: "ErrorLogs",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "",
              oldClrType: typeof(string),
              oldType: "nvarchar(max)",
              oldNullable: true);
      }
  }
