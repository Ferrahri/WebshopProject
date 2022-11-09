using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Text;

namespace DataLayer
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Country> Countries { get; set; }

        public ShopContext() : base(new DbContextOptionsBuilder().Options) { }

        public ShopContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = WebShopDb; Trusted_Connection = True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SEEDING
            modelBuilder.Entity<Product>()
                .HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Latitude 5530",
                    ProductTypeId = 1,
                    CategoryId = 2,
                    BrandId = 1,
                    CountryId = 1,
                    ProductImageId = 4,
                    Price = 6460,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Ryzen 5 7700X",
                    ProductTypeId = 3,
                    CategoryId = 5,
                    BrandId = 6,
                    CountryId = 1,
                    ProductImageId = 2,
                    Price = 3499,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    ProductId = 3,
                    Name = "i5 13700K",
                    ProductTypeId = 4,
                    CategoryId = 5,
                    BrandId = 5,
                    CountryId = 1,
                    ProductImageId = 3,
                    Price = 3300,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    ProductId = 4,
                    Name = "EcoBubble",
                    ProductTypeId = 6,
                    CategoryId = 4,
                    BrandId = 3,
                    CountryId = 3,
                    ProductImageId = 6,
                    Price = 5999,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Serie 6 ProAnimal",
                    ProductTypeId = 5,
                    CategoryId = 4,
                    BrandId = 4,
                    CountryId = 4,
                    Price = 2100,
                    ProductImageId = 5,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Bravia XR",
                    ProductTypeId = 2,
                    CategoryId = 4,
                    BrandId = 2,
                    CountryId = 2,
                    Price = 13999,
                    ProductImageId = 1,
                    CreatedDate = DateTime.Now,
                });
            modelBuilder.Entity<User>()
                .HasData(
                new User { UserId = 1,UserName = "jjshopper",Email = "jj123@test.com",Name = "Jack",Surname = "Johnson",Password = "jj123",PhoneNumber = 123456789,CreatedDate = DateTime.Now, IsAdmin=false, IsActive=true},
                new User { UserId = 2, UserName = "rene488",Email = "rene488@test.com", Name = "Rene",Surname = "du Preez",Password = "rdp123",PhoneNumber = 987654321,CreatedDate = DateTime.Now, IsAdmin = true, IsActive=true },
                new User { UserId = 3, UserName = "emma30h",Email = "emma30h@test.com", Name = "Emma",Surname = "Holm",Password = "eh123",PhoneNumber = 918273645,CreatedDate = DateTime.Now, IsAdmin = false, IsActive=false }
                );
            modelBuilder.Entity<Country>()
                .HasData(
                new Country { CountryId = 1, Name = "USA" },
                new Country { CountryId = 2, Name = "Japan" },
                new Country { CountryId = 3, Name = "South Korea" },
                new Country { CountryId = 4, Name = "Germany" },
                new Country { CountryId = 5, Name = "China" }
                );
            modelBuilder.Entity<Category>()
                .HasData(
                new Category { CategoryId = 1, Name = "Gaming" },
                new Category { CategoryId = 2, Name = "Office"},
                new Category { CategoryId = 3, Name = "SmartHome"},
                new Category { CategoryId = 4, Name = "Appliances"},
                new Category { CategoryId = 5, Name = "Computer Hardware" }
                );
            modelBuilder.Entity<Brand>()
                .HasData(
                new Brand { BrandId = 1, Name = "Dell"},
                new Brand { BrandId = 2, Name = "Sony"},
                new Brand { BrandId = 3, Name = "Samsung"},
                new Brand { BrandId = 4, Name = "Bosch"},
                new Brand { BrandId = 5, Name = "Intel"},
                new Brand { BrandId = 6, Name = "AMD"}
                );
            modelBuilder.Entity<ProductType>()
                .HasData(
                new ProductType { ProductTypeId = 1, Name = "Laptop"},
                new ProductType { ProductTypeId = 2, Name = "TV"},
                new ProductType { ProductTypeId = 3, Name = "AMD Processor"},
                new ProductType { ProductTypeId = 4, Name = "Intel Processor"},
                new ProductType { ProductTypeId = 5, Name = "Vacuum Cleaner"},
                new ProductType { ProductTypeId = 6, Name = "Washing Machine" }
                );
            modelBuilder.Entity<ProductImage>()
            .HasData(
                new ProductImage { ProductImageId = 1, Caption = "Sony Bravia XR", ImagePath = "C:\\Users\\Rene\\source\\repos\\WebshopProject\\BlazorWebApp\\wwwroot\\img\\sony_bravia_xr.jpg" },
                new ProductImage { ProductImageId = 2, Caption = "AMD Ryzen 5 7700X", ImagePath = "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\ryzen_7700x.jpg" },
                new ProductImage { ProductImageId = 3, Caption = "Intel i7 13700K", ImagePath = "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\i7_13700k.jpg" },
                new ProductImage { ProductImageId = 4, Caption = "Dell Latitude 5530", ImagePath = "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\latitude_5530.jpg" },
                new ProductImage { ProductImageId = 5, Caption = "Bosch Serie 6", ImagePath = "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\bosch_serie_6.jpg" },
                new ProductImage { ProductImageId = 6, Caption = "Samsung EcoBubble", ImagePath = "C:\\Users\\Rene\\source\\repos\\WebShopProject\\WebApp\\wwwroot\\img\\samsung_ecobubble.jpg" }
                );
            #endregion

        }
    }
}
