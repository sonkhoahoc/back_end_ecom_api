﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_end_ecom_api.Entities;

#nullable disable

namespace back_end_ecom_api.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("back_end_ecom_api.Entities.Admin_User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("sex")
                        .HasColumnType("tinyint");

                    b.Property<byte>("type")
                        .HasColumnType("tinyint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long>("userUpdate")
                        .HasColumnType("bigint");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("admin_user");
                });

            modelBuilder.Entity("back_end_ecom_api.Entities.Banners", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("banner_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("link_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long>("userUpdate")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("banner");
                });

            modelBuilder.Entity("back_end_ecom_api.Entities.Category_Products", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long>("userUpdate")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("category_product ");
                });

            modelBuilder.Entity("back_end_ecom_api.Entities.Logo", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("logo_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long>("userUpdate")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("logo");
                });

            modelBuilder.Entity("back_end_ecom_api.Entities.Product_Files", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("file_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("product_id")
                        .HasColumnType("bigint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long>("userUpdate")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("product_file");
                });

            modelBuilder.Entity("back_end_ecom_api.Entities.Products", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("category_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("sold_quantity")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stock_quantity")
                        .HasColumnType("int");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long>("userUpdate")
                        .HasColumnType("bigint");

                    b.Property<int>("views_count")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("product");
                });

            modelBuilder.Entity("back_end_ecom_api.Entities.Sizes", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("product_id")
                        .HasColumnType("bigint");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long>("userUpdate")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("size");
                });

            modelBuilder.Entity("back_end_ecom_api.Entities.User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("full_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("sex")
                        .HasColumnType("tinyint");

                    b.Property<long>("userAdded")
                        .HasColumnType("bigint");

                    b.Property<long>("userUpdate")
                        .HasColumnType("bigint");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}
