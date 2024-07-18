using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

/// <inheritdoc />
public partial class AddTables : Migration
{
  /// <inheritdoc />
  protected override void Up(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.RenameColumn(
        name: "ProjectDescription",
        table: "Projects",
        newName: "ProjectURL");

    migrationBuilder.AlterColumn<string>(
        name: "LastName",
        table: "Users",
        type: "nvarchar(max)",
        nullable: false,
        defaultValue: "",
        oldClrType: typeof(string),
        oldType: "nvarchar(max)",
        oldNullable: true);

    migrationBuilder.AlterColumn<string>(
        name: "FirstName",
        table: "Users",
        type: "nvarchar(max)",
        nullable: false,
        defaultValue: "",
        oldClrType: typeof(string),
        oldType: "nvarchar(max)",
        oldNullable: true);

    migrationBuilder.AddColumn<string>(
        name: "City",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "ContactNumber",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "Country",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "Email",
        table: "Users",
        type: "nvarchar(max)",
        nullable: false,
        defaultValue: "");

    migrationBuilder.AddColumn<string>(
        name: "FullName",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "Password",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "PinCode",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "State",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "Summary",
        table: "Users",
        type: "nvarchar(max)",
        nullable: false,
        defaultValue: "");

    migrationBuilder.AddColumn<string>(
        name: "UserId",
        table: "Users",
        type: "nvarchar(max)",
        nullable: false,
        defaultValue: "");

    migrationBuilder.AlterColumn<DateTime>(
        name: "ModifiedDate",
        table: "Projects",
        type: "datetime2",
        nullable: true,
        oldClrType: typeof(DateTime),
        oldType: "datetime2");

    migrationBuilder.AddColumn<bool>(
        name: "IsStatus",
        table: "Projects",
        type: "bit",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "ProjectImageUrl",
        table: "Projects",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "ProjectLongDescription",
        table: "Projects",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<string>(
        name: "ProjectShortDescription",
        table: "Projects",
        type: "nvarchar(max)",
        nullable: true);

    migrationBuilder.AddColumn<int>(
        name: "ProjectTechnologies",
        table: "Projects",
        type: "int",
        nullable: false,
        defaultValue: 0);

    migrationBuilder.AddColumn<int>(
        name: "ProjectsTypeId",
        table: "Projects",
        type: "int",
        nullable: false,
        defaultValue: 0);

    migrationBuilder.CreateTable(
        name: "SocialMediaAccount",
        columns: table => new
        {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
          ProfileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
          ProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
          CreadtedBy = table.Column<int>(type: "int", nullable: false),
          CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
          IsDeleted = table.Column<bool>(type: "bit", nullable: true),
          IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
          ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
          UsersId = table.Column<int>(type: "int", nullable: true)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_SocialMediaAccount", x => x.Id);
          table.ForeignKey(
                      name: "FK_SocialMediaAccount_Users_UsersId",
                      column: x => x.UsersId,
                      principalTable: "Users",
                      principalColumn: "Id");
        });

    migrationBuilder.CreateTable(
        name: "UserDocument",
        columns: table => new
        {
          Id = table.Column<int>(type: "int", nullable: false)
                .Annotation("SqlServer:Identity", "1, 1"),
          ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
          ResumeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
          CvUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
          CreadtedBy = table.Column<int>(type: "int", nullable: false),
          CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
          IsDeleted = table.Column<bool>(type: "bit", nullable: true),
          IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
          ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
          UsersId = table.Column<int>(type: "int", nullable: true)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_UserDocument", x => x.Id);
          table.ForeignKey(
                      name: "FK_UserDocument_Users_UsersId",
                      column: x => x.UsersId,
                      principalTable: "Users",
                      principalColumn: "Id");
        });

    migrationBuilder.CreateIndex(
        name: "IX_SocialMediaAccount_UsersId",
        table: "SocialMediaAccount",
        column: "UsersId");

    migrationBuilder.CreateIndex(
        name: "IX_UserDocument_UsersId",
        table: "UserDocument",
        column: "UsersId");
  }

  /// <inheritdoc />
  protected override void Down(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.DropTable(
        name: "SocialMediaAccount");

    migrationBuilder.DropTable(
        name: "UserDocument");

    migrationBuilder.DropColumn(
        name: "City",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "ContactNumber",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "Country",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "Email",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "FullName",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "Password",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "PinCode",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "State",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "Summary",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "UserId",
        table: "Users");

    migrationBuilder.DropColumn(
        name: "IsStatus",
        table: "Projects");

    migrationBuilder.DropColumn(
        name: "ProjectImageUrl",
        table: "Projects");

    migrationBuilder.DropColumn(
        name: "ProjectLongDescription",
        table: "Projects");

    migrationBuilder.DropColumn(
        name: "ProjectShortDescription",
        table: "Projects");

    migrationBuilder.DropColumn(
        name: "ProjectTechnologies",
        table: "Projects");

    migrationBuilder.DropColumn(
        name: "ProjectsTypeId",
        table: "Projects");

    migrationBuilder.RenameColumn(
        name: "ProjectURL",
        table: "Projects",
        newName: "ProjectDescription");

    migrationBuilder.AlterColumn<string>(
        name: "LastName",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true,
        oldClrType: typeof(string),
        oldType: "nvarchar(max)");

    migrationBuilder.AlterColumn<string>(
        name: "FirstName",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true,
        oldClrType: typeof(string),
        oldType: "nvarchar(max)");

    migrationBuilder.AlterColumn<DateTime>(
        name: "ModifiedDate",
        table: "Projects",
        type: "datetime2",
        nullable: false,
        defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
        oldClrType: typeof(DateTime),
        oldType: "datetime2",
        oldNullable: true);
  }
}
