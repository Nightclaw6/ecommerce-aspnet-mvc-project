using eTickets_Project.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eTickets_Project.Controllers
{
    public class LineupsController : Controller
    {
        private readonly AppDbContext _context;

        public LineupsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Lineups.ToList();    
            return View(data);
        }
    }
}
