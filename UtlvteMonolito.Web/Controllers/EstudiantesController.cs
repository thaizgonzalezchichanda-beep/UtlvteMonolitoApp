using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UtlvteMonolito.Web.Data;
using UtlvteMonolito.Web.Models;

namespace UtlvteMonolito.Web.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstudiantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Estudiantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estudiantes.ToListAsync());
        }

        // GET: Estudiantes/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Estudiantes/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudiante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);
        }
    }
}