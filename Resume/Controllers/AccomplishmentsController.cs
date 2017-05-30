using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resume.Models;

namespace Resume.Controllers
{
    public class AccomplishmentsController : Controller
    {
        private readonly AccomplishmentContext _context;
        private readonly JobContext _jobContext;

        public AccomplishmentsController(AccomplishmentContext context)
        {
            _context = context;    
        }

        // GET: Accomplishments
        public async Task<IActionResult> Index()
        {
            var jobs = from j in _jobContext.Job orderby j.ID select j.JobTitle;
            var jobList = new SelectList(jobs);

            return View(await _context.Accomplishment.ToListAsync());
        }

        // GET: Accomplishments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accomplishment = await _context.Accomplishment
                .SingleOrDefaultAsync(m => m.ID == id);
            if (accomplishment == null)
            {
                return NotFound();
            }

            return View(accomplishment);
        }

        // GET: Accomplishments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accomplishments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,accomplishment,JobID")] Accomplishment accomplishment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accomplishment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(accomplishment);
        }

        // GET: Accomplishments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accomplishment = await _context.Accomplishment.SingleOrDefaultAsync(m => m.ID == id);
            if (accomplishment == null)
            {
                return NotFound();
            }
            return View(accomplishment);
        }

        // POST: Accomplishments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,accomplishment,JobID")] Accomplishment accomplishment)
        {
            if (id != accomplishment.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accomplishment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccomplishmentExists(accomplishment.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(accomplishment);
        }

        // GET: Accomplishments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accomplishment = await _context.Accomplishment
                .SingleOrDefaultAsync(m => m.ID == id);
            if (accomplishment == null)
            {
                return NotFound();
            }

            return View(accomplishment);
        }

        // POST: Accomplishments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accomplishment = await _context.Accomplishment.SingleOrDefaultAsync(m => m.ID == id);
            _context.Accomplishment.Remove(accomplishment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AccomplishmentExists(int id)
        {
            return _context.Accomplishment.Any(e => e.ID == id);
        }
    }
}
