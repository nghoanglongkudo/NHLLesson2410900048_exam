
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenHoangLong2410900048_exam.Models;

public class NhlEmployeesController : Controller
{
    private readonly NHLLesson2410900048_examContext _context;

    public NhlEmployeesController(NHLLesson2410900048_examContext context)
    {
        _context = context;
    }

    // GET: NHLEMPLOYEES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NhlEmployee.ToListAsync());
    }

    // GET: NHLEMPLOYEES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nhlemployee = await _context.NhlEmployee
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nhlemployee == null)
        {
            return NotFound();
        }

        return View(nhlemployee);
    }

    // GET: NHLEMPLOYEES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NHLEMPLOYEES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NhlName,NhlGender,NhlBirthDay,NhlEmail,NhlPhone,NhlActive")] NhlEmployee nhlemployee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nhlemployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nhlemployee);
    }

    // GET: NHLEMPLOYEES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nhlemployee = await _context.NhlEmployee.FindAsync(id);
        if (nhlemployee == null)
        {
            return NotFound();
        }
        return View(nhlemployee);
    }

    // POST: NHLEMPLOYEES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,NhlName,NhlGender,NhlBirthDay,NhlEmail,NhlPhone,NhlActive")] NhlEmployee nhlemployee)
    {
        if (id != nhlemployee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nhlemployee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhlEmployeeExists(nhlemployee.Id))
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
        return View(nhlemployee);
    }

    // GET: NHLEMPLOYEES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nhlemployee = await _context.NhlEmployee
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nhlemployee == null)
        {
            return NotFound();
        }

        return View(nhlemployee);
    }

    // POST: NHLEMPLOYEES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var nhlemployee = await _context.NhlEmployee.FindAsync(id);
        if (nhlemployee != null)
        {
            _context.NhlEmployee.Remove(nhlemployee);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NhlEmployeeExists(int? id)
    {
        return _context.NhlEmployee.Any(e => e.Id == id);
    }
}
