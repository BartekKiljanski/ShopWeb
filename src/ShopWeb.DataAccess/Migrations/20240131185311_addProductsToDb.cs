using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShopWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Iskra", 1, "Przeniknij w świat niesamowitych przygód z książką 'Fortuna Czasu'. Ta fascynująca opowieść odkryje przed tobą tajemnice skrywane przez wieki. Czy uda się bohaterom ocalić świat przed nieuchronnym zagładą?", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortuna Czasu" },
                    { 2, "Nancy Hoover", 1, "Zanurz się w mrocznym świecie 'Ciemnego Nieba'. Tajemnicze zjawiska na niebie stwarzają zagadki, które muszą zostać rozwikłane. Czy bohaterowie odnajdą odpowiedzi i ocalą ludzkość przed zagładą?", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Ciemne Niebo" },
                    { 3, "Julian Guzik", 1, "Rozpocznij niezapomnianą podróż ze 'Zniknij w Zachodzie Słońca'. Ta opowieść o miłości i poszukiwaniach przyniesie ci wiele wzruszeń. Czy główni bohaterowie odnajdą swoje miejsce na ziemi i szczęście?", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Zniknij w Zachodzie Słońca" },
                    { 4, "Abby Muscles", 2, "Wciel się w rolę detektywa w świecie 'Wat Candy'. Twoim zadaniem jest rozwiązać skomplikowaną zagadkę związaną z tajemniczymi słodyczami. Czy uda ci się odkryć wszystkie tajemnice?", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Wat Candy" },
                    { 5, "Ron Parker", 2, "Zanurz się w piękny świat oceanicznej przygody z książką 'Skała w Oceanie'. Poznaj fascynujące podwodne tajemnice i spotkaj niezwykłe stworzenia. Czy odnajdziesz zagubiony skarb?", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Skała w Oceanie" },
                    { 6, "Laura Duch", 3, "Wyrusz w podróż pełną magii i niespodzianek razem z książką 'Liście i Cuda'. Świat fantastycznych stworzeń i czarów czeka na ciebie. Czy staniesz się częścią tej niezwykłej opowieści?", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Liście i Cuda" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
