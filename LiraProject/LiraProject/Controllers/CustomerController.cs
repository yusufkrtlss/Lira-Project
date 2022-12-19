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
