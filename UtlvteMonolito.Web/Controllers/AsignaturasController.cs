using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UtlvteMonolito.Web.Data;
using UtlvteMonolito.Web.Models;

namespace UtlvteMonolito.Web.Controllers
{
    public class AsignaturasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AsignaturasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Asignaturas
        public async Task<IActionResult> Index()
        {
            var asignaturas = await _context.Asignaturas.ToListAsync();
            return View(asignaturas);
        }

        // GET: Asignaturas/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Asignaturas/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("Codigo,Nombre,Creditos,Nivel")] Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(asignatura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(asignatura);
        }
    }
}