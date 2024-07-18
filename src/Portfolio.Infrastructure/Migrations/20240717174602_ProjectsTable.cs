using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class ProjectsTable : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "Projects",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CreadtedBy = table.Column<int>(type: "int", nullable: false),
                  CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                  IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                  IsDeletedBy = table.Column<bool>(type: "bit", nullable: false),
                  ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Projects", x => x.Id);
              });
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "Projects");
      }
  }
