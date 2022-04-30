using CustomerOrderTracking.DataAccess.Configuration;
using CustomerOrderTracking.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderTracking.DataAccess
{
    public class CustomerOrderTrackingDbContext : DbContext
    {
        public CustomerOrderTrackingDbContext(DbContextOptions<CustomerOrderTrackingDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());

        }
    }
}
