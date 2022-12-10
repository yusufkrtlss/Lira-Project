using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Context
{
    public class LiraDb : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Graphs> Graphs { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Share> Shares { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:lirainvestmentserver.database.windows.net,1433;Initial Catalog=LiraOfInvestment_DB;Persist Security Info=False;User ID=lirainvestment;Password=Lira2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
