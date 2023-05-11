using Microsoft.AspNetCore.Mvc;
using task2.DataAccessLayer;

namespace task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context) 
        { 
            _context= context;
        }
        public IActionResult Index()
        {
            return View(_context.Models.ToList());
        }
    }
}
