using System.ComponentModel.DataAnnotations;

namespace RazorPagesScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string StandardWork { get; set; } = string.Empty;

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; } = string.Empty;

        [StringLength(60, MinimumLength = 0)]
        [Required]
        public string Chapter { get; set; } = string.Empty;

        [StringLength(60, MinimumLength = 0)]
        public string Verse { get; set; } = string.Empty;

        [StringLength(600, MinimumLength = 3)]
        public string JounralEntry { get; set; } = string.Empty;

        [StringLength(120, MinimumLength = 0)]
        public string Keywords { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
    }
}
