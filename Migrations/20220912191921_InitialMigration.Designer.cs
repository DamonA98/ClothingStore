﻿// <auto-generated />
using ClothingStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClothingStore.Migrations
{
    [DbContext(typeof(ClothingStoreDbContext))]
    [Migration("20220912191921_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClothingStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ClothingStore.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartItemID"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SneakersId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartItemID");

                    b.HasIndex("SneakersId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ClothingStore.Models.Sneakers", b =>
                {
                    b.Property<int>("SneakersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SneakersId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSneakersofTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("Sku")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SneakersId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sneakers");
                });

            modelBuilder.Entity("ClothingStore.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ClothingStore.Models.Sneakers", "Sneakers")
                        .WithMany()
                        .HasForeignKey("SneakersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sneakers");
                });

            modelBuilder.Entity("ClothingStore.Models.Sneakers", b =>
                {
                    b.HasOne("ClothingStore.Models.Category", "Category")
                        .WithMany("Sneakers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClothingStore.Models.Category", b =>
                {
                    b.Navigation("Sneakers");
                });
#pragma warning restore 612, 618
        }
    }
}
