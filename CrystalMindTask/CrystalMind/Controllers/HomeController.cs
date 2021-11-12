using CrystalMind.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrystalMind.Data;
using CrystalMind.Models.CustomerViewModels;
using Microsoft.Extensions.Logging;

namespace CrystalMind.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CustomerContext _context;

        public HomeController(ILogger<HomeController> logger, CustomerContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> About()
        {
            IQueryable<AdressGroup> data =
                from customer in _context.Customers
                group customer by customer.CustomerDOB into dateGroup
                select new AdressGroup()
                {
                    CustomerDOB = dateGroup.Key,
                    CustomerCount = dateGroup.Count()
                };
            return View(await data.AsNoTracking().ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
