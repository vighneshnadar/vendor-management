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
        
    }
}