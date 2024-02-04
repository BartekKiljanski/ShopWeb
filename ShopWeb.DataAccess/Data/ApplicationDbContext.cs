using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopWeb.Models;

namespace ShopWeb.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

              modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Tech Solution", StreetAddress="123 Tech St", City="Tech City",
                                PostalCode="12121", State="IL", PhoneNumber="6669990000"},
                new Company {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
                );




            modelBuilder.Entity<Product>().HasData(
            new Product
    {
        Id = 1,
        Title = "Fortuna Czasu",
        Author = "Billy Iskra",
        Description = "Przeniknij w świat niesamowitych przygód z książką 'Fortuna Czasu'. Ta fascynująca opowieść odkryje przed tobą tajemnice skrywane przez wieki. Czy uda się bohaterom ocalić świat przed nieuchronnym zagładą?",
        ISBN = "SWD9999001",
        ListPrice = 99,
        Price = 90,
        Price50 = 85,
        Price100 = 80,
        CategoryId = 1,
        /*ImageUrl = ""*/
    },
    new Product
    {
        Id = 2,
        Title = "Ciemne Niebo",
        Author = "Nancy Hoover",
        Description = "Zanurz się w mrocznym świecie 'Ciemnego Nieba'. Tajemnicze zjawiska na niebie stwarzają zagadki, które muszą zostać rozwikłane. Czy bohaterowie odnajdą odpowiedzi i ocalą ludzkość przed zagładą?",
        ISBN = "CAW777777701",
        ListPrice = 40,
        Price = 30,
        Price50 = 25,
        Price100 = 20,
       CategoryId = 1,
        /*ImageUrl = ""*/
    },
    new Product
    {
        Id = 3,
        Title = "Zniknij w Zachodzie Słońca",
        Author = "Julian Guzik",
        Description = "Rozpocznij niezapomnianą podróż ze 'Zniknij w Zachodzie Słońca'. Ta opowieść o miłości i poszukiwaniach przyniesie ci wiele wzruszeń. Czy główni bohaterowie odnajdą swoje miejsce na ziemi i szczęście?",
        ISBN = "RITO5555501",
        ListPrice = 55,
        Price = 50,
        Price50 = 40,
        Price100 = 35,
       CategoryId = 1,
      /*  ImageUrl = ""*/
    },
    new Product
    {
        Id = 4,
        Title = "Wat Candy",
        Author = "Abby Muscles",
        Description = "Wciel się w rolę detektywa w świecie 'Wat Candy'. Twoim zadaniem jest rozwiązać skomplikowaną zagadkę związaną z tajemniczymi słodyczami. Czy uda ci się odkryć wszystkie tajemnice?",
        ISBN = "WS3333333301",
        ListPrice = 70,
        Price = 65,
        Price50 = 60,
        Price100 = 55,
       CategoryId = 2,
       /* ImageUrl = ""*/
    },
    new Product
    {
        Id = 5,
        Title = "Skała w Oceanie",
        Author = "Ron Parker",
        Description = "Zanurz się w piękny świat oceanicznej przygody z książką 'Skała w Oceanie'. Poznaj fascynujące podwodne tajemnice i spotkaj niezwykłe stworzenia. Czy odnajdziesz zagubiony skarb?",
        ISBN = "SOTJ1111111101",
        ListPrice = 30,
        Price = 27,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 2,
       /* ImageUrl = ""*/
    },
    new Product
    {
        Id = 6,
        Title = "Liście i Cuda",
        Author = "Laura Duch",
        Description = "Wyrusz w podróż pełną magii i niespodzianek razem z książką 'Liście i Cuda'. Świat fantastycznych stworzeń i czarów czeka na ciebie. Czy staniesz się częścią tej niezwykłej opowieści?",
        ISBN = "FOT000000001",
        ListPrice = 25,
        Price = 23,
        Price50 = 22,
        Price100 = 20,
       CategoryId = 3,
       /* ImageUrl = ""*/
    }
                 );


        }

    }
}
