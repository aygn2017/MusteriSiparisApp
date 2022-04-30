
using CustomerOrderTracking.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderTracking.DataAccess.Configuration
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p=>p.Address).IsRequired().HasMaxLength(50);
            builder.ToTable("tblCustomers");
        }
    }
}
