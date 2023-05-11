using Microsoft.AspNetCore.Mvc;
using task2.DataAccessLayer;
using task2.Models;

namespace task2.Controllers
{
    public class CarController1cs : Controller
    {
        private AppDbContext _context;
        public  CarController1cs(AppDbContext context) 
        {
             _context= context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();
            if(_context.Cars.Any(c => c.ModelId == id)) return NotFound();
            return View(_context.Cars.Where(c => c.ModelId == id).ToList());
        }
    }
}
