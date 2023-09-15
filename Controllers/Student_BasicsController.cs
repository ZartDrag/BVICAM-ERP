using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP_Latest.Data;
using ERP_Latest.Models;

namespace ERP_Latest.Controllers
{
    public class Student_BasicsController : Controller
    {
        private readonly ERP_LatestContext _context;

        public Student_BasicsController(ERP_LatestContext context)
        {
            _context = context;
        }

        // GET: Student_Basics
        public async Task<IActionResult> Index()
        {
              return _context.Student_Basics != null ? 
                          View(await _context.Student_Basics.ToListAsync()) :
                          Problem("Entity set 'ERP_LatestContext.Student_Basics'  is null.");
        }

        // GET: Student_Basics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Student_Basics == null)
            {
                return NotFound();
            }

            var student_Basics = await _context.Student_Basics
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student_Basics == null)
            {
                return NotFound();
            }

            return View(student_Basics);
        }

        // GET: Student_Basics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student_Basics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,StudentName,CetType,CetNo,EnrollNo,StudentMobile,StudentEmail,StudentToken,IsVerified,IsWithdraw,WithdrawDate,WithdrawReason,CreatedAt,UpdatedAt")] Student_Basics student_Basics)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student_Basics);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student_Basics);
        }

        // GET: Student_Basics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Student_Basics == null)
            {
                return NotFound();
            }

            var student_Basics = await _context.Student_Basics.FindAsync(id);
            if (student_Basics == null)
            {
                return NotFound();
            }
            return View(student_Basics);
        }

        // POST: Student_Basics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,StudentName,CetType,CetNo,EnrollNo,StudentMobile,StudentEmail,StudentToken,IsVerified,IsWithdraw,WithdrawDate,WithdrawReason,CreatedAt,UpdatedAt")] Student_Basics student_Basics)
        {
            if (id != student_Basics.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student_Basics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Student_BasicsExists(student_Basics.StudentId))
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
            return View(student_Basics);
        }

        // GET: Student_Basics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Student_Basics == null)
            {
                return NotFound();
            }

            var student_Basics = await _context.Student_Basics
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student_Basics == null)
            {
                return NotFound();
            }

            return View(student_Basics);
        }

        // POST: Student_Basics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Student_Basics == null)
            {
                return Problem("Entity set 'ERP_LatestContext.Student_Basics'  is null.");
            }
            var student_Basics = await _context.Student_Basics.FindAsync(id);
            if (student_Basics != null)
            {
                _context.Student_Basics.Remove(student_Basics);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Student_BasicsExists(int id)
        {
          return (_context.Student_Basics?.Any(e => e.StudentId == id)).GetValueOrDefault();
        }
    }
}
