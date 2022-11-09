using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ProductImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ProductImageId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ProductImageId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductImages_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "ProductImages",
                        principalColumn: "ProductImageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, "Dell" },
                    { 2, "Sony" },
                    { 3, "Samsung" },
                    { 4, "Bosch" },
                    { 5, "Intel" },
                    { 6, "AMD" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Gaming" },
                    { 2, "Office" },
                    { 3, "SmartHome" },
                    { 4, "Appliances" },
                    { 5, "Computer Hardware" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "USA" },
                    { 2, "Japan" },
                    { 3, "South Korea" },
                    { 4, "Germany" },
                    { 5, "China" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ProductImageId", "Caption", "ImagePath" },
                values: new object[,]
                {
                    { 1, "Sony Bravia XR", "C:\\Users\\Rene\\source\\repos\\WebshopProject\\BlazorWebApp\\wwwroot\\img\\sony_bravia_xr.jpg" },
                    { 2, "AMD Ryzen 5 7700X", "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\ryzen_7700x.jpg" },
                    { 3, "Intel i7 13700K", "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\i7_13700k.jpg" },
                    { 4, "Dell Latitude 5530", "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\latitude_5530.jpg" },
                    { 5, "Bosch Serie 6", "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\bosch_serie_6.jpg" },
                    { 6, "Samsung EcoBubble", "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\samsung_ecobubble.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Laptop" },
                    { 2, "TV" },
                    { 3, "AMD Processor" },
                    { 4, "Intel Processor" },
                    { 5, "Vacuum Cleaner" },
                    { 6, "Washing Machine" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "IsActive", "IsAdmin", "Name", "Password", "PhoneNumber", "Surname", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(525), "jj123@test.com", true, false, "Jack", "jj123", 123456789, "Johnson", "jjshopper" },
                    { 2, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(528), "rene488@test.com", true, true, "Rene", "rdp123", 987654321, "du Preez", "rene488" },
                    { 3, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(530), "emma30h@test.com", false, false, "Emma", "eh123", 918273645, "Holm", "emma30h" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CategoryId", "CountryId", "CreatedDate", "Name", "Price", "ProductImageId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, 1, 2, 1, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(407), "Latitude 5530", 6460f, 4, 1 },
                    { 2, 6, 5, 1, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(442), "Ryzen 5 7700X", 3499f, 2, 3 },
                    { 3, 5, 5, 1, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(444), "i5 13700K", 3300f, 3, 4 },
                    { 4, 3, 4, 3, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(445), "EcoBubble", 5999f, 6, 6 },
                    { 5, 4, 4, 4, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(447), "Serie 6 ProAnimal", 2100f, 5, 5 },
                    { 6, 2, 4, 2, new DateTime(2022, 11, 8, 14, 7, 47, 907, DateTimeKind.Local).AddTicks(448), "Bravia XR", 13999f, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CountryId",
                table: "Products",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductImageId",
                table: "Products",
                column: "ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
