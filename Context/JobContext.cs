using JobTracker.Models;
using Microsoft.EntityFrameworkCore;


namespace JobTracker.Context
{
    public class JobContext : DbContext
    {
    
        public JobContext(DbContextOptions<JobContext> options) :  base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }

    }
}
