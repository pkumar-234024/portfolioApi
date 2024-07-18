using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;
/// <inheritdoc />
public partial class UpdateTablemig : Migration
{
  /// <inheritdoc />
  protected override void Up(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.AddColumn<int>(
        name: "ProjectTechnologiesId",
        table: "Projects",
        type: "int",
        nullable: true);

    migrationBuilder.CreateTable(
        name: "ProjectTechnologies",
        columns: table => new
        {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
          Technology = table.Column<string>(type: "nvarchar(max)", nullable: false),
          ForntEndTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
          BackENdTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
          DatabseTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
          CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
          IsDeleted = table.Column<bool>(type: "bit", nullable: true),
          IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
          ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_ProjectTechnologies", x => x.Id);
        });

    migrationBuilder.CreateTable(
        name: "Skills",
        columns: table => new
        {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1")
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_Skills", x => x.Id);
        });

    migrationBuilder.CreateTable(
        name: "Tools",
        columns: table => new
        {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1")
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_Tools", x => x.Id);
        });

    migrationBuilder.CreateIndex(
        name: "IX_Projects_ProjectTechnologiesId",
        table: "Projects",
        column: "ProjectTechnologiesId");

    migrationBuilder.AddForeignKey(
        name: "FK_Projects_ProjectTechnologies_ProjectTechnologiesId",
        table: "Projects",
        column: "ProjectTechnologiesId",
        principalTable: "ProjectTechnologies",
        principalColumn: "Id");
  }

  /// <inheritdoc />
  protected override void Down(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.DropForeignKey(
        name: "FK_Projects_ProjectTechnologies_ProjectTechnologiesId",
        table: "Projects");

    migrationBuilder.DropTable(
        name: "ProjectTechnologies");

    migrationBuilder.DropTable(
        name: "Skills");

    migrationBuilder.DropTable(
        name: "Tools");

    migrationBuilder.DropIndex(
        name: "IX_Projects_ProjectTechnologiesId",
        table: "Projects");

    migrationBuilder.DropColumn(
        name: "ProjectTechnologiesId",
        table: "Projects");
  }
}

