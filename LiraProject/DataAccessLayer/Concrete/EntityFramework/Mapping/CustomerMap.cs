using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.CustomerId);
            builder.Property(x => x.CustomerId).ValueGeneratedOnAdd();
            builder.Property(x => x.CustomerEmail).IsRequired();
            builder.Property(x => x.CustomerEmail).HasMaxLength(50);
            builder.HasIndex(x => x.CustomerEmail).IsUnique();
            builder.Property(x => x.CustomerFirstName).IsRequired();
            builder.Property(x => x.CustomerFirstName).HasMaxLength(100);
            builder.Property(x => x.CustomerLastName).IsRequired();
            builder.Property(x => x.CustomerLastName).HasMaxLength(100);
            builder.Property(x => x.CustomerPassword).IsRequired();
            builder.Property(x => x.CustomerPassword).HasMaxLength(20);
            builder.Property(x => x.CustomerPhone).IsRequired();
            builder.Property(x => x.CustomerPhone).HasMaxLength(15);
            builder.Property(x => x.CustomerCreatedTime).IsRequired();
            builder.Property(x => x.CustomerModifiedTime).IsRequired();
            builder.ToTable("Customer");
        }
    }
}
