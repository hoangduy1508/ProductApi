using Microsoft.EntityFrameworkCore;
using ProductApi.Entities;

namespace ProductApi.DbContexts
{
    public class ProductContext: DbContext { 

       
    
        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public ProductContext(DbContextOptions<ProductContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Thasdsadasdsadsadsa",
                    CategoryId = 1,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Thasdsadasdsadsadsa",
                    CategoryId = 2,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Product 3",
                    Description = "Thasdsadasdsadsadsa",
                    CategoryId = 3,
                },
                new Product()
                {
                    Id = 4,
                    Name = "Product 4",
                    Description = "Thasdsadasdsadsadsa",
                    CategoryId = 4,
                },
                new Product()
                {
                    Id = 5,
                    Name = "Product 5",
                    Description = "Thasdsadasdsadsadsa",
                    CategoryId = 2,
                }
                );

            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   Id = 1,
                   Name = "Category 1",
                   Description = "Thasdsadasdsadsadsa",
                
               },
                new Category()
                {
                    Id = 2,
                    Name = "Category 2",
                    Description = "Thasdsadasdsadsadsa",

                },
                 new Category()
                 {
                     Id = 3,
                     Name = "Category 3",
                     Description = "Thasdsadasdsadsadsa",

                 },
                  new Category()
                  {
                      Id = 4,
                      Name = "Category 5",
                      Description = "Thasdsadasdsadsadsa",

                  }
               );


           base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite();

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
