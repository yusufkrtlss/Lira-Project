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
    public class ShareMap : IEntityTypeConfiguration<Share>
    {
        public void Configure(EntityTypeBuilder<Share> builder)
        {
            builder.HasKey(x => x.ShareId);
            builder.Property(x => x.ShareId).ValueGeneratedOnAdd();
            builder.Property(x => x.ShareName).IsRequired();
            builder.Property(x => x.ShareName).HasMaxLength(50);
            builder.HasIndex(x => x.ShareName).IsUnique();
            builder.Property(x => x.SharePrice).IsRequired();
            builder.Property(x => x.SharePrice).HasMaxLength(20);
            builder.Property(x => x.ShareType).IsRequired();
            builder.Property(x => x.ShareType).HasMaxLength(20);
            builder.Property(x => x.ShareShortName).IsRequired();
            builder.Property(x => x.ShareShortName).HasMaxLength(4);
            builder.HasIndex(x => x.ShareShortName).IsUnique();
            builder.HasOne<Companies>(s => s.Company).WithMany(s => s.Shares).HasForeignKey(s => s.Company.CompanyId);
            builder.ToTable("Share");

        }
    }
}
