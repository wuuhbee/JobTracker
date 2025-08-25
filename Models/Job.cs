using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Job
    {
        public int JobId { get; set; }
        [Required]
        [Display(Name = "Job Title")]
        public string? JobTitle { get; set; }

        [Display(Name = "Company Name")]
        public string? CompanyName { get; set; }

        public string? Status { get; set; }

        [Display(Name = "Date Applied")]
        [DataType(DataType.Date)]
        public DateTime? DateApplied { get; set; }
    }
}
