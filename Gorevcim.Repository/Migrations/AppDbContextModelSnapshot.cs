﻿// <auto-generated />
using System;
using Gorevcim.Repository.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    [DbContext(typeof(AppDbContext.AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gorevcim.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateUserId = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsActiveDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdateUserId = 0,
                            IsActiveDateUserId = 0,
                            IsDelete = false,
                            IsDeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUserId = 0,
                            IsDeleteUpdateUserId = 0,
                            Name = "Ofis Ürünleri",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateUserId = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateUserId = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsActiveDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdateUserId = 0,
                            IsActiveDateUserId = 0,
                            IsDelete = false,
                            IsDeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUserId = 0,
                            IsDeleteUpdateUserId = 0,
                            Name = "Polen Haşere",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateUserId = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateUserId = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsActiveDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdateUserId = 0,
                            IsActiveDateUserId = 0,
                            IsDelete = false,
                            IsDeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUserId = 0,
                            IsDeleteUpdateUserId = 0,
                            Name = "İzolasyon",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateUserId = 0
                        },
                        new
                        {
                            Id = 4,
                            CreateUserId = 0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = false,
                            IsActiveDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdateUserId = 0,
                            IsActiveDateUserId = 0,
                            IsDelete = false,
                            IsDeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUserId = 0,
                            IsDeleteUpdateUserId = 0,
                            Name = "Tadilat",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdateUserId = 0
                        });
                });

            modelBuilder.Entity("Gorevcim.Core.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Barcode")
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ExplanationWebUrl")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsMixture")
                        .HasColumnType("bit");

                    b.Property<string>("LogoBase64Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoFileName")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)");

                    b.Property<string>("LogoFilePath")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)");

                    b.Property<string>("Name")
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("TechnicalWebUrl")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "AS123",
                            CategoryId = 1,
                            Code = "123AS",
                            CreateUserId = 0,
                            CreatedDate = new DateTime(2022, 5, 27, 16, 58, 11, 417, DateTimeKind.Local).AddTicks(140),
                            ExpirationDate = new DateTime(2022, 5, 27, 16, 58, 11, 417, DateTimeKind.Local).AddTicks(149),
                            Explanation = "sdfklsdjlfkds",
                            ExplanationWebUrl = "sdjfhsdf",
                            IsActive = false,
                            IsActiveDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActiveDateUpdateUserId = 0,
                            IsActiveDateUserId = 0,
                            IsDelete = false,
                            IsDeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUpdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleteDateUserId = 0,
                            IsDeleteUpdateUserId = 0,
                            IsMixture = false,
                            LogoBase64Content = "sdklf",
                            LogoFileName = "dkjfg",
                            LogoFilePath = "dfjhdf",
                            Name = "Test ürün",
                            PurchasePrice = 23m,
                            SalePrice = 110m,
                            Stock = 12,
                            TechnicalWebUrl = "klsdjfsd",
                            UpdateDate = new DateTime(2022, 5, 27, 16, 58, 11, 417, DateTimeKind.Local).AddTicks(148),
                            UpdateUserId = 0
                        });
                });

            modelBuilder.Entity("Gorevcim.Core.ProductCurrencyUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductFeaturesId")
                        .HasColumnType("int");

                    b.Property<string>("ShortCode")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductFeaturesId")
                        .IsUnique();

                    b.ToTable("ProductCurrencyUnits");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductMeasurementUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductFeaturesId")
                        .HasColumnType("int");

                    b.Property<string>("ShortCode")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductFeaturesId")
                        .IsUnique();

                    b.ToTable("ProductMeasurementUnits");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductFeaturesId")
                        .HasColumnType("int");

                    b.Property<string>("ShortCode")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductFeaturesId")
                        .IsUnique();

                    b.ToTable("ProductProjects");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductsBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BrandsName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("BrandsWeUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<string>("LogoBase64Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoFileName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LogoFilePath")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductFeaturesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductFeaturesId")
                        .IsUnique();

                    b.ToTable("ProductsBrands");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductsColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ColorBase64Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorFilepath")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductFeaturesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductFeaturesId")
                        .IsUnique();

                    b.ToTable("ProductsColors");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductsWeightUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductFeaturesId")
                        .HasColumnType("int");

                    b.Property<string>("ShortCode")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductFeaturesId")
                        .IsUnique();

                    b.ToTable("ProductsWeightUnits");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductVatUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Explanation")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsActiveDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsActiveDateUpdateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsActiveDateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IsDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsDeleteDateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleteDateUserId")
                        .HasColumnType("int");

                    b.Property<int>("IsDeleteUpdateUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsExemption")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ProductFeaturesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UpdateUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductFeaturesId")
                        .IsUnique();

                    b.ToTable("ProductVatUnits");
                });

            modelBuilder.Entity("Gorevcim.Core.Product", b =>
                {
                    b.HasOne("Gorevcim.Core.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductCurrencyUnit", b =>
                {
                    b.HasOne("Gorevcim.Core.ProductFeatures", "ProductFeatures")
                        .WithOne("ProductCurrencyUnit")
                        .HasForeignKey("Gorevcim.Core.ProductCurrencyUnit", "ProductFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductFeatures", b =>
                {
                    b.HasOne("Gorevcim.Core.Product", "Product")
                        .WithMany("ProductFeatures")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductMeasurementUnit", b =>
                {
                    b.HasOne("Gorevcim.Core.ProductFeatures", "ProductFeatures")
                        .WithOne("ProductMeasurementUnit")
                        .HasForeignKey("Gorevcim.Core.ProductMeasurementUnit", "ProductFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductProject", b =>
                {
                    b.HasOne("Gorevcim.Core.ProductFeatures", "ProductFeatures")
                        .WithOne("ProductProject")
                        .HasForeignKey("Gorevcim.Core.ProductProject", "ProductFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductsBrand", b =>
                {
                    b.HasOne("Gorevcim.Core.ProductFeatures", "ProductFeatures")
                        .WithOne("ProductsBrand")
                        .HasForeignKey("Gorevcim.Core.ProductsBrand", "ProductFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductsColor", b =>
                {
                    b.HasOne("Gorevcim.Core.ProductFeatures", "ProductFeatures")
                        .WithOne("ProductsColor")
                        .HasForeignKey("Gorevcim.Core.ProductsColor", "ProductFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductsWeightUnit", b =>
                {
                    b.HasOne("Gorevcim.Core.ProductFeatures", "ProductFeatures")
                        .WithOne("ProductsWeightUnit")
                        .HasForeignKey("Gorevcim.Core.ProductsWeightUnit", "ProductFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductVatUnit", b =>
                {
                    b.HasOne("Gorevcim.Core.ProductFeatures", "ProductFeatures")
                        .WithOne("ProductVatUnit")
                        .HasForeignKey("Gorevcim.Core.ProductVatUnit", "ProductFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Gorevcim.Core.Product", b =>
                {
                    b.Navigation("ProductFeatures");
                });

            modelBuilder.Entity("Gorevcim.Core.ProductFeatures", b =>
                {
                    b.Navigation("ProductCurrencyUnit");

                    b.Navigation("ProductMeasurementUnit");

                    b.Navigation("ProductProject");

                    b.Navigation("ProductVatUnit");

                    b.Navigation("ProductsBrand");

                    b.Navigation("ProductsColor");

                    b.Navigation("ProductsWeightUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
