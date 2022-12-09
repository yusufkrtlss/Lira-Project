using EntityLayer.APIClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IQuotesService
    {
        public void AddCompanyList(Quotes quotes);
    }
}
