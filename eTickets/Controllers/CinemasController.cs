using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var details = await _service.GetByIdAsync(id);
            if (details == null) return View("NotFound");
            return View(details);
        }

        // Get: Actors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var details = await _service.GetByIdAsync(id);
            if (details == null) return View("NotFound");
            return View(details);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema)
        {
            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var details = await _service.GetByIdAsync(id);
            if (details == null) return View("NotFound");
            return View(details);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var details = await _service.GetByIdAsync(id);
            if (details == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
