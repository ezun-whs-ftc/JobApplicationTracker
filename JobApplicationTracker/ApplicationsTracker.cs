using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    class ApplicationsTracker
    {
        private static List<JobApplication> rejectedApplications = new List<JobApplication>();
        private static List<JobApplication> AppliedApplications = new List<JobApplication>();
        private static List<JobApplication> InterviewedApplications = new List<JobApplication>();
        private static List<JobApplication> OfferedApplications = new List<JobApplication>();

        public static void AddApplication(JobApplication application)
        {
            switch(application.GetStatus())
            {
                case Status.Applied:
                    AppliedApplications.Add(application);
                    break;
                case Status.Interviewed:
                    InterviewedApplications.Add(application);
                    break;
                case Status.Offered:
                    OfferedApplications.Add(application);
                    break;
                case Status.Rejected:
                    rejectedApplications.Add(application);
                    break;
            }
        }

        public void RemoveApplication(JobApplication application)
        {
            switch(application.GetStatus())
            {
                case Status.Applied:
                    AppliedApplications.Remove(application);
                    break;
                case Status.Interviewed:
                    InterviewedApplications.Remove(application);
                    break;
                case Status.Offered:
                    OfferedApplications.Remove(application);
                    break;
                case Status.Rejected:
                    rejectedApplications.Remove(application);
                    break;
            }
        }

        public static List<JobApplication> GetApplications(Status x)
        {
           switch(x)
            {
                case Status.Applied:
                    return AppliedApplications;
                case Status.Interviewed:
                    return InterviewedApplications;
                case Status.Offered:
                    return OfferedApplications;
                case Status.Rejected:
                    return rejectedApplications;
                default: return null;
            }
        }
        public static double NumberOfApplications(Status x)
        {
            return GetApplications(x).Count;
        }

    }
}
