namespace JobTracker.Models
{
    public class Job
    {
        public int JobId { get; set; }

        public string? JobTitle { get; set; }

        public string? CompanyName { get; set; }

        public string? Status { get; set; }

        public string? DateApplied { get; set; }
    }
}
