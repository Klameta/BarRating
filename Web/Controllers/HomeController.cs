using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BarReviewDbContext _context;
        private readonly Counts counts;

        public HomeController(ILogger<HomeController> logger, BarReviewDbContext context)
        {
            _logger = logger;
            _context = context;

            counts = new Counts(_context.Bars.Count(), _context.Reviews.Count(), _context.Users.Count());
        }

        public IActionResult Index()
        {
            return View(counts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class Counts
    {
        public Counts(int bar, int review, int user)
        {
            Bar = bar;
            Review = review;
            Users = user;
        }

        public int Bar { get; set; }
        public int Review { get; set; }
        public int Users { get; set; }

    }
}
