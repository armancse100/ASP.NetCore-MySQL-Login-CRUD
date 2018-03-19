using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Models;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class HomeController : Controller
    {
        InventoryManagementDbContext _context;
        public HomeController(InventoryManagementDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
