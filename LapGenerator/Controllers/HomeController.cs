using LapGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LapGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LapContext _context;

        public HomeController(ILogger<HomeController> logger,
            LapContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Report()
        {
            var report = from p in _context.Set<Race>()
                         group p by p.DriverName
                         into g
                         select new Report() { Name = g.Key, AverageTime = (int)g.Average(x => x.LapTime), LapCount = g.Count(), MaxTime = g.Max(x => x.LapTime), MinTime = g.Min(x => x.LapTime) };
            return View(report);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}