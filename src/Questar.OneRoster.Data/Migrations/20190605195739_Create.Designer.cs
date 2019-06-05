﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questar.OneRoster.Data.Services;

namespace Questar.OneRoster.Data.Migrations
{
    [DbContext(typeof(OneRosterDbContext))]
    [Migration("20190605195739_Create")]
    partial class Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FriendlyName");

                    b.Property<string>("Xml");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKey");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.AcademicSession", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("EndDate")
                        .IsRequired();

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ParentId");

                    b.Property<int?>("SchoolYear")
                        .IsRequired();

                    b.Property<DateTime?>("StartDate")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("MetadataCollectionId");

                    b.HasIndex("ParentId");

                    b.ToTable("AcademicSession");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MetadataCollectionId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Class", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<string>("Code")
                        .HasMaxLength(32);

                    b.Property<string>("CourseId");

                    b.Property<string>("Location")
                        .HasMaxLength(256);

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("SchoolId");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("MetadataCollectionId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassAcademicSession", b =>
                {
                    b.Property<string>("ClassId");

                    b.Property<string>("AcademicSessionId");

                    b.HasKey("ClassId", "AcademicSessionId");

                    b.HasIndex("AcademicSessionId");

                    b.ToTable("ClassAcademicSession");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassGrade", b =>
                {
                    b.Property<string>("ClassId");

                    b.Property<string>("GradeId");

                    b.HasKey("ClassId", "GradeId");

                    b.HasIndex("GradeId");

                    b.ToTable("ClassGrade");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassPeriod", b =>
                {
                    b.Property<string>("ClassId");

                    b.Property<string>("Period");

                    b.HasKey("ClassId", "Period");

                    b.ToTable("ClassPeriod");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassResource", b =>
                {
                    b.Property<string>("ClassId");

                    b.Property<string>("ResourceId");

                    b.HasKey("ClassId", "ResourceId");

                    b.HasIndex("ResourceId");

                    b.ToTable("ClassResource");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassSubject", b =>
                {
                    b.Property<string>("ClassId");

                    b.Property<string>("SubjectId");

                    b.HasKey("ClassId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ClassSubject");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<string>("Code")
                        .HasMaxLength(256);

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("OrgId");

                    b.Property<string>("SchoolYearId");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("MetadataCollectionId");

                    b.HasIndex("OrgId");

                    b.HasIndex("SchoolYearId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.CourseGrade", b =>
                {
                    b.Property<string>("CourseId");

                    b.Property<string>("GradeId");

                    b.HasKey("CourseId", "GradeId");

                    b.HasIndex("GradeId");

                    b.ToTable("CourseGrade");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.CourseResource", b =>
                {
                    b.Property<string>("CourseId");

                    b.Property<string>("ResourceId");

                    b.HasKey("CourseId", "ResourceId");

                    b.HasIndex("ResourceId");

                    b.ToTable("CourseResource");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.CourseSubject", b =>
                {
                    b.Property<string>("CourseId");

                    b.Property<string>("SubjectId");

                    b.HasKey("CourseId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("CourseSubject");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Demographics", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<bool?>("AmericanIndianOrAlaskaNative");

                    b.Property<bool?>("Asian");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<bool?>("BlackOrAfricanAmerican");

                    b.Property<string>("CityOfBirth");

                    b.Property<string>("CountryOfBirthCode");

                    b.Property<bool?>("DemographicRaceTwoOrMoreRaces");

                    b.Property<bool?>("HispanicOrLatinoEthnicity");

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<bool?>("NativeHawaiianOrOtherPacificIslander");

                    b.Property<string>("PublicSchoolResidenceStatus");

                    b.Property<int?>("Sex");

                    b.Property<string>("StateOfBirthAbbreviation");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.Property<bool?>("White");

                    b.HasKey("Id");

                    b.HasIndex("MetadataCollectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Demographics");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Enrollment", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("BeginDate");

                    b.Property<string>("ClassId");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<bool?>("Primary");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("MetadataCollectionId");

                    b.HasIndex("UserId");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Grade", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<string>("Code")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.LineItem", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("AssignDate")
                        .IsRequired();

                    b.Property<string>("CategoryId");

                    b.Property<string>("ClassId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired();

                    b.Property<string>("GradingPeriodId");

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<float?>("ResultValueMax")
                        .IsRequired();

                    b.Property<float?>("ResultValueMin")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ClassId");

                    b.HasIndex("GradingPeriodId");

                    b.HasIndex("MetadataCollectionId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Metadata", b =>
                {
                    b.Property<string>("CollectionId");

                    b.Property<string>("Key")
                        .HasMaxLength(64);

                    b.Property<string>("Value")
                        .HasMaxLength(256);

                    b.HasKey("CollectionId", "Key");

                    b.ToTable("Metadata");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.MetadataCollection", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("MetadataCollection");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Org", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<string>("Identifier")
                        .HasMaxLength(256);

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("ParentId");

                    b.Property<int>("Status");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("Identifier");

                    b.HasIndex("MetadataCollectionId");

                    b.HasIndex("ParentId");

                    b.ToTable("Org");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Resource", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<string>("ApplicationId")
                        .HasMaxLength(256);

                    b.Property<int>("Importance");

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .HasMaxLength(64);

                    b.Property<string>("VendorId")
                        .HasMaxLength(256);

                    b.Property<string>("VendorResourceId")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("MetadataCollectionId");

                    b.ToTable("Resource");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ResourceRole", b =>
                {
                    b.Property<string>("ResourceId");

                    b.Property<int>("Role");

                    b.HasKey("ResourceId", "Role");

                    b.ToTable("ResourceRole");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Result", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<string>("Comment");

                    b.Property<string>("LineItemId");

                    b.Property<string>("MetadataCollectionId");

                    b.Property<DateTime>("Modified");

                    b.Property<float?>("Score")
                        .IsRequired();

                    b.Property<DateTime?>("ScoreDate")
                        .IsRequired();

                    b.Property<int>("ScoreStatus");

                    b.Property<int>("Status");

                    b.Property<string>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("LineItemId");

                    b.HasIndex("MetadataCollectionId");

                    b.HasIndex("StudentId");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Subject", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("Enabled");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Identifier");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MetadataCollectionId");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(64);

                    b.Property<DateTime>("Modified");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Sms");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int>("Type");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Identifier");

                    b.HasIndex("MetadataCollectionId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserAgent", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("AgentId");

                    b.HasKey("UserId", "AgentId");

                    b.HasIndex("AgentId");

                    b.ToTable("UserAgent");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserGrade", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("GradeId");

                    b.HasKey("UserId", "GradeId");

                    b.HasIndex("GradeId");

                    b.ToTable("UserGrade");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserIdentifier", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("Type")
                        .HasMaxLength(256);

                    b.Property<string>("Identifier")
                        .HasMaxLength(256);

                    b.HasKey("UserId", "Type", "Identifier");

                    b.ToTable("UserIdentifier");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserOrg", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("OrgId");

                    b.HasKey("UserId", "OrgId");

                    b.HasIndex("OrgId");

                    b.ToTable("UserOrg");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserRole", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserToken", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.AcademicSession", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");

                    b.HasOne("Questar.OneRoster.Data.AcademicSession", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Category", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Class", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("CourseId");

                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");

                    b.HasOne("Questar.OneRoster.Data.Org", "School")
                        .WithMany("Classes")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassAcademicSession", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.AcademicSession", "AcademicSession")
                        .WithMany("Classes")
                        .HasForeignKey("AcademicSessionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.Class", "Class")
                        .WithMany("Terms")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassGrade", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Class", "Class")
                        .WithMany("Grades")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.Grade", "Grade")
                        .WithMany("Classes")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassPeriod", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Class", "Class")
                        .WithMany("Periods")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassResource", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Class", "Class")
                        .WithMany("Resources")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.Resource", "Resource")
                        .WithMany("Classes")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ClassSubject", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Class", "Class")
                        .WithMany("Subjects")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Course", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");

                    b.HasOne("Questar.OneRoster.Data.Org", "Org")
                        .WithMany("Courses")
                        .HasForeignKey("OrgId");

                    b.HasOne("Questar.OneRoster.Data.AcademicSession", "SchoolYear")
                        .WithMany("Courses")
                        .HasForeignKey("SchoolYearId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.CourseGrade", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Course", "Course")
                        .WithMany("Grades")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.Grade", "Grade")
                        .WithMany("Courses")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.CourseResource", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.Resource", "Resource")
                        .WithMany("Courses")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.CourseSubject", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Course", "Course")
                        .WithMany("Subjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.Subject", "Subject")
                        .WithMany("Classes")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Demographics", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.User")
                        .WithOne("Demographics")
                        .HasForeignKey("Questar.OneRoster.Data.Demographics", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");

                    b.HasOne("Questar.OneRoster.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Enrollment", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Class", "Class")
                        .WithMany("Enrollments")
                        .HasForeignKey("ClassId");

                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");

                    b.HasOne("Questar.OneRoster.Data.User", "User")
                        .WithMany("Enrollments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.LineItem", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Category", "Category")
                        .WithMany("LineItems")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Questar.OneRoster.Data.Class", "Class")
                        .WithMany("LineItems")
                        .HasForeignKey("ClassId");

                    b.HasOne("Questar.OneRoster.Data.AcademicSession", "GradingPeriod")
                        .WithMany("LineItems")
                        .HasForeignKey("GradingPeriodId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Metadata", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "Collection")
                        .WithMany("Metadata")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Org", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");

                    b.HasOne("Questar.OneRoster.Data.Org", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Resource", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.ResourceRole", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Resource", "Resource")
                        .WithMany("Roles")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.Result", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.LineItem", "LineItem")
                        .WithMany("Results")
                        .HasForeignKey("LineItemId");

                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");

                    b.HasOne("Questar.OneRoster.Data.User", "Student")
                        .WithMany("Results")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.RoleClaim", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.User", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.MetadataCollection", "MetadataCollection")
                        .WithMany()
                        .HasForeignKey("MetadataCollectionId");
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserAgent", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.User", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.User", "User")
                        .WithMany("Agents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserClaim", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserGrade", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Grade", "Grade")
                        .WithMany("Users")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.User", "User")
                        .WithMany("Grades")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserIdentifier", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.User", "User")
                        .WithMany("Ids")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserLogin", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserOrg", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Org", "Org")
                        .WithMany()
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.User", "User")
                        .WithMany("Orgs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserRole", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questar.OneRoster.Data.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questar.OneRoster.Data.UserToken", b =>
                {
                    b.HasOne("Questar.OneRoster.Data.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}