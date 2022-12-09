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
    public class CompaniesMap : IEntityTypeConfiguration<Companies>
    {
        public void Configure(EntityTypeBuilder<Companies> builder)
        {
            builder.HasKey(x => x.CompanyId);
            builder.Property(x => x.CompanyId).ValueGeneratedOnAdd();
            builder.HasIndex(x => x.CompanyName).IsUnique();
            builder.Property(x => x.CompanyName).HasMaxLength(100);
            builder.Property(x => x.CompanyName).IsRequired();
            builder.Property(x => x.CompanySymbol).HasMaxLength(100);
            builder.Property(x => x.CompanySymbol).IsRequired();
            builder.Property(x => x.CompanyBalance).IsRequired();
            builder.Property(x => x.CompanyBalance).HasMaxLength(20);
            builder.Property(x => x.CompanyIncomeStatement).IsRequired();
            builder.Property(x => x.CompanyIncomeStatement).HasMaxLength(20);
            builder.Property(x => x.CompanyProfit).IsRequired();
            builder.Property(x => x.CompanyProfit).HasMaxLength(20);
            builder.Property(x => x.CompanyPriceGainRate).IsRequired();
            builder.Property(x => x.CompanyPriceGainRate).HasMaxLength(10);
            builder.Property(x => x.CompanyInformation).IsRequired();
            builder.Property(x => x.CompanyInformation).HasMaxLength(500);
            builder.ToTable("Companies");
        }
    }
}
