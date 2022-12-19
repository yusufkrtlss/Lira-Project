using CoreLayer.Data.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EfRepositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCustomerRepository : GenericRepository<Customer>, ICustomerDal
    {
        
    }
}
