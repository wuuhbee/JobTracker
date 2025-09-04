using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class ResumeViewModel
    {
        public string FileName { get; set; }

        [Required]
        public IFormFile ResumeFile { get; set; }
    }
}
