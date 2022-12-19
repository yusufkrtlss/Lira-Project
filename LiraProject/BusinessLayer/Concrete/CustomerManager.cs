using BusinessLayer.Abstract;
using BusinessLayer.AutoMapper;
using CoreLayer.Results.Abstract;
using CoreLayer.Results.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Dto;
using DataAccessLayer.Concrete;

namespace BusinessLayer.Concrete
{
    
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void CustomerAdd(Customer customer)
        {
            _customerDal.Insert(customer);
        }

        public void CustomerDelete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAllCompanies()
        {
            return _customerDal.GetListAll();
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetById(id);
        }
        //protected readonly IUnitOfWork _unitOfWork;
        //protected readonly IMapper _mapper;

        //// Constructor
        //public CustomerManager(IUnitOfWork unitOfWork, IMapper mapper)
        //{
        //    _unitOfWork = unitOfWork;
        //    _mapper = mapper;
        //}

        //// Asenkron Add Routine
        //public async Task<IResult> Add(CustomerAddDto customerAddDto)
        //{
        //    var customer = _mapper.Map<Customer>(customerAddDto);
        //    try
        //    {

        //        await _unitOfWork.Customer.AddAsync(customer);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw;
        //    }
        //    await _unitOfWork.SaveAsync();
        //    return new Result(ResultStatus.Success, $"{customerAddDto.CustomerFirstName} adding successfully");

        //}

        //// Asenkron Delete Routine
        //public async Task<IResult> Delete(int CustomerId)
        //{
        //    var customer = await _unitOfWork.Customer.GetAsync(c => c.CustomerId == CustomerId);
        //    if (customer != null)
        //    {
        //        customer.CustomerStatus = false;


        //        customer.CustomerCreatedTime = DateTime.Now;

        //        await _unitOfWork.Customer.UpdateAsync(customer);
        //        await _unitOfWork.SaveAsync();
        //        return new Result(ResultStatus.Success, $"{customer.CustomerFirstName} deleted successfuly");

        //    }
        //    return new Result(ResultStatus.Error, "Couldn't find the customer");
        //}

        //// // Asenkron Get Routine & Customer Name
        //public async Task<IDataResult<CustomerDto>> GetAsync(string customerName)
        //{
        //    var customer = await _unitOfWork.Customer.GetAsync(c => c.CustomerFirstName == customerName);
        //    if (customer != null)
        //    {
        //        return new DataResult<CustomerDto>(ResultStatus.Success, new CustomerDto
        //        {
        //            Customer = customer
        //        });
        //    }
        //    else
        //    {
        //        // Do nothing 
        //    }
        //    return new DataResult<CustomerDto>(ResultStatus.Error, "Couldn't find any customer", new CustomerDto
        //    {
        //        Customer = null
        //    });
        //}

        //// Asenkron Get All Routine
        //public async Task<IDataResult<CustomerListDto>> GetAllAsync()
        //{
        //    var customer = await _unitOfWork.Customer.GetAllAsync();

        //    if (customer.Count > 0)
        //    {
        //        return new DataResult<CustomerListDto>(ResultStatus.Success, new CustomerListDto
        //        {
        //            Customers = customer
        //        });
        //    }
        //    else
        //    {
        //        // Do nothing
        //    }
        //    return new DataResult<CustomerListDto>(ResultStatus.Error, "Couldn't find any customer", new CustomerListDto
        //    {
        //        Customers = null
        //    });
        //}

        //// Asenkron Get Routine & By Id
        //public async Task<IDataResult<CustomerDto>> GetById(int customerId)
        //{
        //    try
        //    {
        //        var customer = await _unitOfWork.Customer.GetById(c => c.CustomerId == customerId);
        //        if (customer != null)
        //        {
        //            return new DataResult<CustomerDto>(ResultStatus.Success, new CustomerDto
        //            {
        //                Customer = customer
        //            });
        //        }
        //        else
        //        {
        //            // Do nothing 
        //            return new DataResult<CustomerDto>(ResultStatus.Error, "Couldn't find any customer", new CustomerDto
        //            {
        //                Customer = null
        //            });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw;
        //    }

