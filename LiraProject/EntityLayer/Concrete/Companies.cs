using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Companies
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanySymbol { get; set; }
        public float CompanyBalance { get; set; }
        public float CompanyIncomeStatement { get; set; }
        public float CompanyProfit { get; set; }
        public float CompanyPriceGainRate { get; set; }
        public string CompanyInformation { get; set; }
        public ICollection<Share> Shares { get; set; }
        public ICollection<Graphs> Graphs { get; set; }
    }
}
