using eTickets_Project.Data;
using eTickets_Project.Data.Services;
using eTickets_Project.Models;
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
            var data = await _service.GetAllAsync();    
            return View(data);
        }

        ///Get: Lineups/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("BandName, BandLogo, BandBio")]Lineup lineup)
        {
            if(!ModelState.IsValid)
            {
                return View(lineup);
            }
            await _service.AddAsync(lineup);
            return RedirectToAction(nameof(Index));
        }

        ///Get: Lineups/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var lineupsDetails = await _service.GetByIdAsync(id);
            if (lineupsDetails == null) return View("NotFound");
            return View(lineupsDetails);
        }


        ///Get: Lineups/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var lineupsDetails = await _service.GetByIdAsync(id);
            if (lineupsDetails == null) return View("NotFound");
            return View(lineupsDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("BandId, BandName, BandLogo, BandBio")] Lineup lineup)
        {
            if (!ModelState.IsValid)
            {
                return View(lineup);
            }
            await _service.UpdateAsync(id, lineup);
            return RedirectToAction(nameof(Index));
        }

        ///Get: Lineups/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var lineupsDetails = await _service.GetByIdAsync(id);
            if (lineupsDetails == null) return View("NotFound");
            return View(lineupsDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lineupsDetails = await _service.GetByIdAsync(id);
            if (lineupsDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            
            return RedirectToAction(nameof(Index));
        }

    }
}
