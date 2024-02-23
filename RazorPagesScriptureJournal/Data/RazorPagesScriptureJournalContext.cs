using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesScriptureJournal.Models;

namespace RazorPagesScriptureJournal.Data
{
    public class RazorPagesScriptureJournalContext : DbContext
    {
        public RazorPagesScriptureJournalContext (DbContextOptions<RazorPagesScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesScriptureJournal.Models.Scripture> Scripture { get; set; } = default!;
    }
}
