using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompaniesService
    {
        void CompanyAdd(Companies companies);
        List<Companies> GetAllCompanies();
        
        Companies GetById(int id);
        Companies GetBySymbol(string symbol);
    }
}
