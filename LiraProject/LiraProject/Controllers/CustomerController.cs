using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Dto;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LiraProject.Controllers
{
    public class CustomerController : Controller
    {
        CompaniesManager cm = new CompaniesManager(new EfCompaniesRepository());
        CustomerManager cum = new CustomerManager(new EfCustomerRepository());
        //private readonly ICustomerService _customerService;

        //public CustomerController(ICustomerService customerService)
        //{
        //    _customerService = customerService;
        //}
        public IActionResult Index()
        {
            var model = cm.GetAllCompanies();
            return View(model);
        }
        [HttpGet]
        public IActionResult SignUp()
        {           
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Customer customer)
        {
            cum.CustomerAdd(customer);
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Customer customer)
        {
            
            var query = cum.GetAllCompanies().AsQueryable();
            
            query = query.Where(c => c.CustomerEmail == customer.CustomerEmail && c.CustomerPassword == customer.CustomerPassword);

            if(query != null)
            {
                return RedirectToAction("Index","Customer");
            }
            else
            {
                return BadRequest();
            }
           
        }
        //[HttpPost]
        //[Route("/CustomerController/Add")]
        //public async Task<IActionResult> Add(CustomerAddDto DTO)
        //{
        //    await _customerService.Add(DTO);
        //    var jsonCustomers = JsonConvert.SerializeObject(DTO);
        //    return Json(jsonCustomers);
        //}
    }
}
