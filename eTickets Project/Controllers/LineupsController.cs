using eTickets_Project.Data;
using eTickets_Project.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets_Project.Controllers
{
    public class LineupsController : Controller
    {
        private readonly ILineupsService _service;

        public LineupsController(ILineupsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();    
            return View(data);
        }

        ///Get: Lineups/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
