using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryManagement.Models;

namespace InventoryManagement.Controllers
{
    public class ExitsController : Controller
    {
        private readonly InventoryManagementDbContext _context;

        public ExitsController(InventoryManagementDbContext context)
        {
            _context = context;
        }

        // GET: Exits
        public async Task<IActionResult> Index()
        {
            var inventoryManagementDbContext = _context.Exits.Include(e => e.Entry).Include(e => e.ProductName);
            return View(await inventoryManagementDbContext.ToListAsync());
        }

        // GET: Exits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exit = await _context.Exits
                .Include(e => e.Entry)
                .Include(e => e.ProductName)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (exit == null)
            {
                return NotFound();
            }

            return View(exit);
        }

        // GET: Exits/Create
        public IActionResult Create()
        {
            ViewData["EntryId"] = new SelectList(_context.Entries, "Id", "AddressOfSupplier");
            ViewData["ProductId"] = new SelectList(_context.ProductCategorys, "Id", "Name");
            return View();
        }

        // POST: Exits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReceiveDate,NameOfUser,AddressOfUser,DemandnoteNo,NumberOfReceivedProduct,TotalNoOfProductAfterdeduction,ProductId,EntryId")] Exit exit)
        {
            Product product = await _context.Products.Where(p => p.Id == exit.ProductId).FirstOrDefaultAsync();
            if (product == null || product.CurrentStoreValue<exit.NumberOfReceivedProduct)
                return View();
            if (ModelState.IsValid)
            {
                product.CurrentStoreValue = product.CurrentStoreValue - 1;
                _context.Add(exit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EntryId"] = new SelectList(_context.Entries, "Id", "AddressOfSupplier", exit.EntryId);
            ViewData["ProductId"] = new SelectList(_context.ProductCategorys, "Id", "Name", exit.ProductId);
            return View(exit);
        }

        // GET: Exits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exit = await _context.Exits.SingleOrDefaultAsync(m => m.Id == id);
            if (exit == null)
            {
                return NotFound();
            }
            ViewData["EntryId"] = new SelectList(_context.Entries, "Id", "AddressOfSupplier", exit.EntryId);
            ViewData["ProductId"] = new SelectList(_context.ProductCategorys, "Id", "Name", exit.ProductId);
            return View(exit);
        }

        // POST: Exits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReceiveDate,NameOfUser,AddressOfUser,DemandnoteNo,NumberOfReceivedProduct,TotalNoOfProductAfterdeduction,ProductId,EntryId")] Exit exit)
        {
            if (id != exit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExitExists(exit.Id))
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
            ViewData["EntryId"] = new SelectList(_context.Entries, "Id", "AddressOfSupplier", exit.EntryId);
            ViewData["ProductId"] = new SelectList(_context.ProductCategorys, "Id", "Name", exit.ProductId);
            return View(exit);
        }

        // GET: Exits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exit = await _context.Exits
                .Include(e => e.Entry)
                .Include(e => e.ProductName)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (exit == null)
            {
                return NotFound();
            }

            return View(exit);
        }

        // POST: Exits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exit = await _context.Exits.SingleOrDefaultAsync(m => m.Id == id);
            _context.Exits.Remove(exit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExitExists(int id)
        {
            return _context.Exits.Any(e => e.Id == id);
        }
    }
}
