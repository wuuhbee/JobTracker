using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("Statuses")]
        public int StatusId { get; set; }
        public virtual Status? Statuses { get; set; }

        [Display(Name = "Date Applied")]
        [DataType(DataType.Date)]
        public DateTime? DateApplied { get; set; }
    }
}
