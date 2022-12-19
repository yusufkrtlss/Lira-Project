using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Dto;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

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
        public ActionResult Login(Customer customer)
        {
            
            var query = cum.GetAllCompanies().AsQueryable();
            
            query = query.Where(c => c.CustomerEmail == customer.CustomerEmail && c.CustomerPassword == customer.CustomerPassword);

            if(query != null)
            {
                
                HttpContext.Session.SetString("CustomerLogin", customer.CustomerEmail);
                
                return RedirectToAction("Index","Customer");
            }
            else
            {
                return BadRequest();
            }
           
        }
       
    }
}
