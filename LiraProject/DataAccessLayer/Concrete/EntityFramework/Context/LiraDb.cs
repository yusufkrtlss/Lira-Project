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
            optionsBuilder.UseSqlServer(@"Server=lirainvestmentserver.database.windows.net;initial catalog=LiraOfInvestment_DB;User Id=Lira_yusuf;Password=Investment.2022;encrypt=false");
        }
    }
}
