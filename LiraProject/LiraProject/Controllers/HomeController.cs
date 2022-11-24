using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.EntityFramework.Context;
using LiraProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LiraProject.Controllers
{
    public class HomeController : Controller
    {
        CompaniesManager cm = new CompaniesManager(new EfCompaniesRepository());



        
        public IActionResult Index()
        {
            var values = cm.GetAllCompanies();
            return View(values);
        }

        [HttpGet]
        [Route("/home/details")]
        public IActionResult Details(string searchString)
        {
            var query = cm.GetAllCompanies().AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(c => c.CompanySymbol == searchString);
                
            }
            int id = query.Select(c => c.CompanyId).FirstOrDefault();

            var stocks = cm.GetById(id);
            
            return View(stocks);
        }

        
       
        
        [Produces("application/json")]
        [HttpGet("search")]
        [Route("/home/search")]
        [ValidateAntiForgeryToken]
        public JsonResult SearchAsync()
        {
            string term = HttpContext.Request.Query["term"].ToString().ToUpper();
            var query = cm.GetAllCompanies().AsQueryable();

            if (!string.IsNullOrEmpty(term))
            {
                query = query.Where(c =>

                        c.CompanySymbol.Contains(term) ||
                        c.CompanyName.Contains(term)
                );
            }           
            var companies = query.Select(c=>c.CompanySymbol).ToList();

           return Json(companies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}