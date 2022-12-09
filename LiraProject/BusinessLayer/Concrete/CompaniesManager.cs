using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.APIClasses;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CompaniesManager : ICompaniesService
    {
        ICompaniesDal _companiesDal;

        public CompaniesManager(ICompaniesDal companiesDal)
        {
            _companiesDal = companiesDal;
        }

        public void CompanyAdd(Companies companies)
        {
            _companiesDal.Insert(companies);
        }

        public List<Companies> GetAllCompanies()
        {
            return _companiesDal.GetListAll();
        }

       

        public Companies GetById(int id)
        {
            return _companiesDal.GetById(id);
        }

        public Companies GetBySymbol(string symbol)
        {
            return _companiesDal.GetSymbol(symbol);
        }
        
    }
}
