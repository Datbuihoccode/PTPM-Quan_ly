using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Demo_MVC.Models;
using Demo_MVC.Data;
namespace Demo_MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Students.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student std)
        {
            await _context.AddAsync(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string id)
        {
            if(id == null || _context.Students == null)
            {
                return NotFound();
            }
            var std = await _context.Students.FindAsync(id);
            if(std == null)
            {
                return NotFound();
            }
            return View(std);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,[Bind("Id, Fullname, Email")] Student std)
        {
            if (id != std.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(std);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(std.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(std);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }
            var std = await _context.Students.FindAsync(id);
            if (std == null)
            {
                return NotFound();
            }
            return View(std);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'MyApp.Data.StudentContext.Student'  is null.");
            }
            var std = await _context.Students.FindAsync(id);
            if (std != null)
            {
                _context.Students.Remove(std);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool StudentExists(string id)
        {
            return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
