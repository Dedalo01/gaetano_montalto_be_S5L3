using eserL5S3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eserL5S3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(StaticDB.Items);
        }

        // get per pagina Details
        public IActionResult Details([FromRoute] int id)
        {
            Item? item = StaticDB.GetItemById(id);
            if (item == null)
            {
                return View("Error");
            }
            return View(item);
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
