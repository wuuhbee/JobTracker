using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string? StatusName { get; set; }
    }
}
