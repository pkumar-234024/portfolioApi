using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class UpdatwUsersTableId : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AlterColumn<int>(
              name: "UserId",
              table: "Users",
              type: "int",
              nullable: true,
              oldClrType: typeof(string),
              oldType: "nvarchar(max)");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AlterColumn<string>(
              name: "UserId",
              table: "Users",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "",
              oldClrType: typeof(int),
              oldType: "int",
              oldNullable: true);
      }
  }
