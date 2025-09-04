using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class ResumeViewModel
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public string FileName { get; set; }

        [Required]
        public IFormFile ResumeFile { get; set; }
    }
}
