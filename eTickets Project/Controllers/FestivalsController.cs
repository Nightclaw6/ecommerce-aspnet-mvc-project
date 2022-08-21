using eTickets_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets_Project.Controllers
{
    public class FestivalsController : Controller
    {
        private readonly AppDbContext _context;

        public FestivalsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allFestivals = await _context.Festivals.Include(n => n.Location).OrderBy(n => n.FestivalName).ToListAsync();
            return View(allFestivals);
        }
    }
}
