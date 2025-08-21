using JobTracker.Models;
using Microsoft.EntityFrameworkCore;


namespace JobTracker.JobContext
{
    public class JobContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
    
        public JobContext(DbContextOptions<JobContext> options) :  base(options)
        {
        }
    }
}
