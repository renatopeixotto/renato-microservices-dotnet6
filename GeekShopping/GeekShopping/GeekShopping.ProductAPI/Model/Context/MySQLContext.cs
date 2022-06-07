using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(new Product
        //    {
        //        Id = 3,
        //        Name = "Name",
        //        Price = new decimal (69.9),
        //        Description = "Teste",
        //        CategoryName = "Category 1",
        //        ImageUrl = "https://m.media-amazon.com/images/I/513S4sXwGqL._AC_SL1000_.jpg",
        //    });
        //}
    }
}
