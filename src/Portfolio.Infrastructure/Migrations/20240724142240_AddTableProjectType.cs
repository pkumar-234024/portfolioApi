using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class AddTableProjectType : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "ProjectsType",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  ProjectType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                  CreadtedBy = table.Column<int>(type: "int", nullable: true),
                  IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                  IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
                  ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                  ProjectsId = table.Column<int>(type: "int", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_ProjectsType", x => x.Id);
                  table.ForeignKey(
                      name: "FK_ProjectsType_Projects_ProjectsId",
                      column: x => x.ProjectsId,
                      principalTable: "Projects",
                      principalColumn: "Id");
              });

          migrationBuilder.CreateIndex(
              name: "IX_ProjectsType_ProjectsId",
              table: "ProjectsType",
              column: "ProjectsId");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "ProjectsType");
      }
  }
