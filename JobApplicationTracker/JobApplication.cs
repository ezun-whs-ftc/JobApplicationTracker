using System;
using static JobApplicationTracker.Constants;
namespace JobApplicationTracker
{
    class JobApplication
    {
        public string CompanyName { get; set; }
        public DateTime DateApplied { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }

    }
}
