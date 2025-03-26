using System;
using System.Threading;
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    class JobApplication
    {
        public static int count =0;
        public string CompanyName { get; set; }
        public DateTime DateApplied { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public JobApplication(string companyName, DateTime dateApplied, Status status)
        {
            CompanyName = companyName;
            DateApplied = dateApplied;
            Status = status.ToString();
        }
    }
}
