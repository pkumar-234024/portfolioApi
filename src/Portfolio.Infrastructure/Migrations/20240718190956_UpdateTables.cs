using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class UpdateTables : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropForeignKey(
              name: "FK_Projects_ProjectTechnologies_ProjectTechnologiesId",
              table: "Projects");

          migrationBuilder.DropForeignKey(
              name: "FK_SocialMediaAccount_Users_UsersId",
              table: "SocialMediaAccount");

          migrationBuilder.DropForeignKey(
              name: "FK_UserDocument_Users_UsersId",
              table: "UserDocument");

          migrationBuilder.DropIndex(
              name: "IX_UserDocument_UsersId",
              table: "UserDocument");

          migrationBuilder.DropIndex(
              name: "IX_SocialMediaAccount_UsersId",
              table: "SocialMediaAccount");

          migrationBuilder.DropIndex(
              name: "IX_Projects_ProjectTechnologiesId",
              table: "Projects");

          migrationBuilder.DropColumn(
              name: "Summary",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "UsersId",
              table: "UserDocument");

          migrationBuilder.DropColumn(
              name: "UsersId",
              table: "SocialMediaAccount");

          migrationBuilder.DropColumn(
              name: "ProjectTechnologiesId",
              table: "Projects");

          migrationBuilder.RenameColumn(
              name: "ProjectsTypeId",
              table: "Projects",
              newName: "ProjectsType");

          migrationBuilder.AddColumn<int>(
              name: "AboutId",
              table: "Users",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "AchieveMentId",
              table: "Users",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "CreadtedBy",
              table: "Users",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<DateTime>(
              name: "CreatedDate",
              table: "Users",
              type: "datetime2",
              nullable: false,
              defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

          migrationBuilder.AddColumn<int>(
              name: "EducationsId",
              table: "Users",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "ExperienceId",
              table: "Users",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<bool>(
              name: "IsDeleted",
              table: "Users",
              type: "bit",
              nullable: true);

          migrationBuilder.AddColumn<bool>(
              name: "IsDeletedBy",
              table: "Users",
              type: "bit",
              nullable: true);

          migrationBuilder.AddColumn<DateTime>(
              name: "ModifiedDate",
              table: "Users",
              type: "datetime2",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "SkillsId",
              table: "Users",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "SocialMediaAccountId",
              table: "Users",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "UserDocumentId",
              table: "Users",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<DateTime>(
              name: "CreatedDate",
              table: "Tools",
              type: "datetime2",
              nullable: false,
              defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

          migrationBuilder.AddColumn<bool>(
              name: "IsDeleted",
              table: "Tools",
              type: "bit",
              nullable: true);

          migrationBuilder.AddColumn<bool>(
              name: "IsDeletedBy",
              table: "Tools",
              type: "bit",
              nullable: true);

          migrationBuilder.AddColumn<DateTime>(
              name: "ModifiedDate",
              table: "Tools",
              type: "datetime2",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "Users",
              table: "Tools",
              type: "int",
              nullable: false,
              defaultValue: 0);

          migrationBuilder.AddColumn<DateTime>(
              name: "CreatedDate",
              table: "Skills",
              type: "datetime2",
              nullable: false,
              defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

          migrationBuilder.AddColumn<bool>(
              name: "IsDeleted",
              table: "Skills",
              type: "bit",
              nullable: true);

          migrationBuilder.AddColumn<bool>(
              name: "IsDeletedBy",
              table: "Skills",
              type: "bit",
              nullable: true);

          migrationBuilder.AddColumn<DateTime>(
              name: "ModifiedDate",
              table: "Skills",
              type: "datetime2",
              nullable: true);

          migrationBuilder.AddColumn<string>(
              name: "Skill",
              table: "Skills",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "");

          migrationBuilder.AddColumn<string>(
              name: "SkilsType",
              table: "Skills",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "");

          migrationBuilder.AddColumn<int>(
              name: "Users",
              table: "Skills",
              type: "int",
              nullable: false,
              defaultValue: 0);

          migrationBuilder.AddColumn<int>(
              name: "ProjectsId",
              table: "ProjectTechnologies",
              type: "int",
              nullable: true);

          migrationBuilder.CreateTable(
              name: "About",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  FluentIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  FieldOfInterest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  FieldOfInterestOthers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  PassionFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  Acticity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  CreadtedBy = table.Column<int>(type: "int", nullable: false),
                  CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                  IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                  IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
                  ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_About", x => x.Id);
              });

          migrationBuilder.CreateTable(
              name: "AchieveMent",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CertificateUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  CreadtedBy = table.Column<int>(type: "int", nullable: false),
                  CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                  IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                  IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
                  ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_AchieveMent", x => x.Id);
              });

          migrationBuilder.CreateTable(
              name: "Educations",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  UniversityOrInstitute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CourseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CourseDurationFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CourseDurationFromTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Marks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CreadtedBy = table.Column<int>(type: "int", nullable: false),
                  CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                  IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                  IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
                  ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Educations", x => x.Id);
              });

          migrationBuilder.CreateTable(
              name: "Experience",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  CurrewntEmployee = table.Column<bool>(type: "bit", nullable: false),
                  EmploymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  CurrentCompantyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  RoleCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  WorkingFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  WorkingTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  CreadtedBy = table.Column<int>(type: "int", nullable: false),
                  CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                  IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                  IsDeletedBy = table.Column<bool>(type: "bit", nullable: true),
                  ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Experience", x => x.Id);
              });

          migrationBuilder.CreateIndex(
              name: "IX_Users_AboutId",
              table: "Users",
              column: "AboutId");

          migrationBuilder.CreateIndex(
              name: "IX_Users_AchieveMentId",
              table: "Users",
              column: "AchieveMentId");

          migrationBuilder.CreateIndex(
              name: "IX_Users_EducationsId",
              table: "Users",
              column: "EducationsId");

          migrationBuilder.CreateIndex(
              name: "IX_Users_ExperienceId",
              table: "Users",
              column: "ExperienceId");

          migrationBuilder.CreateIndex(
              name: "IX_Users_SkillsId",
              table: "Users",
              column: "SkillsId");

          migrationBuilder.CreateIndex(
              name: "IX_Users_SocialMediaAccountId",
              table: "Users",
              column: "SocialMediaAccountId");

          migrationBuilder.CreateIndex(
              name: "IX_Users_UserDocumentId",
              table: "Users",
              column: "UserDocumentId");

          migrationBuilder.CreateIndex(
              name: "IX_ProjectTechnologies_ProjectsId",
              table: "ProjectTechnologies",
              column: "ProjectsId");

          migrationBuilder.AddForeignKey(
              name: "FK_ProjectTechnologies_Projects_ProjectsId",
              table: "ProjectTechnologies",
              column: "ProjectsId",
              principalTable: "Projects",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Users_About_AboutId",
              table: "Users",
              column: "AboutId",
              principalTable: "About",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Users_AchieveMent_AchieveMentId",
              table: "Users",
              column: "AchieveMentId",
              principalTable: "AchieveMent",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Users_Educations_EducationsId",
              table: "Users",
              column: "EducationsId",
              principalTable: "Educations",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Users_Experience_ExperienceId",
              table: "Users",
              column: "ExperienceId",
              principalTable: "Experience",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Users_Skills_SkillsId",
              table: "Users",
              column: "SkillsId",
              principalTable: "Skills",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Users_SocialMediaAccount_SocialMediaAccountId",
              table: "Users",
              column: "SocialMediaAccountId",
              principalTable: "SocialMediaAccount",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Users_UserDocument_UserDocumentId",
              table: "Users",
              column: "UserDocumentId",
              principalTable: "UserDocument",
              principalColumn: "Id");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropForeignKey(
              name: "FK_ProjectTechnologies_Projects_ProjectsId",
              table: "ProjectTechnologies");

          migrationBuilder.DropForeignKey(
              name: "FK_Users_About_AboutId",
              table: "Users");

          migrationBuilder.DropForeignKey(
              name: "FK_Users_AchieveMent_AchieveMentId",
              table: "Users");

          migrationBuilder.DropForeignKey(
              name: "FK_Users_Educations_EducationsId",
              table: "Users");

          migrationBuilder.DropForeignKey(
              name: "FK_Users_Experience_ExperienceId",
              table: "Users");

          migrationBuilder.DropForeignKey(
              name: "FK_Users_Skills_SkillsId",
              table: "Users");

          migrationBuilder.DropForeignKey(
              name: "FK_Users_SocialMediaAccount_SocialMediaAccountId",
              table: "Users");

          migrationBuilder.DropForeignKey(
              name: "FK_Users_UserDocument_UserDocumentId",
              table: "Users");

          migrationBuilder.DropTable(
              name: "About");

          migrationBuilder.DropTable(
              name: "AchieveMent");

          migrationBuilder.DropTable(
              name: "Educations");

          migrationBuilder.DropTable(
              name: "Experience");

          migrationBuilder.DropIndex(
              name: "IX_Users_AboutId",
              table: "Users");

          migrationBuilder.DropIndex(
              name: "IX_Users_AchieveMentId",
              table: "Users");

          migrationBuilder.DropIndex(
              name: "IX_Users_EducationsId",
              table: "Users");

          migrationBuilder.DropIndex(
              name: "IX_Users_ExperienceId",
              table: "Users");

          migrationBuilder.DropIndex(
              name: "IX_Users_SkillsId",
              table: "Users");

          migrationBuilder.DropIndex(
              name: "IX_Users_SocialMediaAccountId",
              table: "Users");

          migrationBuilder.DropIndex(
              name: "IX_Users_UserDocumentId",
              table: "Users");

          migrationBuilder.DropIndex(
              name: "IX_ProjectTechnologies_ProjectsId",
              table: "ProjectTechnologies");

          migrationBuilder.DropColumn(
              name: "AboutId",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "AchieveMentId",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "CreadtedBy",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "CreatedDate",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "EducationsId",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "ExperienceId",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "IsDeleted",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "IsDeletedBy",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "ModifiedDate",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "SkillsId",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "SocialMediaAccountId",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "UserDocumentId",
              table: "Users");

          migrationBuilder.DropColumn(
              name: "CreatedDate",
              table: "Tools");

          migrationBuilder.DropColumn(
              name: "IsDeleted",
              table: "Tools");

          migrationBuilder.DropColumn(
              name: "IsDeletedBy",
              table: "Tools");

          migrationBuilder.DropColumn(
              name: "ModifiedDate",
              table: "Tools");

          migrationBuilder.DropColumn(
              name: "Users",
              table: "Tools");

          migrationBuilder.DropColumn(
              name: "CreatedDate",
              table: "Skills");

          migrationBuilder.DropColumn(
              name: "IsDeleted",
              table: "Skills");

          migrationBuilder.DropColumn(
              name: "IsDeletedBy",
              table: "Skills");

          migrationBuilder.DropColumn(
              name: "ModifiedDate",
              table: "Skills");

          migrationBuilder.DropColumn(
              name: "Skill",
              table: "Skills");

          migrationBuilder.DropColumn(
              name: "SkilsType",
              table: "Skills");

          migrationBuilder.DropColumn(
              name: "Users",
              table: "Skills");

          migrationBuilder.DropColumn(
              name: "ProjectsId",
              table: "ProjectTechnologies");

          migrationBuilder.RenameColumn(
              name: "ProjectsType",
              table: "Projects",
              newName: "ProjectsTypeId");

          migrationBuilder.AddColumn<string>(
              name: "Summary",
              table: "Users",
              type: "nvarchar(max)",
              nullable: false,
              defaultValue: "");

          migrationBuilder.AddColumn<int>(
              name: "UsersId",
              table: "UserDocument",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "UsersId",
              table: "SocialMediaAccount",
              type: "int",
              nullable: true);

          migrationBuilder.AddColumn<int>(
              name: "ProjectTechnologiesId",
              table: "Projects",
              type: "int",
              nullable: true);

          migrationBuilder.CreateIndex(
              name: "IX_UserDocument_UsersId",
              table: "UserDocument",
              column: "UsersId");

          migrationBuilder.CreateIndex(
              name: "IX_SocialMediaAccount_UsersId",
              table: "SocialMediaAccount",
              column: "UsersId");

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

          migrationBuilder.AddForeignKey(
              name: "FK_SocialMediaAccount_Users_UsersId",
              table: "SocialMediaAccount",
              column: "UsersId",
              principalTable: "Users",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_UserDocument_Users_UsersId",
              table: "UserDocument",
              column: "UsersId",
              principalTable: "Users",
              principalColumn: "Id");
      }
  }
