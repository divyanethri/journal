using System.ComponentModel.DataAnnotations;

namespace JournalApp.Domain
{
    public class SleepTracker
    {
        [Key]
        public int UserId { get; set; }
        public DateTime SleepAt { get; set; }
        public DateTime WakeUpAt { get; set; }
        public double Duration { get; set; }
        public DateOnly Date { get; set; }
    }
}
