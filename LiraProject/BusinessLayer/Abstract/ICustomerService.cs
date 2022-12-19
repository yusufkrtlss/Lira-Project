using BusinessLayer.Dto;
using CoreLayer.Results.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        void CustomerAdd(Customer customer);
        void CustomerDelete(Customer customer);
        List<Customer> GetAllCompanies();

        Customer GetById(int id);
        //Customer GetBySymbol(string symbol);
        //Task<IDataResult<CustomerDto>> GetAsync(string customerName);
        //Task<IDataResult<CustomerDto>> GetById(int customerId); // Buradaki customerId olduğu için di mi hayır hemen anltorum
        //Task<IDataResult<CustomerListDto>> GetAllAsync();
        //Task<IResult> Add(CustomerAddDto customerAddDto);
        //Task<IResult> Update(CustomerUpdateDto customerUpdateDto);
        //Task<IResult> Delete(int CustomerId);
        //Task<IDataResult<CustomerListDto>> GetAllByNonDeletedAsync();
        //Task<int> GetAllCustomerCount();
        //Task<int> GetAllCustomerNonDeletedCount();
        //Task<IDataResult<CustomerUpdateDto>> GetCustomerUpdateDtoByCustomerId(int customerId);

    }
}
