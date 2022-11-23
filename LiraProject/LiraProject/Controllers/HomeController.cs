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
        public IActionResult Details(int id)
        {
            var value = cm.GetById(id);
            return View(value);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<JsonResult> GetCompanysAsync(string searchQuery)
        {
            var query = cm.GetAllCompanies().AsQueryable();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query = query.Where(c =>

                        c.CompanySymbol.Contains(searchQuery) ||
                        c.CompanyName.Contains(searchQuery)
                );
            }

            // load the courses
            var courses = await query.ToListAsync();

            // return the data as json result
            return new JsonResult(courses);
        }
       
        
        [Produces("application/json")]
        [HttpGet("search")]
        [Route("/home/search")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search()
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

            // load the courses
            var courses = await query.ToListAsync();

            // return the data as json result
            return Ok(courses);
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