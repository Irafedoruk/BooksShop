using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksShop.Migrations
{
    /// <inheritdoc />
    public partial class fillBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Discount", "ImageUrl", "InStock", "Name", "Price", "Quantity", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, 5, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/m/a/malim-ditjam-pro-vse-na-sviti-enciklopedija-v-kazkah_2.webp", true, "Малим дітям про все на світі", 470m, 10, 2021 },
                    { 2, 1, 1, 10, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/l/i/lizla-zhaba-po-drabini.webp", true, "Лізла жаба по драбині", 320m, 5, 2023 },
                    { 3, 2, 1, 0, "https://bookopt.com.ua/media/catalog/product/cache/image/285x395/g/a/garri-potter-i-filosovs-kij-kamin-chastina-1_3.webp", true, "Гаррі Поттер і філософський камінь (Частина 1)", 320m, 12, 2020 },
                    { 4, 2, 1, 5, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/g/a/garri-potter-i-taemna-kimnata-chastina-2_3.webp", true, "Гаррі Поттер і таємна кімната (Частина 2)", 320m, 8, 2021 },
                    { 5, 3, 1, 15, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/k/a/kazkovij-lis-prigodi-enotiv-beshketnikiv.webp", false, "Казковий ліс", 400m, 0, 2021 },
                    { 6, 4, 2, 0, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/3/0/300-poezij_3.webp", true, "Триста поезій", 350m, 20, 2012 },
                    { 7, 4, 2, 0, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/m/a/marusja-churaj_7.webp", true, "Маруся Чурай", 350m, 10, 2018 },
                    { 8, 5, 3, 0, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/m/i/mi-gotuemos-do-shkoli-krok-do-shkoli_2.webp", true, "Ми готуємось до школи", 175m, 11, 2024 },
                    { 9, 5, 3, 5, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/b/u/bukvar-dlja-doshkil-njat-chitajlik-a4-korablik_4.webp", true, "Буквар для дошкільнят", 140m, 8, 2015 },
                    { 10, 6, 4, 15, "https://bookopt.com.ua/media/catalog/product/cache/image/285x395/v/i/visim-religij-scho-panujut-u-sviti-chomu-ihni-vidminnosti-majut-znachennja_8.webp", true, "Вісім релігій, що панують у світі", 250m, 1, 2022 },
                    { 11, 7, 5, 0, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/b/u/bushkraft-najvazhlivishi-navichki-dlja-vizhivannja-v-dikij-prirodi_1.webp", false, "Бушкрафт", 290m, 0, 2023 },
                    { 12, 8, 5, 0, "https://bookopt.com.ua/media/catalog/product/cache/image/285x395/b/a/bachiti-ukrains-koju_2.webp", true, "Бачити українською", 350m, 16, 2024 },
                    { 13, 8, 5, 0, "https://bookopt.com.ua/media/catalog/product/cache/image/850x/c/h/chuti-ukrains-koju-u-sviti-zvuki-u-i-bukv_2.webp", true, "Чути українською", 290m, 13, 2024 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
