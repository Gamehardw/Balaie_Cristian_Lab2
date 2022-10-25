using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Balaie_Cristian_Lab2.Data;
using Balaie_Cristian_Lab2.Models;

namespace Balaie_Cristian_Lab2.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly Balaie_Cristian_Lab2.Data.Balaie_Cristian_Lab2Context _context;

        public DeleteModel(Balaie_Cristian_Lab2.Data.Balaie_Cristian_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            var publisher = await _context.Book.Include(b => b.Publisher).ToListAsync();
            var author = await _context.Book.Include(c => c.Author).ToListAsync();
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }
            var book = await _context.Book.FindAsync(id);

            if (book != null)
            {
                Book = book;
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
