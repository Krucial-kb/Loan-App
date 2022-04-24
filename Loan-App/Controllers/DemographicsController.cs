using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoanDataAccess.DbModels;

namespace Amount_Loan_App.Controllers
{
    public class DemographicsController : Controller
    {
        private readonly LoanDbContext _context;

        public DemographicsController(LoanDbContext context)
        {
            _context = context;
        }

        // GET: Demographics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Demographics.ToListAsync());
        }

        // GET: Demographics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demographic = await _context.Demographics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demographic == null)
            {
                return NotFound();
            }

            return View(demographic);
        }

        // GET: Demographics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Demographics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,UserName")] Demographic demographic)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demographic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(demographic);
        }

        // GET: Demographics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demographic = await _context.Demographics.FindAsync(id);
            if (demographic == null)
            {
                return NotFound();
            }
            return View(demographic);
        }

        // POST: Demographics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,UserName")] Demographic demographic)
        {
            if (id != demographic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demographic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DemographicExists(demographic.Id))
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
            return View(demographic);
        }

        // GET: Demographics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demographic = await _context.Demographics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demographic == null)
            {
                return NotFound();
            }

            return View(demographic);
        }

        // POST: Demographics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var demographic = await _context.Demographics.FindAsync(id);
            _context.Demographics.Remove(demographic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DemographicExists(int id)
        {
            return _context.Demographics.Any(e => e.Id == id);
        }
    }
}
