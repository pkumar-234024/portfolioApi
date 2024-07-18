﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Infrastructure.Data;

#nullable disable

namespace Portfolio.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240718095452_UpdateTablemig")]
    partial class UpdateTablemig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Portfolio.Core.Modal.Contributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contributors");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.ProjectTechnologies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackENdTechnology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DatabseTechnology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForntEndTechnology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeletedBy")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Technology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTechnologies");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.Projects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreadtedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeletedBy")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectLongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectTechnologies")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectTechnologiesId")
                        .HasColumnType("int");

                    b.Property<string>("ProjectTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectsTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectTechnologiesId");

                    b.HasIndex("UsersId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.SocialMediaAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreadtedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeletedBy")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProfileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("SocialMediaAccount");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.Tools", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.UserDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreadtedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CvUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeletedBy")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResumeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("UserDocument");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.Projects", b =>
                {
                    b.HasOne("Portfolio.Core.Modal.ProjectTechnologies", null)
                        .WithMany("Projects")
                        .HasForeignKey("ProjectTechnologiesId");

                    b.HasOne("Portfolio.Core.Modal.Users", null)
                        .WithMany("Projects")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.SocialMediaAccount", b =>
                {
                    b.HasOne("Portfolio.Core.Modal.Users", null)
                        .WithMany("SocialMediaAccount")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.UserDocument", b =>
                {
                    b.HasOne("Portfolio.Core.Modal.Users", null)
                        .WithMany("UserDocument")
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.ProjectTechnologies", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("Portfolio.Core.Modal.Users", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("SocialMediaAccount");

                    b.Navigation("UserDocument");
                });
#pragma warning restore 612, 618
        }
    }
}