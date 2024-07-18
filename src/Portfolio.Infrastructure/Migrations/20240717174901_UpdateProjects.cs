using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class UpdateProjects : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AddColumn<int>(
              name: "UsersId",
              table: "Projects",
              type: "int",
              nullable: true);

          migrationBuilder.CreateIndex(
              name: "IX_Projects_UsersId",
              table: "Projects",
              column: "UsersId");

          migrationBuilder.AddForeignKey(
              name: "FK_Projects_Users_UsersId",
              table: "Projects",
              column: "UsersId",
              principalTable: "Users",
              principalColumn: "Id");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropForeignKey(
              name: "FK_Projects_Users_UsersId",
              table: "Projects");

          migrationBuilder.DropIndex(
              name: "IX_Projects_UsersId",
              table: "Projects");

          migrationBuilder.DropColumn(
              name: "UsersId",
              table: "Projects");
      }
  }