        //}

        //// Asenkron Get All Routine & Non Deleted Values
        //public async Task<IDataResult<CustomerListDto>> GetAllByNonDeletedAsync()
        //{
        //    var cusromers = await _unitOfWork.Customer.GetAllAsync(c => c.CustomerStatus == true);
        //    if (cusromers.Count > -1)
        //    {
        //        return new DataResult<CustomerListDto>(ResultStatus.Success, new CustomerListDto
        //        {
        //            Customers = cusromers
        //        });
        //    }

        //    return new DataResult<CustomerListDto>(ResultStatus.Error, "Error", new CustomerListDto
        //    {
        //        Customers = null
        //    });
        //}

        //// Asenkron Get All Customer Count Routine
        //public async Task<int> GetAllCustomerCount()
        //{
        //    var customerCount = await _unitOfWork.Customer.CountAsync();
        //    return customerCount;
        //}

        //// Asenkron Get All Customer Count Only Return True Routine
        //public async Task<int> GetAllCustomerNonDeletedCount()
        //{
        //    var customerCount = await _unitOfWork.Customer.CountAsync(c => c.CustomerStatus);
        //    return customerCount;
        //}

        //// Asenkron Update Routine
        //public async Task<IResult> Update(CustomerUpdateDto customerUpdateDto)
        //{
        //    var customer = _mapper.Map<Customer>(customerUpdateDto);
        //    try
        //    {

        //        await _unitOfWork.Customer.UpdateAsync(customer);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw;
        //    }
        //    await _unitOfWork.SaveAsync();
        //    return new Result(ResultStatus.Success, $"{customerUpdateDto.CustomerFullName} updating successfully");

        //}

        //public async Task<IDataResult<CustomerUpdateDto>> GetCustomerUpdateDtoByCustomerId(int customerId)
        //{
        //    // Bunu yapmışız anlatmamı ister misin ya da sen anlat bakalım 
        //    // Bu fonsiyonu anlatıyorum bir şey mi yazacaksın anlayamadım pek
        //    // anlat sen ben seni bekliyorum
        //    // İlk olarak bu fonskiyon IResult yerine IDataResult fark olarak
        //    // CustomerUpdateDto yü fonskiyon içerisinden çekerek verileri çekmiş oluyoruz
        //    // parametre olarak int değerinde bir customerId gönderiyoruz çünkü id ile çekme işlemi gerçekleştiricez
        //    // sonrasında bir tane var değeri atıyoruz bunu CustomerId ile eşitleyerek değer atıyoruz
        //    // bunu if komutunu içerisine alarak kontrol ediyoruz
        //    // bu kontrol
        //    // customer değerindeki bir değeri customerUpdateDto taki verinin içerisine atıyoruz
        //    // bunu da mapper sayesinde çekiyoruz
        //    // ve Data Result döndürerek Success atıyoruz
        //    // çıkış olarakta error atıyoruz
        //    // bu kadar brn bişey daha deneyeyim 
        //    // evet anlamışsın ne yazdığımızı şimdi bunu controller da çekmeni ve view e göndermeni istiyorum senden 
        //    var result = await _unitOfWork.Customer.AnyAsync(c => c.CustomerId == customerId);
        //    if (result)
        //    {
        //        var customer = await _unitOfWork.Customer.GetAsync(c => c.CustomerId == customerId);
        //        var customerUpdateDto = _mapper.Map<CustomerUpdateDto>(customer);
        //        return new DataResult<CustomerUpdateDto>(ResultStatus.Success, customerUpdateDto);
        //    }

        //    return new DataResult<CustomerUpdateDto>(ResultStatus.Error, "Couldn't find customer.", null);
        //}

    }
}
