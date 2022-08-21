using eTickets_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets_Project.Controllers
{
    public class LocationsController : Controller
    {
        private readonly AppDbContext _context;

        public LocationsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allLocations = await _context.Locations.ToListAsync();
            return View(allLocations);
        }
    }
}
