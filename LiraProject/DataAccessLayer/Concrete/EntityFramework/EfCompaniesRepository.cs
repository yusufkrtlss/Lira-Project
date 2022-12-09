using DataAccessLayer.Abstract;
using DataAccessLayer.EfRepositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCompaniesRepository:GenericRepository<Companies>,ICompaniesDal
    {

    }
}
