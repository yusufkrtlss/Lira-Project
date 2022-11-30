using DataAccessLayer.Abstract;
using EntityLayer.APIClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class QuotesManager
    {
        IQuotesDal _quotesDal;

        public QuotesManager(IQuotesDal quotesDal) { 
            _quotesDal = quotesDal;
        }
        public void AddCompanyList(Quotes quotes)
        {
            _quotesDal.InsertFromAPI(quotes);
        }
    }
}
