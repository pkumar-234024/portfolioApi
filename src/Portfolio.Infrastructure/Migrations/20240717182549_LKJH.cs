using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class LKJH : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AlterColumn<bool>(
              name: "IsDeletedBy",
              table: "Projects",
              type: "bit",
              nullable: true,
              oldClrType: typeof(bool),
              oldType: "bit");

          migrationBuilder.AlterColumn<bool>(
              name: "IsDeleted",
              table: "Projects",
              type: "bit",
              nullable: true,
              oldClrType: typeof(bool),
              oldType: "bit");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AlterColumn<bool>(
              name: "IsDeletedBy",
              table: "Projects",
              type: "bit",
              nullable: false,
              defaultValue: false,
              oldClrType: typeof(bool),
              oldType: "bit",
              oldNullable: true);

          migrationBuilder.AlterColumn<bool>(
              name: "IsDeleted",
              table: "Projects",
              type: "bit",
              nullable: false,
              defaultValue: false,
              oldClrType: typeof(bool),
              oldType: "bit",
              oldNullable: true);
      }
  }
