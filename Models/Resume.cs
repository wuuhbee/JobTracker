using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Resume
    {
        public int Id { get; set; }

        [DisplayName("Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; } = DateTime.Now;

        [DisplayName("File Name")]
        public required string FileName { get; set; }

        public required string FilePath { get; set; }
        }
}
