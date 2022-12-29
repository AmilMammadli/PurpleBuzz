using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrupleBuzz.DAL;
using PrupleBuzz.Models;
using System.Diagnostics;

namespace PrupleBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Slider.ToListAsync();
            return View(slider);
        }
    }
}