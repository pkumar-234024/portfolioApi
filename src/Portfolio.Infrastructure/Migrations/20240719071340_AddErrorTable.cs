using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class AddErrorTable : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "ErrorLogs",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  InnerMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  StackTrace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  ContollerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CreadtedBy = table.Column<int>(type: "int", nullable: true),
                  CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                  IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                  IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
                  ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_ErrorLogs", x => x.Id);
              });
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "ErrorLogs");
      }
  }
