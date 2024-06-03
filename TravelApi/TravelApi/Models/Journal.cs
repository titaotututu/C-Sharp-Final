using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TravelApi.Models
{
    public class Journal
    {
        [Key]
        public long JournalId { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public string Title { get; set; }
        public string Weather { get; set; }
        public string Emotion { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        [Required]
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User ?User { get; set; }
    }
}
