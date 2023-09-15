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
    public class Student_DetailsController : Controller
    {
        private readonly ERP_LatestContext _context;

        public Student_DetailsController(ERP_LatestContext context)
        {
            _context = context;
        }

        // GET: Student_Details
        public async Task<IActionResult> Index()
        {
              return _context.Student_Details != null ? 
                          View(await _context.Student_Details.ToListAsync()) :
                          Problem("Entity set 'ERP_LatestContext.Student_Details'  is null.");
        }

        // GET: Student_Details/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Student_Details == null)
            {
                return NotFound();
            }

            var student_Details = await _context.Student_Details
                .FirstOrDefaultAsync(m => m.StudentDetailId == id);
            if (student_Details == null)
            {
                return NotFound();
            }

            return View(student_Details);
        }

        // GET: Student_Details/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentDetailId,StudentDob,StudentId,StudentAlternateEmail,StudentAlternateMobile,StudentFatherName,StudentMotherName,StudentPermanentAddress,StudentCurrentAddress,StudentFatherMobile,StudentMotherMobile,StudentBloodGroup,StudentPhoto,StudentCetRank,StudentPreviousSchoolDetails,StudentGender,StudentCategory,StudentCommunity,StudentProgramme,StudentBatch,StudentShift,StudentIsMgmt,StudentIsOutDelhi,CreatedAt,UpdatedAt,StudentCetType,MentorId")] Student_Details student_Details)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student_Details);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student_Details);
        }

        // GET: Student_Details/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Student_Details == null)
            {
                return NotFound();
            }

            var student_Details = await _context.Student_Details.FindAsync(id);
            if (student_Details == null)
            {
                return NotFound();
            }
            return View(student_Details);
        }

        // POST: Student_Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentDetailId,StudentDob,StudentId,StudentAlternateEmail,StudentAlternateMobile,StudentFatherName,StudentMotherName,StudentPermanentAddress,StudentCurrentAddress,StudentFatherMobile,StudentMotherMobile,StudentBloodGroup,StudentPhoto,StudentCetRank,StudentPreviousSchoolDetails,StudentGender,StudentCategory,StudentCommunity,StudentProgramme,StudentBatch,StudentShift,StudentIsMgmt,StudentIsOutDelhi,CreatedAt,UpdatedAt,StudentCetType,MentorId")] Student_Details student_Details)
        {
            if (id != student_Details.StudentDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student_Details);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Student_DetailsExists(student_Details.StudentDetailId))
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
            return View(student_Details);
        }

        // GET: Student_Details/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Student_Details == null)
            {
                return NotFound();
            }

            var student_Details = await _context.Student_Details
                .FirstOrDefaultAsync(m => m.StudentDetailId == id);
            if (student_Details == null)
            {
                return NotFound();
            }

            return View(student_Details);
        }

        // POST: Student_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Student_Details == null)
            {
                return Problem("Entity set 'ERP_LatestContext.Student_Details'  is null.");
            }
            var student_Details = await _context.Student_Details.FindAsync(id);
            if (student_Details != null)
            {
                _context.Student_Details.Remove(student_Details);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Student_DetailsExists(int id)
        {
          return (_context.Student_Details?.Any(e => e.StudentDetailId == id)).GetValueOrDefault();
        }
    }
}
