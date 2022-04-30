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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id); 
            builder.Property(x=>x.Barcode).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p=>p.Description).IsRequired().HasMaxLength(500);
            builder.ToTable("tblProduct");
        }
    }
}
