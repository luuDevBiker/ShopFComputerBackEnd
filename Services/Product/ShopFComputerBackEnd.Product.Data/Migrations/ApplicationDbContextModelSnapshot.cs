﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShopFComputerBackEnd.Product.Data;
using ShopFComputerBackEnd.Product.Domain.ValueObjects;

#nullable disable

namespace ShopFComputerBackEnd.Product.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Options.OptionReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Id"), new[] { "Name", "IsDeleted" });

                    b.HasIndex("Name");

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Name"), new[] { "Id", "IsDeleted" });

                    b.HasIndex("ProductId");

                    b.ToTable("Options", (string)null);
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Options.OptionValueReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("OptionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductVariantId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("Updating");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Id"), new[] { "OptionId", "ProductVariantId", "Value", "IsDeleted" });

                    b.HasIndex("ProductVariantId");

                    b.HasIndex("Value");

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Value"), new[] { "Id", "OptionId", "ProductVariantId", "IsDeleted" });

                    b.HasIndex("OptionId", "ProductVariantId")
                        .IsUnique();

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("OptionId", "ProductVariantId"), new[] { "Id", "Value", "IsDeleted" });

                    b.ToTable("OptionValues", (string)null);
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Products.ProductReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyTimestamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("DeletedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("ModifiedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Id"), new[] { "Name", "Description", "Category", "Brand", "IsDeleted", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "DeletedBy", "DeletedTime" });

                    b.HasIndex("Name")
                        .IsUnique();

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Name"), new[] { "Id", "Description", "Category", "Brand", "IsDeleted", "CreatedBy", "CreatedTime", "ModifiedBy", "ModifiedTime", "DeletedBy", "DeletedTime" });

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Products.ProductVariantReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<ICollection<ImageValueObject>>("Images")
                        .HasColumnType("jsonb");

                    b.Property<decimal>("ImportPrice")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<double>("Sale")
                        .HasColumnType("double precision");

                    b.Property<string>("SkuId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Id"), new[] { "SkuId", "ProductId", "ImportPrice", "Price", "Quantity", "IsDeleted" });

                    b.HasIndex("Price");

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("Price"), new[] { "Id", "ProductId", "ImportPrice", "SkuId", "Quantity", "IsDeleted" });

                    b.HasIndex("ProductId");

                    b.HasIndex("SkuId")
                        .IsUnique();

                    NpgsqlIndexBuilderExtensions.IncludeProperties(b.HasIndex("SkuId"), new[] { "Id", "ProductId", "ImportPrice", "Price", "Quantity", "IsDeleted" });

                    b.ToTable("ProductVariants", (string)null);
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Options.OptionReadModel", b =>
                {
                    b.HasOne("ShopFComputerBackEnd.Product.Domain.ReadModels.Products.ProductReadModel", "Product")
                        .WithMany("Options")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Options.OptionValueReadModel", b =>
                {
                    b.HasOne("ShopFComputerBackEnd.Product.Domain.ReadModels.Options.OptionReadModel", "Option")
                        .WithMany("OptionValues")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopFComputerBackEnd.Product.Domain.ReadModels.Products.ProductVariantReadModel", "ProductVariant")
                        .WithMany("OptionValues")
                        .HasForeignKey("ProductVariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("ProductVariant");
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Products.ProductVariantReadModel", b =>
                {
                    b.HasOne("ShopFComputerBackEnd.Product.Domain.ReadModels.Products.ProductReadModel", "Product")
                        .WithMany("ProductVariants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Options.OptionReadModel", b =>
                {
                    b.Navigation("OptionValues");
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Products.ProductReadModel", b =>
                {
                    b.Navigation("Options");

                    b.Navigation("ProductVariants");
                });

            modelBuilder.Entity("ShopFComputerBackEnd.Product.Domain.ReadModels.Products.ProductVariantReadModel", b =>
                {
                    b.Navigation("OptionValues");
                });
#pragma warning restore 612, 618
        }
    }
}