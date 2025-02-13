using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationTracker
{
    class ApplicationsTracker
    {
        public static List<JobApplication> applications = new List<JobApplication>();

        public void AddApplication(JobApplication application)
        {
            applications.Add(application);
        }

        public void RemoveApplication(JobApplication application)
        {
            applications.Remove(application);
        }

        public List<JobApplication> GetApplications()
        {
            return applications;
        }
    }
}
