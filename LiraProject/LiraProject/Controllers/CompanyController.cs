using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace LiraProject.Controllers
{
    public class CompanyController : Controller
    {
        CompaniesManager cm = new CompaniesManager(new EfCompaniesRepository());
        


        [HttpGet]
        [Route("/company/details")]
        public IActionResult Details(string symbol)
        {
            var query = cm.GetAllCompanies().AsQueryable();
            if (!string.IsNullOrEmpty(symbol))
            {
                query = query.Where(c => c.CompanySymbol == symbol);

            }
            int id = query.Select(c => c.CompanyId).FirstOrDefault();

            var stocks = cm.GetById(id);
            return View(stocks);

            
        }
        [HttpGet]
        public ActionResult CompanyPage(int CompanyId)
        {
            var model=cm.GetById(CompanyId);
            return View(model);
        }

       
        public ActionResult CompanyInfo(int CompanyId)
        {
           

            var stock = cm.GetById(CompanyId);
            return View(stock);
        }

        public ActionResult Compare(int CompanyId)
        {
            var stock = cm.GetById(CompanyId);
            return View(stock);
        }

        public ActionResult Graph1(int CompanyId)
        {
            var stock = cm.GetById(CompanyId);
            return View("Graph1", stock);
        }

        
    }
}
