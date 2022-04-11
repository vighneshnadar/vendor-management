using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using solarp.data.Models;
namespace solarp.data
{
    public class solarDbContext:IdentityDbContext
    {
      public solarDbContext()
      {
          
      }
      public solarDbContext(DbContextOptions options):base(options)
      {
          
      }

      public virtual DbSet<Customer> Customers{get; set;}
      public virtual DbSet<CustomerAddress> CustomerAddresses{get;set;}
      public virtual DbSet<Product> Products{get;set;}
      public virtual DbSet<ProductInventory> ProductInventories{get;set;}
      public virtual DbSet<ProductInventorySnapshot> ProductInventorySnapshots{get;set;}
      public virtual DbSet<SalesOrder> SalesOrders{get;set;}
      public virtual DbSet<SalesOrderItem> SalesOrderItems{get;set;}
        
    }
}