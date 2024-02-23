using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesScriptureJournal.Data;
using RazorPagesScriptureJournal.Models;

namespace RazorPagesScriptureJournal.Pages.Scriptures
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesScriptureJournal.Data.RazorPagesScriptureJournalContext _context;

        public CreateModel(RazorPagesScriptureJournal.Data.RazorPagesScriptureJournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Scripture Scripture { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Scripture.Add(Scripture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
