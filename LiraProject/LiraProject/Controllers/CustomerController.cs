using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LiraProject.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("/Customer/Add")]
        public async Task<IActionResult> Add(CustomerAddDto DTO)
        {
            await _customerService.Add(DTO);
            var jsonCustomers = JsonConvert.SerializeObject(DTO);
            return Json(jsonCustomers);
        }
    }
}
