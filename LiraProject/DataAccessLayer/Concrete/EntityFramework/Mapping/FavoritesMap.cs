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
    public class FavoritesMap : IEntityTypeConfiguration<Favorites>
    {
        public void Configure(EntityTypeBuilder<Favorites> builder)
        {
            builder.HasKey(x => x.FavoriteID);
            builder.Property(x=>x.FavoriteID).ValueGeneratedOnAdd();            
            builder.HasOne<Companies>(s=>s.Companies).WithMany(s => s.Favorites).HasForeignKey(s => s.Companies.CompanyId);
            builder.HasOne<Customer>(s=>s.Customer).WithMany(s => s.Favorites).HasForeignKey(s => s.Companies.CompanyId);
            builder.ToTable("Favorites");
        }
    }
}
