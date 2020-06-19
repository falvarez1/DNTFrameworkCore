﻿// <auto-generated />
using System;
using DNTFrameworkCore.TestWebApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DNTFrameworkCore.TestWebApp.Infrastructure.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20200506144819_V2020_05_06_1917")]
    partial class V2020_05_06_1917
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DNTFrameworkCore.Caching.Cache", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(449)")
                        .HasMaxLength(449);

                    b.Property<DateTimeOffset?>("AbsoluteExpiration")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ExpiresAtTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<long?>("SlidingExpirationInSeconds")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("Value")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExpiresAtTime")
                        .HasName("IX_Cache_ExpiresAtTime");

                    b.ToTable("Cache","dbo");
                });

            modelBuilder.Entity("DNTFrameworkCore.Cryptography.ProtectionKey", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FriendlyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("XmlValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FriendlyName")
                        .IsUnique()
                        .HasName("IX_ProtectionKey_FriendlyName");

                    b.ToTable("ProtectionKey","dbo");
                });

            modelBuilder.Entity("DNTFrameworkCore.Logging.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("ImpersonatorTenantId")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ImpersonatorUserId")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LoggerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("TenantName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("UserBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("UserDisplayName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UserIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Level")
                        .HasName("IX_Log_Level");

                    b.HasIndex("LoggerName")
                        .HasName("IX_Log_LoggerName");

                    b.ToTable("Log","dbo");
                });

            modelBuilder.Entity("DNTFrameworkCore.Numbering.NumberedEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("varchar(256)")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<long>("NextNumber")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("EntityName")
                        .IsUnique()
                        .HasName("UIX_NumberedEntity_EntityName");

                    b.ToTable("NumberedEntity");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Blogging.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("CreatedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("CreatedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("LogoImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ModifiedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("ModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedTitle")
                        .IsUnique()
                        .HasName("Blog_NormalizedTitle");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Catalog.PriceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NormalizedTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PriceType");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Catalog.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("CreatedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("CreatedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ModifiedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("ModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Catalog.ProductPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PriceTypeId")
                        .HasColumnType("int");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PriceTypeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductPrice");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsGranted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ModifiedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("ModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("Discriminator")
                        .HasName("IX_Permission_Discriminator");

                    b.ToTable("Permission");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Permission");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("CreatedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("CreatedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ModifiedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ModifiedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("ModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("UIX_Role_NormalizedName");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ModifiedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("ModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("CreatedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("CreatedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastLoggedInDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ModifiedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("ModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedDisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedDisplayName")
                        .IsUnique()
                        .HasName("UIX_User_NormalizedDisplayName");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UIX_User_NormalizedUserName");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ModifiedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("ModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByBrowserName")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("CreatedByIP")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<long?>("CreatedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.RolePermission", b =>
                {
                    b.HasBaseType("DNTFrameworkCore.TestWebApp.Domain.Identity.Permission");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasIndex("RoleId");

                    b.HasDiscriminator().HasValue("RolePermission");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.UserPermission", b =>
                {
                    b.HasBaseType("DNTFrameworkCore.TestWebApp.Domain.Identity.Permission");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasIndex("UserId");

                    b.HasDiscriminator().HasValue("UserPermission");
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Catalog.ProductPrice", b =>
                {
                    b.HasOne("DNTFrameworkCore.TestWebApp.Domain.Catalog.PriceType", "PriceType")
                        .WithMany()
                        .HasForeignKey("PriceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DNTFrameworkCore.TestWebApp.Domain.Catalog.Product", "Product")
                        .WithMany("Prices")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.RoleClaim", b =>
                {
                    b.HasOne("DNTFrameworkCore.TestWebApp.Domain.Identity.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.UserClaim", b =>
                {
                    b.HasOne("DNTFrameworkCore.TestWebApp.Domain.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.UserRole", b =>
                {
                    b.HasOne("DNTFrameworkCore.TestWebApp.Domain.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DNTFrameworkCore.TestWebApp.Domain.Identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.RolePermission", b =>
                {
                    b.HasOne("DNTFrameworkCore.TestWebApp.Domain.Identity.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Identity.UserPermission", b =>
                {
                    b.HasOne("DNTFrameworkCore.TestWebApp.Domain.Identity.User", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
