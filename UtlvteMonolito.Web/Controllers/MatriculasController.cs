using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UtlvteMonolito.Web.Data;
using UtlvteMonolito.Web.Models;

namespace UtlvteMonolito.Web.Controllers
{
    public class MatriculasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatriculasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var matriculas = await _context.Matriculas
                .Include(m => m.Estudiante)
                .Include(m => m.Asignatura)
                .ToListAsync();
            return View(matriculas);
        }

        public IActionResult Crear()
        {
            ViewData["EstudianteId"] = new SelectList(_context.Estudiantes, "Id", "Nombres");
            ViewData["AsignaturaId"] = new SelectList(_context.Asignaturas, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("EstudianteId,AsignaturaId")] Matricula matricula)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matricula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstudianteId"] = new SelectList(_context.Estudiantes, "Id", "Nombres", matricula.EstudianteId);
            ViewData["AsignaturaId"] = new SelectList(_context.Asignaturas, "Id", "Nombre", matricula.AsignaturaId);
            return View(matricula);
        }
    }
}