using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.models
{
    public class Journal
    {
        public long JournalId { get; set; }
        public DateTime Time { get; set; }
        public string Title { get; set; }
        public string Weather { get; set; }
        public string Emotion { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public long UserId { get; set; }
    }
}
