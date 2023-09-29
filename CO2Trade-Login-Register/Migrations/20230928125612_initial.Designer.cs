﻿// <auto-generated />
using System;
using CO2Trade_Login_Register.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CO2Trade_Login_Register.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230928125612_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Billing.Bill", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("GrossTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("IdOperacion")
                        .HasColumnType("int");

                    b.Property<int>("IdTaxCondition")
                        .HasColumnType("int");

                    b.Property<int>("IdTaxDocumentType")
                        .HasColumnType("int");

                    b.Property<decimal>("NetTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdOperacion");

                    b.HasIndex("IdTaxCondition");

                    b.HasIndex("IdTaxDocumentType");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Billing.TaxCondition", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TaxConditions");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Billing.TaxDocumentType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaxDocumentTypes");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Documents.Document", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Documents.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Documents.EntityDocument", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdDocument")
                        .HasColumnType("int");

                    b.Property<string>("IdEntidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IdDocument");

                    b.HasIndex("IdEntidad");

                    b.ToTable("EntityDocuments");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.EntitiesUser.EntityType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EntityTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Individual Person"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Legal Entity"
                        });
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("IdEntityType")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("IdEntityType");

                    b.HasIndex("IdRol");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.EntitiesUser.Rol", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Administrator rol",
                            Name = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Individual customer rol",
                            Name = "INDIVIDUAL_CUSTOMER"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Organization rol",
                            Name = "ORGANIZATION"
                        });
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.GeneralSettings.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLogo")
                        .HasColumnType("int");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatformName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("puerto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLogo");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.GeneralSettings.Image", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Measure.MeasureCO2", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Co2E")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdEntidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IdEntidad");

                    b.ToTable("MeasureCo2s");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Operations.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CertificateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Operations.Operation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdCertificate")
                        .HasColumnType("int");

                    b.Property<string>("IdEntityUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCompensation")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdCertificate");

                    b.HasIndex("IdEntityUser");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Project.EntityProject", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("IdEntityUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdProject")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEntityUser");

                    b.HasIndex("IdProject");

                    b.ToTable("EntityProjects");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Project.OperationProject", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdOperation")
                        .HasColumnType("int");

                    b.Property<int>("IdProject")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdOperation");

                    b.HasIndex("ProjectId");

                    b.ToTable("OperationProjects");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Project.Project", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdImage")
                        .HasColumnType("int");

                    b.Property<int>("IdProjectType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TonsOfOxygen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdImage");

                    b.HasIndex("IdProjectType");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Project.ProjectType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Billing.Bill", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.Operations.Operation", "Operation")
                        .WithMany()
                        .HasForeignKey("IdOperacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.Billing.TaxCondition", "TaxCondition")
                        .WithMany()
                        .HasForeignKey("IdTaxCondition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.Billing.TaxDocumentType", "TaxDocumentType")
                        .WithMany()
                        .HasForeignKey("IdTaxDocumentType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operation");

                    b.Navigation("TaxCondition");

                    b.Navigation("TaxDocumentType");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Documents.EntityDocument", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.Documents.Document", "Document")
                        .WithMany()
                        .HasForeignKey("IdDocument")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", "EntityUser")
                        .WithMany()
                        .HasForeignKey("IdEntidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("EntityUser");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("IdEntityType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityType");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.GeneralSettings.Configuration", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.GeneralSettings.Image", "Image")
                        .WithMany()
                        .HasForeignKey("IdLogo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Measure.MeasureCO2", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", "EntityUser")
                        .WithMany()
                        .HasForeignKey("IdEntidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityUser");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Operations.Operation", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.Operations.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("IdCertificate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", "EntityUser")
                        .WithMany()
                        .HasForeignKey("IdEntityUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certificate");

                    b.Navigation("EntityUser");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Project.EntityProject", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", "EntityUser")
                        .WithMany()
                        .HasForeignKey("IdEntityUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.Project.Project", "Project")
                        .WithMany()
                        .HasForeignKey("IdProject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityUser");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Project.OperationProject", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.Operations.Operation", "Operation")
                        .WithMany()
                        .HasForeignKey("IdOperation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.Project.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operation");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("CO2Trade_Login_Register.Models.Project.Project", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.GeneralSettings.Image", "Image")
                        .WithMany()
                        .HasForeignKey("IdImage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.Project.ProjectType", "ProjectType")
                        .WithMany()
                        .HasForeignKey("IdProjectType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("ProjectType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CO2Trade_Login_Register.Models.EntitiesUser.EntityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}