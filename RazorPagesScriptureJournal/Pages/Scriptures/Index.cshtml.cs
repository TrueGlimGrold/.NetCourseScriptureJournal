using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesScriptureJournal.Data;
using RazorPagesScriptureJournal.Models;

namespace RazorPagesScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesScriptureJournal.Data.RazorPagesScriptureJournalContext _context;

        public IndexModel(RazorPagesScriptureJournal.Data.RazorPagesScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchKeywordString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchBookString { get; set; }

        public SelectList? Books { get; set; }

        public SelectList? Keywords { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ScriptureBook { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ScriptureKeyword { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> keywordQuery = from m in _context.Scripture
                                            orderby m.Keywords
                                            select m.Keywords;

            IQueryable<string> bookQuery = from m in _context.Scripture
                                              orderby m.Book
                                              select m.Book;


            var scriptures = from m in _context.Scripture
                         select m;

            if (!string.IsNullOrEmpty(SearchBookString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchBookString));
            }
            
            if (!string.IsNullOrEmpty(SearchKeywordString))
            {
                scriptures = scriptures.Where(x => x.Keywords.Contains(SearchKeywordString));
            }

            Keywords = new SelectList(await keywordQuery.Distinct().ToListAsync());

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            Scripture = await scriptures.ToListAsync();
        }
    }
}
