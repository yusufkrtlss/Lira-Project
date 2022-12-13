
using CoreLayer.Results.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dto
{
    public class CustomerListDto
    {
        public IList<Customer> Customers { get; set; }
    }
}
