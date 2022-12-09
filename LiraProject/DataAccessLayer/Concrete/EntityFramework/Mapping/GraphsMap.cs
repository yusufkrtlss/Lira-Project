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
    public class GraphsMap : IEntityTypeConfiguration<Graphs>
    {
        public void Configure(EntityTypeBuilder<Graphs> builder)
        {
            builder.HasKey(x => x.GraphId);
            builder.Property(x => x.GraphId).ValueGeneratedOnAdd();
            builder.Property(x => x.GraphName).IsRequired();
            builder.Property(x => x.GraphName).HasMaxLength(50);
            builder.HasOne<Companies>(s => s.Company).WithMany(s => s.Graphs).HasForeignKey(s => s.Company.CompanyId);
            builder.ToTable("Graphs");
        }
    }
}
