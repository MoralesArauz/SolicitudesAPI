using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolicitudesAPI.Models;

namespace SolicitudesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderCategoriesController : ControllerBase
    {
        private readonly MSCSolicitudesContext _context;

        public PurchaseOrderCategoriesController(MSCSolicitudesContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrderCategory>>> GetPurchaseOrderCategories()
        {
            return await _context.PurchaseOrderCategories.ToListAsync();
        }

        // GET: api/PurchaseOrderCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrderCategory>> GetPurchaseOrderCategory(int id)
        {
            var purchaseOrderCategory = await _context.PurchaseOrderCategories.FindAsync(id);

            if (purchaseOrderCategory == null)
            {
                return NotFound();
            }

            return purchaseOrderCategory;
        }

        // PUT: api/PurchaseOrderCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrderCategory(int id, PurchaseOrderCategory purchaseOrderCategory)
        {
            if (id != purchaseOrderCategory.PurchaseOrderCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrderCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderCategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PurchaseOrderCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseOrderCategory>> PostPurchaseOrderCategory(PurchaseOrderCategory purchaseOrderCategory)
        {
            _context.PurchaseOrderCategories.Add(purchaseOrderCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrderCategory", new { id = purchaseOrderCategory.PurchaseOrderCategoryId }, purchaseOrderCategory);
        }

        // DELETE: api/PurchaseOrderCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOrderCategory(int id)
        {
            var purchaseOrderCategory = await _context.PurchaseOrderCategories.FindAsync(id);
            if (purchaseOrderCategory == null)
            {
                return NotFound();
            }

            _context.PurchaseOrderCategories.Remove(purchaseOrderCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseOrderCategoryExists(int id)
        {
            return _context.PurchaseOrderCategories.Any(e => e.PurchaseOrderCategoryId == id);
        }
    }
}
