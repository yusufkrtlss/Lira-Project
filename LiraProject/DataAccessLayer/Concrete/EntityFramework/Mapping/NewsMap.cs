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
    public class NewsMap : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(x => x.NewsId);
            builder.Property(x => x.NewsId).ValueGeneratedOnAdd();
            builder.Property(x => x.NewsName).IsRequired();
            builder.Property(x => x.NewsName).HasMaxLength(50);
            builder.Property(x => x.NewsTitle).IsRequired();
            builder.Property(x => x.NewsTitle).HasMaxLength(20);
            builder.Property(x => x.NewsInformation).IsRequired();
            builder.Property(x => x.NewsInformation).HasMaxLength(500);
            builder.Property(x => x.NewsCreatedDate).IsRequired();
            builder.HasOne<Companies>(s => s.Companies).WithMany(s => s.News).HasForeignKey(s => s.Companies.CompanyId);
            builder.ToTable("News");
        }
    }
}
