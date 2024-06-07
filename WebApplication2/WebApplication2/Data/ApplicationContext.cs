using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication2.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    public DbSet<Accounts> Accounts { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Shopping_Carts> ShoppingCarts { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Products_Categories> ProductsCategories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed Roles
        modelBuilder.Entity<Roles>().HasData(
            new Roles { PK_role = 1, Name = "Admin" },
            new Roles { PK_role = 2, Name = "User" }
        );

        // Seed Categories
        modelBuilder.Entity<Categories>().HasData(
            new Categories { PK_categoty = 1, Name = "Electronics" },
            new Categories { PK_categoty = 2, Name = "Books" }
        );

        // Seed Products
        modelBuilder.Entity<Products>().HasData(
            new Products { PK_product = 1, Name = "Laptop", Weight = 2.5, Height = 1.5, Depth = 0.5 },
            new Products { PK_product = 2, Name = "Smartphone", Weight = 0.5, Height = 0.7, Depth = 0.3 }
        );

        // Seed Accounts
        modelBuilder.Entity<Accounts>().HasData(
            new Accounts { PK_account = 1, FK_role = 1, First_name = "John", Last_name = "Doe", Email = "john.doe@example.com", Phone = "123456789" },
            new Accounts { PK_account = 2, FK_role = 2, First_name = "Jane", Last_name = "Smith", Email = "jane.smith@example.com", Phone = "987654321" }
        );

        // Seed Shopping Carts
        modelBuilder.Entity<Shopping_Carts>().HasData(
            new Shopping_Carts { FK_account = 1, FK_Product = 1, Amount = 1 },
            new Shopping_Carts { FK_account = 2, FK_Product = 2, Amount = 2 }
        );
    }
}
