using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Models;
using System.Threading.Tasks;
using System.Linq;

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
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string newString =  new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            Employee employee = new Employee
            {
                City = newString,
                Department = newString,
                Name = newString,
                Salary = DateTime.UtcNow.Millisecond
            };

            _context.Add(employee);
            await _context.SaveChangesAsync();

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
