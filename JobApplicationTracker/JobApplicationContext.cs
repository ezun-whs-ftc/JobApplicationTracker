using System.Data.Entity;
namespace JobApplicationTracker
{
    class JobApplicationContext : DbContext
    {
        public JobApplicationContext() : base("name=JobApplicationTracker.Properties.Settings.JobApplicationsConnectionString")
        {
        }

        public DbSet<JobApplication> JobApplications { get; set; }
    }

    
}
