using Microsoft.EntityFrameworkCore;

namespace Ef_Product1Management{

    public class Product1Context:DbContext{
          public DbSet<Product> Productdetails1 { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=EfProduct1;user=root;password=Password@12345");
    }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Product>(entity =>
      {
        entity.HasKey(e => e.PID);
        entity.Property(e => e.productname).IsRequired();
        entity.Property(e => e.productquantity).IsRequired();
        entity.Property(e => e.productprice).IsRequired();
       

      });

    }


    }
}