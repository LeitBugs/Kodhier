﻿// <auto-generated />
using Kodhier.Data;
using Kodhier.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Kodhier.Migrations
{
    [DbContext(typeof(KodhierDbContext))]
    partial class KodhierDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kodhier.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<decimal>("Coins");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("EmailSendPromotional");

                    b.Property<bool>("EmailSendUpdates");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Kodhier.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CaptionEn");

                    b.Property<string>("CaptionLt");

                    b.Property<string>("ImagePath");

                    b.Property<bool>("IsActive");

                    b.Property<Guid?>("PizzaId");

                    b.Property<string>("TitleEn");

                    b.Property<string>("TitleLt");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Kodhier.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChefId");

                    b.Property<string>("ClientId");

                    b.Property<string>("Comment");

                    b.Property<DateTime?>("CompletionDate");

                    b.Property<DateTime?>("CookingDate");

                    b.Property<string>("DelivereeId");

                    b.Property<string>("DeliveryAddress");

                    b.Property<int>("DeliveryColor");

                    b.Property<DateTime?>("DeliveryDate");

                    b.Property<bool>("IsPaid");

                    b.Property<DateTime?>("PaymentDate");

                    b.Property<Guid?>("PizzaId");

                    b.Property<DateTime>("PlacementDate");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<DateTime?>("ReadyDate");

                    b.Property<int>("Size");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ChefId");

                    b.HasIndex("ClientId");

                    b.HasIndex("DelivereeId");

                    b.HasIndex("PizzaId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Kodhier.Models.Pizza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionLt");

                    b.Property<string>("ImagePath");

                    b.Property<bool>("IsDepricated");

                    b.Property<string>("NameEn");

                    b.Property<string>("NameLt");

                    b.Property<int>("PriceCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("PriceCategoryId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("Kodhier.Models.PizzaPriceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("PizzaPriceCategories");
                });

            modelBuilder.Entity("Kodhier.Models.PizzaPriceInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Price");

                    b.Property<int>("PriceCategoryId");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.HasIndex("PriceCategoryId");

                    b.ToTable("PizzaPriceInfo");
                });

            modelBuilder.Entity("Kodhier.Models.PrepaidCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("RedeemerId");

                    b.Property<DateTime?>("RedemptionDate");

                    b.HasKey("Id");

                    b.HasIndex("RedeemerId");

                    b.ToTable("PrepaidCodes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Kodhier.Models.News", b =>
                {
                    b.HasOne("Kodhier.Models.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId");
                });

            modelBuilder.Entity("Kodhier.Models.Order", b =>
                {
                    b.HasOne("Kodhier.Models.ApplicationUser", "Chef")
                        .WithMany()
                        .HasForeignKey("ChefId");

                    b.HasOne("Kodhier.Models.ApplicationUser", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Kodhier.Models.ApplicationUser", "Deliveree")
                        .WithMany()
                        .HasForeignKey("DelivereeId");

                    b.HasOne("Kodhier.Models.Pizza", "Pizza")
                        .WithMany("Orders")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Kodhier.Models.Pizza", b =>
                {
                    b.HasOne("Kodhier.Models.PizzaPriceCategory", "PriceCategory")
                        .WithMany("Pizzas")
                        .HasForeignKey("PriceCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Kodhier.Models.PizzaPriceInfo", b =>
                {
                    b.HasOne("Kodhier.Models.PizzaPriceCategory", "PriceCategory")
                        .WithMany("PizzaPriceInfos")
                        .HasForeignKey("PriceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kodhier.Models.PrepaidCode", b =>
                {
                    b.HasOne("Kodhier.Models.ApplicationUser", "Redeemer")
                        .WithMany()
                        .HasForeignKey("RedeemerId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Kodhier.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Kodhier.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kodhier.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Kodhier.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
