using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Job
    {
        public int JobId { get; set; }
        [Required]
        public string? JobTitle { get; set; }

        public string? CompanyName { get; set; }

        public string? Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateApplied { get; set; }
    }
}
