﻿// <auto-generated />
using System;
using BooksShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BooksShop.Migrations
{
    [DbContext(typeof(BooksShopDbContext))]
    [Migration("20240420110811_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BooksShop.Data.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Дерманський Сашко"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ролінґ Дж.К."
                        },
                        new
                        {
                            Id = 3,
                            Name = "Олефір Юлія"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Костенко Ліна"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Федієнко Василь"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Протеро Стівен"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Кентербері Дейв"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Дубчак Ольга"
                        });
                });

            modelBuilder.Entity("BooksShop.Data.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CategoryId = 1,
                            Discount = 5,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/m/a/malim-ditjam-pro-vse-na-sviti-enciklopedija-v-kazkah_2.webp",
                            InStock = true,
                            Name = "Малим дітям про все на світі",
                            Price = 470m,
                            Quantity = 0,
                            Year = 2021
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            CategoryId = 1,
                            Discount = 10,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/l/i/lizla-zhaba-po-drabini.webp",
                            InStock = true,
                            Name = "Лізла жаба по драбині",
                            Price = 320m,
                            Quantity = 0,
                            Year = 2023
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            CategoryId = 1,
                            Discount = 0,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/285x395/g/a/garri-potter-i-filosovs-kij-kamin-chastina-1_3.webp",
                            InStock = true,
                            Name = "Гаррі Поттер і філософський камінь (Частина 1)",
                            Price = 320m,
                            Quantity = 0,
                            Year = 2020
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            CategoryId = 1,
                            Discount = 5,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/g/a/garri-potter-i-taemna-kimnata-chastina-2_3.webp",
                            InStock = true,
                            Name = "Гаррі Поттер і таємна кімната (Частина 2)",
                            Price = 320m,
                            Quantity = 0,
                            Year = 2021
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            CategoryId = 1,
                            Discount = 15,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/k/a/kazkovij-lis-prigodi-enotiv-beshketnikiv.webp",
                            InStock = false,
                            Name = "Казковий ліс",
                            Price = 400m,
                            Quantity = 0,
                            Year = 2021
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 4,
                            CategoryId = 2,
                            Discount = 0,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/3/0/300-poezij_3.webp",
                            InStock = true,
                            Name = "Триста поезій",
                            Price = 350m,
                            Quantity = 0,
                            Year = 2012
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 4,
                            CategoryId = 2,
                            Discount = 0,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/m/a/marusja-churaj_7.webp",
                            InStock = true,
                            Name = "Маруся Чурай",
                            Price = 350m,
                            Quantity = 0,
                            Year = 2018
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 5,
                            CategoryId = 3,
                            Discount = 0,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/m/i/mi-gotuemos-do-shkoli-krok-do-shkoli_2.webp",
                            InStock = true,
                            Name = "Ми готуємось до школи",
                            Price = 175m,
                            Quantity = 0,
                            Year = 2024
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 5,
                            CategoryId = 3,
                            Discount = 5,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/b/u/bukvar-dlja-doshkil-njat-chitajlik-a4-korablik_4.webp",
                            InStock = true,
                            Name = "Буквар для дошкільнят",
                            Price = 140m,
                            Quantity = 0,
                            Year = 2015
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 6,
                            CategoryId = 4,
                            Discount = 15,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/285x395/v/i/visim-religij-scho-panujut-u-sviti-chomu-ihni-vidminnosti-majut-znachennja_8.webp",
                            InStock = true,
                            Name = "Вісім релігій, що панують у світі",
                            Price = 250m,
                            Quantity = 0,
                            Year = 2022
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 7,
                            CategoryId = 5,
                            Discount = 0,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/b/u/bushkraft-najvazhlivishi-navichki-dlja-vizhivannja-v-dikij-prirodi_1.webp",
                            InStock = false,
                            Name = "Бушкрафт",
                            Price = 290m,
                            Quantity = 0,
                            Year = 2023
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 8,
                            CategoryId = 5,
                            Discount = 0,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/285x395/b/a/bachiti-ukrains-koju_2.webp",
                            InStock = true,
                            Name = "Бачити українською",
                            Price = 350m,
                            Quantity = 0,
                            Year = 2024
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 8,
                            CategoryId = 5,
                            Discount = 0,
                            ImageUrl = "https://bookopt.com.ua/media/catalog/product/cache/image/850x/c/h/chuti-ukrains-koju-u-sviti-zvuki-u-i-bukv_2.webp",
                            InStock = true,
                            Name = "Чути українською",
                            Price = 290m,
                            Quantity = 0,
                            Year = 2024
                        });
                });

            modelBuilder.Entity("BooksShop.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Дитяча"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Художня"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Навчальна"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Культура"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Дозвілля"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Мова"
                        });
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BooksShop.Data.Entities.Book", b =>
                {
                    b.HasOne("BooksShop.Data.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BooksShop.Data.Entities.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BooksShop.Data.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BooksShop.Data.Entities.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}