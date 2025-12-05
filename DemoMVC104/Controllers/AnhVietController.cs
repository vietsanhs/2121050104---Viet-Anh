using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC104.Data;
using DemoMVC104.Models;

namespace DemoMVC104.Controllers
{
    public class AnhVietController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnhVietController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AnhViet
        public async Task<IActionResult> Index()
        {
            return View(await _context.AnhViet.ToListAsync());
        }

        // GET: AnhViet/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anhViet = await _context.AnhViet
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (anhViet == null)
            {
                return NotFound();
            }

            return View(anhViet);
        }

        // GET: AnhViet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnhViet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,FullName,Address")] AnhViet anhViet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(anhViet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(anhViet);
        }

        // GET: AnhViet/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anhViet = await _context.AnhViet.FindAsync(id);
            if (anhViet == null)
            {
                return NotFound();
            }
            return View(anhViet);
        }

        // POST: AnhViet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,FullName,Address")] AnhViet anhViet)
        {
            if (id != anhViet.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(anhViet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnhVietExists(anhViet.PersonId))
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
            return View(anhViet);
        }

        // GET: AnhViet/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anhViet = await _context.AnhViet
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (anhViet == null)
            {
                return NotFound();
            }

            return View(anhViet);
        }

        // POST: AnhViet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var anhViet = await _context.AnhViet.FindAsync(id);
            if (anhViet != null)
            {
                _context.AnhViet.Remove(anhViet);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnhVietExists(string id)
        {
            return _context.AnhViet.Any(e => e.PersonId == id);
        }
    }
}
